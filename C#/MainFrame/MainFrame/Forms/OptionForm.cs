using MainFrame.Sources;
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
    public partial class ConfirmForm : Form
    {

        HostData hostData;

        private void ConfirmForm_Load(object sender, EventArgs e) {}

        /// <summary>
        /// 生成する時、値を入力
        /// </summary>
        /// <param name="data"></param>
        public ConfirmForm(HostData data)
        {
            InitializeComponent();
            
            hostData = data;

            txt_id.Text = hostData.ID;
            txt_pw.Text = hostData.PW;
            txt_ip.Text = hostData.IP;
            txt_host.Text = hostData.UploadPath;
            txt_localPath.Text = hostData.LocalPath;
            txt_port.Text = hostData.PortNumber;

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
    }
}
