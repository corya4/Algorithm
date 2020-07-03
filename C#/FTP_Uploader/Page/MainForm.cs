using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_Uploader
{
    public partial class MainForm : Form
    {

        String ini_path = "c:\\";

        /*
         * 現在Pathのフォルダとファイルを集まる //ドラグする時利用
         */
        List<DirectoryInfo> dir_path = new List<DirectoryInfo>();
        List<FileInfo> file_path = new List<FileInfo>();


        List<FileInfo> t_files = new List<FileInfo>(); //伝送用ファイルたち

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(ini_path);
            setLocalTable(info);
            
        }

        private void setLocalTable(DirectoryInfo info)
        {
            LocalTable.Rows.Clear();
            foreach(DirectoryInfo d_tmp in info.GetDirectories())
            {
                LocalTable.Rows.Add(d_tmp.Name, d_tmp.CreationTime.ToString(), "<Dir>");
            }

            foreach (FileInfo f_tmp in info.GetFiles())
            {
                long size = f_tmp.Length;
                String[] bytes = { "bytes", "KB", "MB", "GB" };
                int index = 0;
                while(size > 1024)
                {
                    size = size/1024;
                    index++;
                }

                LocalTable.Rows.Add(f_tmp.Name, f_tmp.CreationTime.ToString(), size+bytes[index]); 
            }

            UpdatePath();
        }

        private void UpdatePath()
        {
            if(LocalPath.Items.Count < 5)
            {
                LocalPath.Items.Add(ini_path);
                LocalPath.SelectedIndex = LocalPath.Items.Count - 1;
            }
            else
            {
                LocalPath.Items.RemoveAt(0);
            }
        }


        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConnectForm().Show();
        }

        private void hostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddHost().Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ini_path = LocalPath.Items[LocalPath.Items.Count - 2].ToString();
            setLocalTable(new DirectoryInfo(ini_path));
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog o_Dlog = new FolderBrowserDialog();

            if (o_Dlog.ShowDialog() != DialogResult.OK) return;

            ini_path = o_Dlog.SelectedPath + "\\";
            setLocalTable(new DirectoryInfo(ini_path));
        }

        private void LocalTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String m_path = LocalTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(m_path);
            if (Directory.Exists(ini_path + m_path))
            {
                ini_path += m_path + "\\";
                setLocalTable(new DirectoryInfo(ini_path));
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
