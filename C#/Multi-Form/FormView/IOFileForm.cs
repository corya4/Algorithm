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
using mem_hkj.Properties;
using System.Configuration;
using mem_hkj.Model;
using mem_hkj.FormView;

namespace mem_hkj
{
    public partial class IOFileForm : Form
    {

        IOUtil prm_util;
        public FileFormData model;
        IOCsvForm csvForm;
        public int state_color = 0;
        public bool save_state;
        public bool modified_state;

        //NewFormするときの生成者
        public IOFileForm(IOCsvForm csvForm, IOUtil util)
        {
            InitializeComponent();
            prm_util = util;
            this.csvForm = csvForm;
            model = new FileFormData();
            String pageNumber = getPageNumber();
            this.Text = pageNumber + IOText.TAIL_NEW;
            txtSerial.Text = pageNumber;

            save_state = false;
            modified_state = true;

        }

        public IOFileForm(IOCsvForm csvForm, IOUtil util, FileFormData model)
        {
            InitializeComponent();
            prm_util = util;
            this.model = model;
            this.csvForm = csvForm;
            this.Text = model.serial; //FormText代入
            this.txtSerial.Text = model.serial; //txtSerial代入
            this.txtText.Text = model.contents; //txtText代入
            String day = model.pulldown; //cbx代入
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

            if (!IOText.RIGHT.Equals(model.direction)) //基本値がRightだからRightがなければLeftをCheck
            {
                this.rbxLeft.Checked = true;
            }

            String checkText = model.check;
            foreach (Control con in this.gbxAddData.Controls)
            {
                CheckBox cbx = con as CheckBox; //FormにあるControlerを CheckBoxにCast
                if (cbx == null) continue; //Castができない場合はContinue;
                if (checkText.IndexOf(cbx.Text) != -1) cbx.Checked = true; //文字列にCheckBoxTextがある場合はCheck

            }


            this.txtNum.Text = model.number+""; //txtNumに代入
            setComma(txtNum);
            this.txtNumEng.Text = model.engnum; //txtEngNumに代入
            
        }

        //OpenFileするときの生成者
       
        /// <summary>
        /// Event - SubFormがCloseされる前にSaveするかないか判定するメソッド
        /// </summary>
        private void SubForm_FormClosing(object sender, FormClosingEventArgs e) //SubFormでCloseButtonを押したとき
        {
            prm_util.RemoveForm(this);
        }

        /// <summary>
        /// Evnet - TextBoxに値を入力する時、Validationするメソッド
        /// </summary>
        [Obsolete]
        private void subFormKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            if (txt.Text.Length > 20 && e.KeyChar != Convert.ToInt32(Keys.Back)) //TextBoxの内容が20字が超えたらReturn
            {
                e.Handled = true;
                return;
            }

            Regex rgx;
            if (txt.Name.Equals("txtNum")) //Event Controlが NUMENGの場合
            {
                rgx = new Regex(ConfigurationSettings.AppSettings["ValiNum"]);
                //数字と英語だけ入力する
                if (!rgx.IsMatch(Convert.ToString(e.KeyChar)) && e.KeyChar != Convert.ToInt32(Keys.Back)) 
                {
                    e.Handled = true;
                }

            }
            else if (txt.Name.Equals("txtNumEng")) //Event Controlが Numの場合
            {
                rgx = new Regex(ConfigurationSettings.AppSettings["ValiNumEng"]);
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

        }

        private void numLenghChanged(object sender, EventArgs e)
        {
            setComma((TextBox)sender); //txtNumの内容が変化したとき、発生するEvent
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
        /// ModelをReturnする。
        /// </summary>
        [Obsolete]
        public FileFormData getFormData()
        {
            return model;
        }


        /// <summary>
        /// 適用Buttonを押した時、Dataが入れられたらFileFormのTextを変更する。
        /// </summary>
        private void btn_inset_Click(object sender, EventArgs e)
        {
            if (prm_util.SetData(csvForm, this))
            {
                csvForm.changeState(); //Textの＊を消す。
                this.Close();
            }
        }

        /// <summary>
        /// FileFormを閉める。
        /// </summary>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
