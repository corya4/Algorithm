using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace mem_hkj
{
    public partial class IOFileForm : Form
    {

        IOUtil prm_util;
        public bool save_state;
        public bool modified_state;

        //NewFormするときの生成者
        public IOFileForm(IOUtil util)
        {
            InitializeComponent();
            prm_util = util;
            String pageNumber = getPageNumber();
            this.Text = pageNumber + IOText.TAIL_NEW;
            txtSerial.Text = pageNumber;

            save_state = false;
            modified_state = true;

        }

        //OpenFileするときの生成者
        public IOFileForm(IOUtil util, List<String> indexList)
        {
            InitializeComponent();
            prm_util = util;
            //Openしたとき(修正前)にはSaveができないことにするため
            save_state = true;
            modified_state = true;

            this.Text = indexList[0]; //FormText代入
            this.txtSerial.Text = indexList[0]; //txtSerial代入
            this.txtText.Text = indexList[1]; //txtText代入
            
            String day = indexList[2]; //cbx代入
            for (int i = 0; i < this.cmbxDay.Items.Count; i++) //FormにあるCheckBoxの値を全部読み込む
            {
                if (day.Equals(cmbxDay.Items[i])) //Fileで読み込んだ値がCheckBoxの値と当たったら
                {
                    cmbxDay.SelectedItem = day; //その項目をSelect
                    break;
                }
                else
                {
                    //技能なし
                }
            }

            if (!IOText.RIGHT.Equals(indexList[3])) //基本値がRightだからRightがなければLeftをCheck
            {
                this.rbxLeft.Checked = true;
            }

            String checkText = indexList[4];
            foreach (Control con in this.gbxAddData.Controls)
            {
                CheckBox cbx = con as CheckBox; //FormにあるControlerを CheckBoxにCast
                if (cbx == null) continue; //Castができない場合はContinue;
                if (checkText.IndexOf(cbx.Text) != -1) cbx.Checked = true; //文字列にCheckBoxTextがある場合はCheck
                
            }


            this.txtNum.Text = indexList[5]; //txtNumに代入
            setComma(txtNum);
            this.txtNumEng.Text = indexList[6]; //txtEngNumに代入

            setChangedEvent(); //FormにEventを追加
            util.EnableSaveMenu();
            
        }

        /// <summary>
        /// Event - SubFormがCloseされる前にSaveするかないか判定するメソッド
        /// </summary>
        private void SubForm_FormClosing(object sender, FormClosingEventArgs e) //SubFormでCloseButtonを押したとき
        {
            if (prm_util.CloseState(this)) //Saveができる状態の場合
            {
                String title = "";
                String contents = "";
                if(!this.save_state)　//FormがNewFileの場合
                {
                    title = IOText.SAVEBOX_TITLE;
                    contents = IOText.SAVEBOX_CONTENTS;
                }
                else　//Formが修正した場合
                {
                    title = IOText.MODIFIEDBOX_TITLE;
                    contents = IOText.MODIFIEDBOX_CONTENTS;
                }

                //Message出力
                DialogResult dr = MessageBoxEx.Show(this, this.Text + contents, title, MessageBoxButtons.YesNoCancel);

                if(dr == DialogResult.Yes) //Yesを押した場合
                {
                    if (!prm_util.SaveFile()) //DialogでCancelをした場合
                    {
                        e.Cancel = true;
                    }
                       
                }else if(dr == DialogResult.Cancel) //Cancelした場合
                {
                    e.Cancel = true;
                }
                else //その以外
                {
                    //技能なし
                }
            }

            prm_util.RemoveForm(this);
            prm_util.EnableSaveMenu();
            
        }

        /// <summary>
        /// Evnet - TextBoxに値を入力する時、Validationするメソッド
        /// </summary>
        private void subFormKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Length > 20 && e.KeyChar != Convert.ToInt32(Keys.Back)) //TextBoxの内容が20字が超えたらReturn
            {
                e.Handled = true;
                return;
            }

            Regex rgx;
            if (txt.Name.Equals(IOText.TEXT_NUMENG)) //Event Controlが NUMENGの場合
            {
                rgx = new Regex(IOText.RX_ENGNUM);
                //数字と英語だけ入力する
                if (!rgx.IsMatch(Convert.ToString(e.KeyChar)) && e.KeyChar != Convert.ToInt32(Keys.Back)) 
                {
                    e.Handled = true;
                }

            }
            else if (txt.Name.Equals(IOText.TEXT_NUMBER)) //Event Controlが Numの場合
            {
                rgx = new Regex(IOText.RX_NUMBER);
                //数字だけ入力する
                if (!rgx.IsMatch(Convert.ToString(e.KeyChar)) && e.KeyChar != Convert.ToInt32(Keys.Back))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }

            }
            else
            {
                //技能なし
            }

           if (!prm_util.CloseState(this)) setModifiedState(); //Saveができる状態か確認

        }

        private void numLenghChanged(object sender, EventArgs e)
        {
            setComma((TextBox)sender); //txtNumの内容が変化したとき、発生するEvent
        }
       
        /// <summary>
        /// Event - SubFormが活性化する時、起きるEvent
        /// </summary>
        private void SubForm_Activated(object sender, EventArgs e)
        {
            prm_util.EnableSaveMenu();
        }

        /// <summary>
        /// Event - ComboBoxとCheckBoxの値が変更する時、起きるEvnet
        /// </summary>
        private void changeValueEvent(object sender, EventArgs e)
        {
            if (!prm_util.CloseState(this)) setModifiedState();
        }

        /// <summary>
        /// Serial番号自動生成メソッド
        /// </summary>
        private String getPageNumber()
        {
            DateTime date = DateTime.Now;
            return String.Format("P" + "{0:yyyyMMddHHmmss}", date);
            //現在時間をこの形式で変更して出力
        }

        /// <summary>
        /// 修正中に変わるメソッド
        /// </summary>
        private void setModifiedState()
        {
            if (this.save_state == false) return;
            this.modified_state = false;
            this.Text += IOText.WORKING;
            prm_util.EnableSaveMenu();
            

        }

        /// <summary>
        /// TxtNumの千単位ごとにCommaをつける。
        /// </summary>
        private void setComma(TextBox txt)
        {
            String text = txt.Text.Replace(",", ""); //TextのCommaを消える
            String sTmp = "";
            int cc = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (cc % 3 == 0 && cc >= 3) sTmp = "," + sTmp; //Textの3単位ごとにCommaをつける

                sTmp = Convert.ToString(text[i]) + sTmp;
                cc++; //文字単位を分かるため
            }
            txtNum.Text = sTmp;
            txtNum.Select(sTmp.Length, 0); //TextBoxのFocusを後ろに送る
        }

        /// <summary>
        /// OpneFileした後、SubFormにイベントを追加する。
        /// </summary>
        private void setChangedEvent()
        {
            this.cmbxDay.SelectedIndexChanged += new System.EventHandler(this.changeValueEvent);
            this.rbxRight.CheckedChanged += new System.EventHandler(this.changeValueEvent);
            this.rbxLeft.CheckedChanged += new System.EventHandler(this.changeValueEvent);
            this.cbx1.CheckedChanged += new System.EventHandler(this.changeValueEvent);
            this.cbx2.CheckedChanged += new System.EventHandler(this.changeValueEvent);
            this.cbx3.CheckedChanged += new System.EventHandler(this.changeValueEvent);
        }

      
    }
}
