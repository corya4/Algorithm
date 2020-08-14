using MainFrame.Forms;
using MainFrame.Sources;
using mem_hkj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame.Frame
{
    public partial class ConfirmForm : Form
    {
        MainForm main;
        HostData hostData;

        private void ConfirmForm_Load(object sender, EventArgs e) {}

        /// <summary>
        /// 生成する時、値を入力
        /// </summary>
        /// <param name="data"></param>
        public ConfirmForm(MainForm main, HostData data)
        {
            InitializeComponent();
            
            hostData = data;
            this.main = main;

            txt_id.Text = hostData.ID;
            txt_pw.Text = hostData.PW;
            txt_ip.Text = hostData.IP;
            txt_host.Text = hostData.UploadPath;
            txt_localPath.Text = hostData.LocalPath;
            txt_port.Text = hostData.PortNumber;
            txt_LogPath.Text = hostData.LogFilePath;
            cbx_logWrite.Checked = hostData.LogWrited.Equals("true") ? true : false;

            main.status = -1;

        }

        /// <summary>
        /// OKボタンを押した時、HOST値変更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OK_button_Click(object sender, EventArgs e)
        {
            hostData.ID = txt_id.Text;
            hostData.PW = txt_pw.Text;
            hostData.IP = txt_ip.Text;

            String tmpDir = txt_host.Text;

            if (tmpDir.StartsWith("C:") || tmpDir.StartsWith("c:"))
            {
                tmpDir = txt_host.Text.Substring(3);
            }

            hostData.UploadPath = tmpDir;
            hostData.LocalPath = txt_localPath.Text;
            hostData.PortNumber = txt_port.Text;
            hostData.LogFilePath = txt_LogPath.Text;
            hostData.LogWrited = cbx_logWrite.Checked ? "true" : "false";

            main.status = 0;

            if (cbx_logWrite.Checked)
            {
                if (!File.Exists(txt_LogPath.Text))
                {
                    if (MessageBoxEx.Show(main, "ログファイルが見つかりません。ログ作成をしなくて続けますか？", "パスエラー", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                        != DialogResult.OK)
                    {
                        return;
                    }

                    cbx_logWrite.Checked = false;
                    hostData.LogWrited = "false";

                }
            }

            this.Close();
        }


        /// <summary>
        /// CANCELボタンを押し時、ただ終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CANCEL_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// ローカルパス変更のダイアロゴOPEN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FolderDialog_OPen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlog = new FolderBrowserDialog();
            if (folderDlog.ShowDialog() != DialogResult.OK) return;

            txt_localPath.Text = folderDlog.SelectedPath;
        }

        private void btn_LogDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDlog = new OpenFileDialog();

            if (oDlog.ShowDialog() != DialogResult.OK) return;

            txt_LogPath.Text = oDlog.FileName;
            
        }


        private void cbx_logWrite_CheckStateChanged(object sender, EventArgs e)
        {
            txt_LogPath.Enabled = cbx_logWrite.Checked;
            btn_LogDialog.Enabled = cbx_logWrite.Checked;
        }
    }
}
