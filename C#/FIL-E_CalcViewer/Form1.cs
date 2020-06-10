using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FIL_E_CalcViewer
{
    public partial class FIL_E_CACLVIEWER : Form
    {
        private String filePath = @"C:\kijung\trend_file\";     //trendFilePAth
        private String fileName;    //trendFileName
        private String[] fileValue;     //trendFileValue

        private int[] selectedValue = Enumerable.Repeat(-1,3).ToArray(); //trendFileの設定値を込む
        static private bool reload = true; //TrendFileを読み直しを判定

        static List<String> errors = new List<string>();

        public FIL_E_CACLVIEWER()
        {
            InitializeComponent();
        }

        private void FIL_E_CalcViewer_Load(object sender, EventArgs e)
        {
            ToggleFileViewer(false); //defualt FileViewer close
            

        }

        private void btnFileView_Click(object sender, EventArgs e)
        {

            // 始め以外は配列の値とselectedIndexの値が違ったらpnlRigthを更新する。
            // 装置設定値が変化したかを判定
            if (selectedValue[0] != -1 && selectedValue[0] != cbxEquipment.SelectedIndex) reload = false;
            if (selectedValue[1] != -1 && selectedValue[1] != cbxUnit.SelectedIndex) reload = false;
            if (selectedValue[2] != -1 && selectedValue[2] != ((rbxHigh.Checked == true) ? 0 : 1)) reload = false;


            ToggleFileViewer(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ToggleFileViewer(false);
        }

        private void ToggleFileViewer(bool visible)
        {

            if (pnlRight.Visible == visible && reload) //Frame状態についてRETURN
                return;                                //reloadはpnlRight画面更新のためある

            if (!visible) //FileViewr Open status
            {
                this.Width -= pnlRight.Width;

                //初期化
                txbFilesValue.Text = "";
                fileValue = null;


                pnlRight.Visible = false;
                selectedValue = Enumerable.Repeat(-1, 3).ToArray();

                //pnlRight画面を閉める。共に初期化

            }
            else //FileViewer Close status
            {

                if (cbxEquipment.Text == "")　//装置をえらばない場合
                {
                    errors.Add("装置名");
                    //MessageBox.Show("装置を選んでください。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }

                if (cbxUnit.Text == "")　　//Unitをえらばない場合
                {
                    errors.Add("ユニット");
                    //MessageBox.Show("Unitを選んでください。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }

                if (getError())
                {
                    return;
                }

                //HighがチャックだったらHighを、LowだったらLowを。
                lblFileName.Text = cbxEquipment.Text + "-" + cbxUnit.Text + "-" +
                    ((rbxHigh.Checked == true) ? rbxHigh.Text : rbxLow.Text) + ".dat";

                //このArrでFileViewerを読み直しかないかを判定
                selectedValue[0] = cbxEquipment.SelectedIndex;
                selectedValue[1] = cbxUnit.SelectedIndex;
                selectedValue[2] = (rbxHigh.Checked == true) ? 0 : 1;


                //FileName生成
                fileName = lblFileName.Text;
                
                String reader = "";

                try
                {
                    setFileValue();
                    foreach (String w in fileValue) reader += w + '\n';
                }
                catch //Fileがなかった場合
                {
                    txbFilesValue.Text = ""; //value初期化
                    MessageBox.Show("一致するファイルがありません。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }


                txbFilesValue.Text = reader;

                if(pnlRight.Visible == false) this.Width += pnlRight.Width;
                //pnlRight画面を更新する場合Frameのsizeがつづけて伸びる現象を止める。

                pnlRight.Visible = true;
                reload = true; //初期化


            }
            
        }

        private void setFileValue()
        {
            fileValue = File.ReadAllLines(filePath + fileName);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (cbxEquipment.Text == "") //装置をえらばない場合
            {
                errors.Add("装置名");
                //MessageBox.Show("装置を選んでください。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            if (cbxUnit.Text == "")  //Unitをえらばない場合
            {
                errors.Add("処理ユニット");
                //MessageBox.Show("Unitを選んでください。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtInitial.TextLength == 0) //Initial_THKの値がない場合
            {
                errors.Add("IntialTHK");
               // MessageBox.Show("InitialTHKを入力してください。","ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            if(txtTarget.TextLength == 0)　//Targetの値がない場合
            {
                errors.Add("狙い膜厚");
                //MessageBox.Show("狙い膜厚を入力してください。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }

            if (getError())
            {
                return;
            }
              


            //演算値読み込む
            double initial_thk = Convert.ToDouble(txtInitial.Text);
            double target = Convert.ToDouble(txtTarget.Text);
            double occupancy = (txtDiff.Text == "") ? 0.0 : Convert.ToDouble(txtDiff.Text);

            double rate = 0.0;//  (txtRate.Text == "") ? 1.0 : Convert.ToDouble(txtRate.Text);

            if(txtRate.Text != "")
            {
               rate =  Convert.ToDouble(txtRate.Text);
            }
            else
            {
                btnFileView_Click(sender, e);
                btnRate_Click(sender, e);
                rate = Convert.ToDouble(txtRate.Text);
            }

            double calc = (initial_thk - target - occupancy) / rate;

            txtProcessing.Text = calc.ToString("F1"); // Processingに入力。

        }

        
        private bool getError()
        {
            if (errors.Count != 0) // Errorがある場合
            {
                String error = "";

                for (int i = 0; i < errors.Count; i++)
                {
                    error += (i != errors.Count - 1) ? errors[i] + ", " : errors[i];
                }
                MessageBox.Show(error + "を選んでください。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errors.Clear(); // 初期化
                return true;
            }

            return false;
        }
       
 
        private void btnRate_Click(object sender, EventArgs e) // fileの値演算
        {
            if(pnlRight.Visible == false) //設定ができない場合
            {
                MessageBox.Show("ファイルを読んできてください。","ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(fileValue == null || fileValue.Length == 0) //値がない場合
            {
                MessageBox.Show("ファイルに値がありません。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double rate = 0;
            double calc_rate = 0;
            try
            {
                setFileValue();
            }
            catch
            {
                MessageBox.Show("ファイルViEWERバトンを押してください。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (fileValue.Length != txbFilesValue.Text.Split('\n').Length)
            {
                fileValue = txbFilesValue.Text.Split('\n');
            }


            for(int i = 0; i < fileValue.Length; i++)
            {
                if(fileValue[i].Equals("")) continue;

                try // TrendFile行にRATE値がない場合
                {
                    rate = Double.Parse((fileValue[i].Split(',')[4]));
                }
                catch
                {
                    MessageBox.Show("トレンドファイルの値に問題があります。", "ALARM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                if(i == 0) { //初LOOPは一般代力
                    calc_rate = rate;
                    continue;
                }

                //演算式　- calc_rateの結果をrateより適用する。
                calc_rate = (calc_rate * 0.8) + (rate * 0.2);

            }

          

            txtRate.Text = calc_rate.ToString("F7"); //小数点7席まで
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            var rs = MessageBox.Show("保存しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (rs != DialogResult.Yes) return; //YESかなければRETURN

            StreamWriter sw = null;
            
            //Fileを修正する。
            try
            {
                sw = new StreamWriter(filePath + fileName);
                String word = txbFilesValue.Text;
                for (int i = 0; i < word.Length; i++)
                {
                   
                    if (word[i] == '\n')
                    {
                        sw.WriteLine("");
                    }
                    else
                    {
                        sw.Write(word[i]);
                    }
                }
            }
            catch //えらーがなかった場合
            {
                MessageBox.Show("保存ができませんでした。", "IOエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sw.Close();　//Stream終了
            }

        }


        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(".") || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
               
                e.Handled = true;
                return;
            }

            TextBox tb = (TextBox)sender;

            if (tb.Text.Contains(".") && e.KeyChar == Convert.ToChar("."))
            {
                e.Handled = true;
                return;
            }
         
            //foreach (String a in initial_text) Console.Write(a);
            //Console.WriteLine();
            //switch (name)
            //{
            //    case "txtInitial":
            //        if (initial_text.Count != 0 && e.KeyChar == Convert.ToChar(Keys.Back))
            //        {
            //            initial_text.RemoveAt(initial_text.Count - 1);
            //            return;
            //        }
            //        if (initial_text.Contains(".") && e.KeyChar == Convert.ToChar("."))
            //        {
            //            e.Handled = true;
            //            return;
            //        }
            //        initial_text.Add(e.KeyChar + "");

            //        break;
            //    case "txtTarget":
            //        if (target_text.Count != 0 && e.KeyChar == Convert.ToChar(Keys.Back))
            //        {
            //            target_text.RemoveAt(target_text.Count - 1);
            //            return;
            //        }
            //        if (target_text.Contains(".") && e.KeyChar == Convert.ToChar("."))
            //        {
            //            e.Handled = true;
            //            return;
            //        }
            //        target_text.Add(e.KeyChar + "");

            //        break;
            //    case "txtDiff":
            //        if (diff_text.Count != 0 && e.KeyChar == Convert.ToChar(Keys.Back))
            //        { 
            //            diff_text.RemoveAt(diff_text.Count - 1);
            //            return;
            //        }
            //        if (diff_text.Contains(".") && e.KeyChar == Convert.ToChar("."))
            //        {
            //            e.Handled = true;
            //            return;
            //        }
            //        diff_text.Add(e.KeyChar + "");

            //        break;
            //    case "txtRate":
            //        if (rate_text.Count != 0 && e.KeyChar == Convert.ToChar(Keys.Back))
            //        {
            //            rate_text.RemoveAt(rate_text.Count - 1);
            //            return;
            //        }
            //        if (rate_text.Contains(".") && e.KeyChar == Convert.ToChar("."))
            //        {
            //            e.Handled = true;
            //            return;
            //        }
            //        rate_text.Add(e.KeyChar + "");

            //        break;
            //}

        }
    }
}
