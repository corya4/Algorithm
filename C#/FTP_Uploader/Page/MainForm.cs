using FTP_Uploader_2.Page;
using FTP_Uploader_2.Properties;
using mem_hkj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_Uploader_2
{

    public partial class MainForm : Form
    {

        String mainDir;
        List<String> files = new List<String>();
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ini Path Read
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = File.OpenText(Application.StartupPath + "\\init\\ini.txt");
                String startPath = sr.ReadLine();
                String currentPath = sr.ReadLine();
                sr.Dispose();

                pathBox.Items.Add(startPath);
                currented_path.Add(currentPath);
                pathBox.SelectedIndex = 0;
            }catch(Exception ex)
            {
                Console.WriteLine("ini.txt Read error");
            }

        }


        /// <summary>
        /// TreeView SetUp
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        private TreeNode CreateDirectoryNode(DirectoryInfo info)
        {
            TreeNode dirNode = new TreeNode(info.Name);

            foreach (DirectoryInfo di in info.GetDirectories())
            {
                dirNode.Nodes.Add(CreateDirectoryNode(di));
            }
            foreach (FileInfo fi in info.GetFiles())
            {
                dirNode.Nodes.Add(new TreeNode(fi.Name));
            }

            return dirNode;
        }


        /// <summary>
        /// AddButton Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MoveTable();
            files.Clear(); // List Clear

        }

        /// <summary>
        /// DataGidView classification
        /// </summary>
        private void MoveTable()
        {

            Dictionary<int, FileInfo> etcClassial = new Dictionary<int, FileInfo>();
            int index = 0;
            //ETC File Check

            foreach (String path in files)
            {
                FileInfo info = new FileInfo(path);
                String ext = Path.GetExtension(info.FullName);

                if (ext.Equals(".fjs"))
                {
                    if (dgv_fjs.Rows.Count != 0)
                    {
                        if (MessageBoxEx.Show(this, Resources.EqualFile + '\n' + dgv_fjs.Rows[0].Cells[0].Value + Resources.UpdateFile, Resources.OverLap, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            dgv_fjs.Rows.RemoveAt(0);
                        }
                        else
                        {
                            continue;
                        }

                    }

                    dgv_fjs.Rows.Add(SetRow(info));
                }
                else if (ext.Equals(".fjm"))
                {
                    if (dgv_fjm.Rows.Count != 0)
                    {
                        if (MessageBoxEx.Show(this, Resources.EqualFile + '\n' + dgv_fjm.Rows[0].Cells[0].Value + Resources.UpdateFile, Resources.OverLap, MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            dgv_fjm.Rows.RemoveAt(0);
                        }
                        else
                        {
                            continue;
                        }

                    }


                    dgv_fjm.Rows.Add(SetRow(info));
                }
                else
                {
                    if (checkedETC(info))
                    {
                        dgv_etc.Rows.Add(SetRow(info));
                    }
                    else
                    {
                        etcClassial.Add(index, info);
                    }

                    index++;
                    
                }

            }

            if(etcClassial.Count != 0)
            {
                if (MessageBoxEx.Show(this, Resources.EqualFileETC_head + etcClassial.Count + Resources.EqualFileETC_tail, Resources.OverLap, MessageBoxButtons.OKCancel) != DialogResult.OK) return;

                UpdateETC(etcClassial);
            }

        }

        private bool checkedETC(FileInfo info)
        {
            String path = info.FullName;

            foreach(DataGridViewRow row in dgv_etc.Rows)
            {
                //Console.WriteLine(row.Cells[0].Value + "  " + Path.GetFileName(path) + "              " + row.Cells[4].Value + "  " + Path.GetDirectoryName(path));
                //Console.WriteLine(row.Cells[0].Value.ToString().Equals(Path.GetFileName(path)) && row.Cells[4].Value.ToString().Equals(Path.GetDirectoryName(path)));

                if (row.Cells[0].Value.ToString().Equals(Path.GetFileNameWithoutExtension(path)) && row.Cells[4].Value.ToString().Equals(Path.GetDirectoryName(path)))
                {
                    return false;
                }
            }

            return true;
        }


        private void UpdateETC(Dictionary<int, FileInfo> dic)
        {
            foreach (KeyValuePair<int, FileInfo> kvp in dic)
            {
                dgv_etc.Rows[kvp.Key].SetValues(SetRow(kvp.Value));
            }
        }

        /// <summary>
        /// DataGridView Set Row
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        private Object[] SetRow(FileInfo info)
        {

            Object[] row = new Object[5];

            row[0] = Path.GetFileNameWithoutExtension(info.Name);
            row[1] = info.LastWriteTime;
            row[2] = Path.GetExtension(info.Name);
            row[3] = GetFileBytes(info.Length);
            row[4] = Path.GetDirectoryName(info.FullName);

            return row;
        }


        /// <summary>
        /// Get File Size
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        private String GetFileBytes(long size)
        {
            long tmp_size = size;
            String bit = "byte";

            if (tmp_size > 1024)
            {
                tmp_size = tmp_size / 1024;
                bit = "KB";
            }

            if (tmp_size > 1024)
            {
                tmp_size = tmp_size / 1024;
                bit = "MB";
            }

            if (tmp_size > 1024)
            {
                tmp_size = tmp_size / 1024;
                bit = "GB";
            }

            if (tmp_size > 1024)
            {
                tmp_size = tmp_size / 1024;
                bit = "TB";
            }

            return tmp_size + bit;
        }

        /**
        /// <summary>
        /// Node DFS <- get File
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="files"></param>
        private void CheckNode(TreeNodeCollection nodes, List<FileInfo> files)
        {

            foreach (TreeNode node in nodes)
            {
                String fullPath = mainDir + FullPath(node);

                if (!File.Exists(fullPath))
                {
                    CheckNode(node.Nodes, files);
                    continue;
                }

                if (!node.Checked) continue;

                files.Add(new FileInfo(fullPath));
            }
        }
        **/

        /// <summary>
        /// Node <- Get fullName
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private String FullPath(TreeNode node)
        {
            if (node.Parent == null)
            {
                return node.Text;
            }

            return FullPath(node.Parent) + "\\" + node.Text;
        }

        /// <summary>
        /// ChildNode Toggle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool flag = true;
        private void TreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (flag)
            {
                flag = false;
                ChildNode_Toggle(e.Node, e.Node.Checked);
                AddFiles();
                FJS.Clear();
                FJM.Clear();
                flag = true;
            }
        }


        /// <summary>
        /// childNode all Checking
        /// List Add or List Remove
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="flag"></param>
        Dictionary<String, TreeNode> FJS = new Dictionary<String, TreeNode>(); // fjsファイルメモリー
        Dictionary<String, TreeNode> FJM = new Dictionary<String, TreeNode>(); // fjmファイルメモリー
        private void ChildNode_Toggle(TreeNode nodes, bool flag)
        {

            foreach (TreeNode node in nodes.Nodes)
            {
                ChildNode_Toggle(node, flag);
            }

            nodes.Checked = flag;

            String filePath = pathBox.SelectedItem.ToString() + FullPath(nodes);
            if (!File.Exists(filePath)) return;

            if (flag)
            {
                if (Path.GetExtension(filePath).Equals(Resources.FJS))
                {
                    FJS.Add(filePath, nodes);
                }
                else if(Path.GetExtension(filePath).Equals(Resources.FJM))
                {
                    FJM.Add(filePath, nodes);
                }
                else
                {
                    files.Add(filePath);
                }

            }
            else
            {
                files.Remove(filePath);
            }

        }

        public int selectIndex = -1;
        private void AddFiles()
        {
            if(FJS.Count <= 1)
            {
                foreach(KeyValuePair<String, TreeNode> kvp in FJS)
                {
                    files.Add(kvp.Key);
                }
            }
            else
            {
                SelectFileForm child = new SelectFileForm(this, FJS);
                child.ShowDialog();

                int index = 0;

                foreach (KeyValuePair<String, TreeNode> kvp in FJS)
                {

                    if(index == selectIndex)
                    {
                        files.Add(kvp.Key);
                    }
                    else
                    {
                        kvp.Value.Checked = false;
                    }

                    index++;
                }

            }

            if (FJM.Count <= 1)
            {
                foreach (KeyValuePair<String, TreeNode> kvp in FJM)
                {
                    files.Add(kvp.Key);
                }
            }
            else
            {
                SelectFileForm child = new SelectFileForm(this, FJM);
                child.ShowDialog();
                int index = 0;
                foreach (KeyValuePair<String, TreeNode> kvp in FJM)
                {

                    if (index == selectIndex)
                    {
                        files.Add(kvp.Key);
                    }
                    else
                    {
                        kvp.Value.Checked = false;
                    }

                    index++;
                }

            }


            selectIndex = -1; //初期化
        }

        /// <summary>
        /// GridView selected Remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_fjs.Rows)
            {
                if (row.Selected) dgv_fjs.Rows.Clear();
            }

            foreach (DataGridViewRow row in dgv_fjm.Rows)
            {
                if (row.Selected) dgv_fjm.Rows.Clear();
            }

            List<bool> selected = new List<bool>();
            foreach (DataGridViewRow row in dgv_etc.Rows)
            {
                if (row.Selected)
                {
                    selected.Add(true);
                }
                else
                {
                    selected.Add(false);
                }
            }

            int index = 0;
            while (true)
            {

                if (index >= selected.Count) break;

                if (selected[index])
                {
                    dgv_etc.Rows.RemoveAt(index);
                    selected.RemoveAt(index);
                    continue;
                }

                index++;
            }


        }


        /// <summary>
        /// GridView Foucse <- false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_fjs.Rows)
            {
                row.Selected = false;
            }

            foreach (DataGridViewRow row in dgv_fjm.Rows)
            {
                row.Selected = false;
            }

            foreach (DataGridViewRow row in dgv_etc.Rows)
            {
                if (row.Selected)
                {
                    row.Selected = false;
                }
            }
        }


        /// <summary>
        /// Dialog Path setting
        /// </summary>
        bool changed = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDlog = new FolderBrowserDialog();

            if (fDlog.ShowDialog() != DialogResult.OK) return;

            TreeView.Nodes.Clear();
            String path = fDlog.SelectedPath;

            TreeView.Nodes.Add(CreateDirectoryNode(new DirectoryInfo(path)));
            //pathBox.Items.Add(path.Substring(0, path.LastIndexOf('\\') + 1));
            pathBox.Items.Add(path.Substring(0, path.LastIndexOf('\\') + 1));


            currented_path.Add(TreeView.TopNode.Text);
            changed = false;
            pathBox.SelectedIndex = pathBox.Items.Count - 1;
        }


        /// <summary>
        /// FileUpload Validate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {

            if (dgv_fjs.Rows.Count == 0 || dgv_fjm.Rows.Count == 0)
            {
                MessageBoxEx.Show(this, Resources.UploadErrorText, Resources.UploadError, MessageBoxButtons.OK);
                return;
            }
        }


        /// <summary>
        /// pathBox Event
        /// </summary>
        List<String> currented_path = new List<String>();
        private void pathBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (changed)
            {
                TreeView.Nodes.Clear();
                TreeView.Nodes.Add(CreateDirectoryNode(new DirectoryInfo(pathBox.Items[pathBox.SelectedIndex].ToString() + currented_path[pathBox.SelectedIndex])));
                
            }
            changed = true;
        }


        /// <summary>
        /// Create ini_File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Console.WriteLine(Application.StartupPath+ "\\Init\\ini.txt");
            try
            {
                StreamWriter sw = File.CreateText(Application.StartupPath + "\\Init\\ini.txt");
                sw.WriteLine(pathBox.SelectedItem.ToString());
                sw.WriteLine(TreeView.TopNode.Text);
                sw.Dispose();
            }catch(IOException IE)
            {
                Console.WriteLine("ini Write error");
            }
        }

        /// <summary>
        /// Row select Toggle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(((DataGridView)sender).Rows[e.RowIndex].Selected)
            {
                ((DataGridView)sender).Rows[e.RowIndex].Selected = false;
            }
        }
    }
}
