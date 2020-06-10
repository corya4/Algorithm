using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using mem_hkj.Properties;
using System.Configuration;
using mem_hkj.Model;
using mem_hkj.BL;
using mem_hkj.FormView;

namespace mem_hkj
{
    public class IOUtil
    {
        IOMainForm mainForm;
        List<IOFileForm> subList;
        public Dictionary<IOCsvForm, List<FileFormData>> csv_Data;
        
        

        /// <summary>
        /// 生成者
        /// </summary>
        public IOUtil(IOMainForm main)
        {
            mainForm = main;
            subList = new List<IOFileForm>();
            csv_Data = new Dictionary<IOCsvForm, List<FileFormData>>();
        }

        /// <summary>
        /// 読み込んだMODElのListを集まる
        /// </summary>
        public void SetCsvList(IOCsvForm csvForm, List<FileFormData> list)
        {
            if (csv_Data.ContainsKey(csvForm))
            {
                csv_Data[csvForm] = list;
            }
            else
            {
                csv_Data.Add(csvForm, list);
            }
        }

        /// <summary>
        /// Dictionaryの中で閉めたCSVFormをRemoveする。
        /// </summary>
        /// <param name="csvForm"></param>
        public void removeCsvModel(IOCsvForm csvForm)
        {
            csv_Data.Remove(csvForm);
            if(csv_Data.Count == 0) //CSVFormがなかったら初期値にする。
            {
                mainForm.saveToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// 現在、活性化したCSVFormを持ってくる
        /// </summary>
        public List<FileFormData> getCsvModel(IOCsvForm csvForm)
        {

            return (csv_Data[csvForm] != null) ? csv_Data[csvForm] : new List<FileFormData>() ;
            //csvFormの中にDataがなければ空ListをReturnする。
        }


        /// <summary>
        /// csvFormにあるDataの中でserialと一致するDataをReturnする。
        /// </summary>
        public FileFormData getCsvModel(IOCsvForm csvForm, String serial)
        {
            List<FileFormData> modelList = csv_Data[csvForm];
            for(int i = 0; i < modelList.Count; i++)//ListにあるDataの数だけ反復
            {
                FileFormData model = modelList[i];

                if (model.serial.Equals(serial))//serialが一致したら
                {
                    return model;
                }
            }

            return null;//一致するDataがなかった場合
        }

        /// <summary>
        /// ListにSubForm削除メソッド
        /// </summary>
        public void RemoveForm(IOFileForm sub)
        {
            subList.Remove(sub);
            setStatusSerial();
        }

        /// <summary>
        /// ステータスバーのSubFormの数更新するメソッド
        /// </summary>
        public void setStatusSerial()
        {
            if (subList.Count == 0) //SubFormがなければ表示しない
            { //SubFormがない場合

                mainForm.lblStu.Text = "";
            }
            else
            {//SubFormがある場合
                mainForm.lblStu.Text = IOText.TOTALPAGE + subList.Count;
            }
        }

        /// <summary>
        /// 現在活性化したSubFormを持ってくるメソッド
        /// </summary>
        /// <returns></returns>
        public IOCsvForm getFoucesdForm() //FocuesdされたSubFormをReturn
        {
            List<IOCsvForm> csvList = new List<IOCsvForm>(csv_Data.Keys);
            foreach (IOCsvForm cf in csvList)
            {
                if (cf.ContainsFocus || cf.Focused) //現在選択されているSubFormならこのFormをReturn
                {
                    return cf;
                }
                else
                {
                    //技能なし
                }
            }
            return null;
        }

        /// <summary>
        /// Fileにセーブするメソッド
        /// </summary>
        /// <returns></returns>
        public bool SaveFile()
        {
            IOCsvForm csvForm = getFoucesdForm();
            List<FileFormData> model = getCsvModel(csvForm); //SubFormのデータモデル

            if (model == null) return false;

            SaveFileDialog sDlog = new SaveFileDialog(); //FileDialog生成
            sDlog.Title = IOText.DIALOG_TITLE; //DialogTitle設定
            sDlog.InitialDirectory = ConfigurationSettings.AppSettings["Directory"]; //Dialogが始めるFolder設定
            sDlog.DefaultExt = IOText.EXT; //Dialogの各著者を設定
            sDlog.Filter = ConfigurationSettings.AppSettings["FileExc"]; //DialogのFilterを設定
            csvForm.Text = csvForm.Text.Substring(0, csvForm.Text.IndexOf(IOText.ASTA));
            sDlog.FileName = csvForm.Text; //Dialogの基本Text設定

            if (sDlog.ShowDialog() != DialogResult.OK) return false; //DialogでOK Button押しない場合

            FileStream newFile = File.Create(sDlog.FileName); //DialogのPathとFileNameでStreamを開く
            StreamWriter sw = new StreamWriter(newFile); //Wirter生成

            List<FileFormData> modelTemp = new List<FileFormData>();

            for(int i = 0; i < model.Count; i++)
            {
                FileFormData data = model[i];

                if (data.color != 3) //RemoveしたDataがなかったら新しいCSVFileに書くと、Tempに入れる
                {
                    sw.WriteLine(data.serial + "\t" + data.contents + "\t" + data.pulldown + "\t" + data.direction + "\t" + data.check + "\t" + data.number + "\t" + data.engnum);
                    modelTemp.Add(data);
                }
            }

            sw.Close();
            csvForm.save_state = false; //セーブした後はSavemenuを非活性化する
            csvForm.Text = sDlog.FileName.Substring(sDlog.FileName.LastIndexOf('\\') + 1); //csvFormのTextを変更
            EnableSaveMenu();
            reSetTable(csvForm, modelTemp); //csvFormに新しい値を入れる
            return true;
        }


        /// <summary>
        /// SaveMenuBarを更新するメソッド
        /// </summary>
        public void EnableSaveMenu()
        {
            IOCsvForm csvForm = getFoucesdForm();
            mainForm.saveToolStripMenuItem.Enabled = csvForm.save_state;
        }

        /**/
        public void CreateFileForm(IOCsvForm csvForm, FileFormData model)
        {
            IOFileForm sub = new IOFileForm(csvForm, this, model);
            sub.MdiParent = mainForm;
            sub.Show();
            subList.Add(sub);
        }

        /// <summary>
        /// FormのModelに値を入れるメソッド
        /// </summary>
        [Obsolete]
        public bool SetData(IOCsvForm csvForm, IOFileForm form)
        {
            List<String> indexList = new List<String>();
            indexList.Add(form.txtSerial.Text);
            indexList.Add(form.txtText.Text);
            String nullable = (form.cmbxDay.SelectedItem != null) ? form.cmbxDay.SelectedItem.ToString() : null;
            if (nullable == null) return false;
            indexList.Add(nullable.Replace(",", ""));
            String tDir = (form.rbxRight.Checked) ? IOText.RIGHT : IOText.LEFT;
            indexList.Add(tDir);
            String tCbx = null;
            foreach (Control con in form.gbxAddData.Controls)
            {
                CheckBox cbx = con as CheckBox;
                if (cbx == null) continue; //Castができない場合Continue
                if (!cbx.Checked) continue; // Checkされない場合Continue;
                if (tCbx == null) tCbx = cbx.Text;
                else tCbx += "-" + cbx.Text;
            }
            indexList.Add(tCbx);
            indexList.Add(form.txtNum.Text.Replace(",", ""));
            indexList.Add(form.txtNumEng.Text);

            //Validation検査
            IOValidation vali = ListValidation(indexList);
            if (vali.error)
            {
                return false;
            }

            FileFormData model = form.model; //現在活性化したFileFormのDataModelを持ってくる

            model.serial = indexList[0];
            model.contents = indexList[1];
            model.pulldown = indexList[2];
            model.direction = indexList[3];
            model.check = indexList[4];
            model.number = indexList[5];
            model.engnum = indexList[6];

            SetModelList(csvForm, model); // 新しいDataを入れる

            return true;
        }


        /// <summary>
        /// CsvFormに新しい値を入れるメソッド
        /// </summary>
        private void SetModelList(IOCsvForm csvForm, FileFormData model)
        {
            List<FileFormData> modelList = csv_Data[csvForm];
            for(int i = 0; i < modelList.Count; i++)
            {
                FileFormData mTmp = modelList[i];
                if (model.serial.Equals(mTmp.serial)) //一致するDataがあったら変更する
                {
                    model.color = 2;
                    modelList[i] = model;
                    return;
                }
            }
            model.color = 1;
            modelList.Add(model);//一致しなかったらAddする。
        }


        /// <summary>
        /// Controlの値のValidataを検索するメソッド
        /// </summary>
        [Obsolete]
        public static IOValidation ListValidation(List<String> list)
        {
            IOValidation vali = new IOValidation();
            if (list.Count != 7) //ファイルの値が不足だったら
            {
                vali.error = true;
                return vali;
            }

            List<String> errors = new List<String>(); //ErrorMessageを入れるList

            Regex rgx = new Regex(ConfigurationSettings.AppSettings["ValiSerial"]);
           
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

            String[] check = (list[4].Replace(" ", "")).Split('-');
            foreach (String cTmp in check)
            {
                if (cTmp.IndexOf(IOText.CHECK) == -1)
                {
                    errors.Add(IOText.ERROR_CHECK);
                    break;
                }
            }
            //CheckBoxの形式と合わない場合はError代入

            rgx = new Regex(ConfigurationSettings.AppSettings["ValiNum"]);
            if (!rgx.IsMatch(list[5])) errors.Add(IOText.ERROR_NUMBER_1);
            else if (list[5].Length > 20) errors.Add(IOText.ERROR_NUMBER_2);

            rgx = new Regex(ConfigurationSettings.AppSettings["ValiNumEng"]);
            if (!rgx.IsMatch(list[6])) errors.Add(IOText.ERROR_ENGNUM_1);
            else if (list[6].Length > 20) errors.Add(IOText.ERROR_ENGNUM_2);


            //ErrorsのListにErrorがあったら
            if (errors.Count > 0) //Errorがある場合
            {
                String contents = "";

                foreach (String eTmp in errors)
                {
                    contents += "-" + eTmp + "\n";
                }

                vali.error = true;
                vali.errorString = contents;
                vali.errorList = list;
                return vali;
            }

            return vali;
        }


        /// <summary>
        /// CsvFileを持ってくるメソッド
        /// </summary>
        [Obsolete]
        public List<FileFormData> openCsv(IOCsvForm csvForm)
        {
            OpenFileDialog oDlog = new OpenFileDialog(); //Dialog生成
            oDlog.Title = IOText.DIALOG_TITLE; //DialogTitle設定
            oDlog.InitialDirectory = ConfigurationSettings.AppSettings["Directory"];
            oDlog.Filter = ConfigurationSettings.AppSettings["FileCsv"];
            oDlog.DefaultExt = IOText.CSV;

            if (oDlog.ShowDialog() != DialogResult.OK) return null; //DialogでOKを押さない場合Return
            StreamReader sr = new StreamReader(oDlog.FileName); //Reader生成
            List<FileFormData> indexList = new List<FileFormData>();

            String line = "";

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                String[] rowData = line.Split('\t');
                List<String> modelValues = new List<String>();
                foreach(String var in rowData) modelValues.Add(var);
                IOValidation vali = ListValidation(modelValues);
                if (vali.error) continue;

                FileFormData model = new FileFormData();
                model.serial = modelValues[0];
                model.contents = modelValues[1];
                model.pulldown = modelValues[2];
                model.direction = modelValues[3];
                model.check = modelValues[4];
                model.number = modelValues[5];
                model.engnum = modelValues[6];

                indexList.Add(model);
            }

            sr.Close();
            csvForm.Text = oDlog.FileName.Substring(oDlog.FileName.LastIndexOf('\\')+1);
            Console.WriteLine(indexList.Count);
            return indexList;
        }

        /// <summary>
        /// MainFormのSaveMenuのToggleメソッド
        /// </summary>
        public void setSaveState(bool flag)
        {
            if (flag)
            {
                mainForm.saveToolStripMenuItem.Enabled = true;
            }
            else
            {
                mainForm.saveToolStripMenuItem.Enabled = false;
            }
        }
        

        /// <summary>
        /// csvFormのDataのColorを初期化するメソッド
        /// </summary>
        public void reSetTable(IOCsvForm csvForm, List<FileFormData> modelList)
        {
            foreach(FileFormData data in modelList)
            {
                data.color = 0;
            }

            csv_Data[csvForm] = modelList;
        }
    }
}
