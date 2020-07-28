using MainFrame.Properties;
using mem_hkj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame.Frame
{
    public partial class SelectForm : Form
    {
        MainForm main;
        int type;


        public SelectForm(MainForm main, String ext, List<DataGridViewRow> list)
        {
            InitializeComponent();

            this.Location = new Point((int)(main.Location.X * 1.5), (int)(main.Location.Y * 1.5)); //MainFormの中央に設定

            this.main = main;
            lbl_ext.Text = ext;
            type = (ext.Equals("FJMファイル")) ? 0 : 1;

            int x = 10;
            int y = 55;
            int tag = 0;

            foreach(DataGridViewRow row in list)
            {
                RadioButton r = new RadioButton();
                
                pnl_radio.Controls.Add(r);

                r.Text = row.Cells[0].Value.ToString() + "    " + row.Cells[1].Value.ToString();

                r.Width = pnl_radio.Width - 10;
                r.Location = new Point(x, y+=25);
                r.Tag = tag++ + "";

                if(pnl_radio.Height < y+10) //PanelのHeightを超えた時増える
                {
                    this.Height += 25;
                }

            }

        }


        /// <summary>
        /// OKボタンを押した時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_select_Click(object sender, EventArgs e)
        {
            
            foreach (Control con in pnl_radio.Controls)
            {
                RadioButton r = con as RadioButton;
                if (r != null)
                {
                  
                    if (r.Checked)
                    {

                        if (type == 0) main.select_fjm = int.Parse(r.Tag.ToString());
                        else if (type == 1) main.select_fjs = int.Parse(r.Tag.ToString());

                        this.Close();
                        return;
                    }

                }
            }

            MessageBoxEx.Show(this, Resources.NEC, Resources.SELECTERROR, MessageBoxButtons.OK);

        }


        /// <summary>
        /// 選択したIndexをMainFormに伝送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (type == 0) main.select_fjm = -1;
            else if (type == 1) main.select_fjs = -1;
            this.Close();
            return;
        }

    }
}
