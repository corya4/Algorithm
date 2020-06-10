using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace mem_hkj
{
    public class IOUtil
    {
        IOMainForm mainForm;
        List<IOFileForm> subList;

        public IOUtil(IOMainForm main)
        {
            mainForm = main;
            subList = new List<IOFileForm>();
        }


        public void addMdiForm(IOFileForm sub)
        {
            subList.Add(sub);
            setStatusSerial();
        }

        public void RemoveForm(IOFileForm sub)
        {
            subList.Remove(sub);
            setStatusSerial();
        }

        public void setStatusSerial()
        {
            if (subList.Count == 0)
            { //SubFormがない場合

                mainForm.lblStu.Text = "";
            }
            else
            {//SubFormがある場合
                mainForm.lblStu.Text = IOText.TOTALPAGE + subList.Count;
            }
        }

        public IOFileForm getFoucesdForm() //FocuesdされたSubFormをReturn
        {
            foreach (IOFileForm sf in subList)
            {
                if (sf.ContainsFocus || sf.Focused) //現在選択されているSubFormならこのFormをReturn
                {
                    return sf;
                }
                else
                {
                    //技能なし
                }
            }
            return null;
        }

        public bool SaveFile()
        {

            IOFileForm sub = getFoucesdForm();
            SaveFileDialog sDlog = new SaveFileDialog(); //FileDialog生成
            sDlog.Title = IOText.DIALOG_TITLE; //DialogTitle設定
            sDlog.InitialDirectory = IOText.DIRECTORY; //Dialogが始めるFolder設定
            sDlog.DefaultExt = IOText.EXT; //Dialogの各著者を設定
            sDlog.Filter = IOText.ALLFILE; //DialogのFilterを設定
            sDlog.FileName = sub.txtSerial.Text; //Dialogの基本Text設定

            if (sDlog.ShowDialog() != DialogResult.OK) return false; //DialogでOK Button押しない場合


            FileStream newFile = File.Create(sDlog.FileName); //DialogのPathとFileNameでStreamを開く
            StreamWriter sw = new StreamWriter(newFile); //Wirter生成

            sw.WriteLine(sub.txtSerial.Text);
            sw.WriteLine(sub.txtText.Text);
            sw.WriteLine(sub.cmbxDay.SelectedItem);

            String direction = (sub.rbxRight.Checked) ? IOText.RIGHT : IOText.LEFT; //CheckがRightかLeftか判定
            sw.WriteLine(direction);

            String cbxText = "";
            foreach (Control con in sub.gbxAddData.Controls)
            {
                CheckBox cbx = con as CheckBox;

                if (cbx == null) continue; //Castができない場合Continue

                if (!cbx.Checked) continue; // Checkされない場合Continue;

                if (cbxText.Equals("")) cbxText = cbx.Text;
                else cbxText += ", " + cbx.Text;
            }

            sw.WriteLine(cbxText);
            sw.WriteLine((sub.txtNum.Text.Replace(",", "")));
            sw.WriteLine(sub.txtNumEng.Text);
            sw.Close();

            sub.save_state = true;
            sub.modified_state = true;
            sub.Text = sub.txtSerial.Text;

            EnableSaveMenu();
            //mainForm.saveToolStripMenuItem.Enabled = false;
            return true;
        }

        public void EnableSaveMenu()
        {
            IOFileForm sub = getFoucesdForm();
            mainForm.saveToolStripMenuItem.Enabled = CloseState(sub);
        }

        public bool CloseState(IOFileForm sub)
        {
            if (CloseCount())
            {
                return !(sub.save_state & sub.modified_state); //boolのAnd演算
                                                               //Save状態のbool演算をこのメソッド一つで終わるため
            }
            return false;

        }
        public bool CloseCount()
        {
            Console.WriteLine(subList.Count);
            return (subList.Count == 0) ? false : true;
        }

        public void CreateSubForm(IOMainForm main, List<String> list)
        {

            IOFileForm sub = null;
            if(list == null)
            {
                sub = new IOFileForm(this);
            }
            else
            {
                sub = new IOFileForm(this, list);
            }

            sub.MdiParent = main;
            addMdiForm(sub);
            sub.Show();
        }

        /// <summary>
        /// Fileの値、検証するメソッド
        /// </summary>
        public bool ListValidation(List<String> list)
        {

            if (list.Count != 7) //ファイルの値が不足だったら
            {
                MessageBoxEx.Show(mainForm, IOText.ERROR_CONTENTS, IOText.ERROR_MESSAGE, MessageBoxButtons.OK);
                return false;
            }

            List<String> errors = new List<String>(); //ErrorMessageを入れるList

            Regex rgx = new Regex(IOText.RX_SERIAL);
            if (!rgx.IsMatch(list[0])) errors.Add(IOText.ERROR_SERIAL);
            if (list[1].Length > 20) errors.Add(IOText.ERROR_TEXT);
            //rgxの形式と一致しない場合はError代入

            bool vFlag = false;
            for (int i = 1; i <= 10; i++)
            {
                if (list[2].Equals(i + IOText.FULLDOWN)) //Comboxの値と形式が当たったら
                {
                    vFlag = true;
                    break;
                }
            }
            if (!vFlag) errors.Add(IOText.ERROR_FULLDOWN);
            //当たらなかった場合はError代入

            if (!(list[3].Equals(IOText.RIGHT) || list[3].Equals(IOText.LEFT))) errors.Add(IOText.ERROR_RADIO);
            //値がRIGHTとLeftの以外だったらError代入

            String[] check = (list[4].Replace(" ", "")).Split(',');
            foreach (String cTmp in check)
            {
                if (cTmp.IndexOf(IOText.CHECK) == -1)
                {
                    errors.Add(IOText.ERROR_CHECK);
                    break;
                }
            }
            //CheckBoxの形式と合わない場合はError代入

            rgx = new Regex(IOText.RX_NUMBER);
            if (!rgx.IsMatch(list[5])) errors.Add(IOText.ERROR_NUMBER_1);
            else if (list[5].Length > 20) errors.Add(IOText.ERROR_NUMBER_2);

            rgx = new Regex(IOText.RX_ENGNUM);
            if (!rgx.IsMatch(list[6])) errors.Add(IOText.ERROR_ENGNUM_1);
            else if (list[6].Length > 20) errors.Add(IOText.ERROR_ENGNUM_2);



            if (errors.Count > 0) //Errorがある場合
            {
                String contents = "";

                foreach (String eTmp in errors)
                {
                    contents += "-" + eTmp + "\n";
                }

                MessageBoxEx.Show(mainForm, contents, IOText.ERROR_MESSAGE, MessageBoxButtons.OK);
                return false;
            }

            return true;
        }


    }
}
