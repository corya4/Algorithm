using MainFrame.Frame;
using MainFrame.INI;
using MainFrame.Properties;
using MainFrame.Sources;
using mem_hkj;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MainFrame
{
    public partial class MainForm : Form
    {

        static StringBuilder path = new StringBuilder(255);
        HostData hostData;

        public List<String> deletedList = new List<String>();
        public List<String> selectNode = new List<String>();
        public List<String> addList = new List<String>();

        public int select_fjm { get; set; }
        public int select_fjs { get; set; }

        bool overLap = true;

        
        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            INIFile.ReadIniFile(path);
            cbx_path.Items.Add(path.ToString());
            cbx_path.SelectedIndex = cbx_path.Items.Count - 1;
            sortBox.SelectedIndex = 0;
        }

        private void CreateDirectoryNode(DirectoryInfo info, TreeNode node)
        {
            Icon icon = SystemIcons.WinLogo;

            foreach (DirectoryInfo di in info.GetDirectories())
            {
                TreeNode n = new TreeNode(di.Name);

                try
                {
                    if (di.GetDirectories().Length > 0 || di.GetFiles().Length > 0)
                    {
                        n.Nodes.Add(new TreeNode());
                    }

                    n.Tag = di.FullName;
                    node.Nodes.Add(n);
                }
                catch (Exception ex)
                {

                }
            }

            foreach (FileInfo fi in info.GetFiles())
            {
                String ext = Path.GetExtension(fi.Name);
                TreeNode n = new TreeNode(fi.Name);

                if (!ext.Equals("") && ext.Length < 5 && !imageList.Images.ContainsKey(ext))
                {
                    try {
                        icon = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName);
                        imageList.Images.Add(ext, icon);

                    }
                    catch (Exception e)
                    {

                    }
                }

                if (ext.IndexOf('.') == -1)
                {
                    n.ImageKey = "voidFile.png";
                }
                else
                {

                    n.ImageKey = fi.Extension;
                }

                if (imageList.Images.IndexOfKey(fi.Extension) == -1) n.ImageKey = "voidFile.png";

                n.Tag = fi.FullName;
                node.Nodes.Add(n);

            }


        }

        private void TreeNode_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.SelectedImageKey = e.Node.ImageKey;
        }

        private void Tree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {

            ExpandNode(e.Node);

        }

        private void ExpandNode(TreeNode e)
        {

            e.Nodes.Clear();
            DirectoryInfo di = new DirectoryInfo(e.Tag.ToString());
            CreateDirectoryNode(di, e);

            ReDrawNode();
        }

        private void TreeView_Click(object sender, EventArgs e)
        {
            clearSelected();
        }

        private void clearSelected()
        {
            treeView.removePaintFromNodes();
            pnl_left_fill.Focus();
        }

        private void clearDictionary()
        {
            treeView.SelectedNode = null;
            treeView.m_coll.Clear();
        }


        private void RightMove_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNodes == null) return;

            GetDataRowFullPath();

            foreach (TreeNode node in treeView.SelectedNodes)
            {

                String tag = node.Tag.ToString();

                if (Directory.Exists(tag))
                {
                    moveNodes(tag);
                }
                else
                {
                    moveNode(tag);
                }
            }

            ReDrawNode();
            clearSelected();

            RowSort();
            RowCheck();
            Header_Count();

        }

        private void moveNodes(String tag)
        {

            DirectoryInfo di = new DirectoryInfo(tag);

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                moveNodes(dir.FullName);
            }

            foreach (FileInfo fi in di.GetFiles())
            {
                moveNode(fi.FullName);
            }
        }


        private void moveNode(String tag)
        {
            if (!addList.Contains(tag))
            {
                dgv.Rows.Add(Path.GetFileName(tag), Path.GetDirectoryName(tag), tag);
                selectNode.Add(tag);

            }
        }

        private List<String> GetDataRowFullPath()
        {
            addList.Clear();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                addList.Add(row.Cells[2].Value.ToString());
            }

            return addList;
        }


        private void LeftMove_Click(object sender, EventArgs e)
        {

            if (dgv.SelectedRows == null) return;
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                String key = row.Cells[2].Value.ToString();
                deletedList.Add(key);
                dgv.Rows.Remove(row);

            }

            SelectedReMove();
            ReDrawNode();

            deletedList.Clear();
            dgv.ClearSelection();

            clearSelected();
            clearDictionary();
            RowCheck();
            Header_Count();
        }


        private void SelectedReMove()
        {
            foreach (String tag in deletedList)
            {
                selectNode.Remove(tag);

            }
        }


        private void ReDrawNode()
        {

            ReDrawNode(treeView.Nodes[0]);
        }

        private void ReDrawNode(TreeNode node)
        {

            if (node.Tag == null)
            {
                return;

            }

            foreach (TreeNode n in node.Nodes)
            {
                ReDrawNode(n);
            }


            if (selectNode.Contains(node.Tag.ToString()))
            {
                node.ForeColor = Color.Gray;
            }
            else
            {
                node.ForeColor = Color.Black;

            }

        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDlog = new FolderBrowserDialog();

            if (fDlog.ShowDialog() != DialogResult.OK) return;

            cbx_path.Items.Add(fDlog.SelectedPath);
            cbx_path.SelectedIndex = cbx_path.Items.Count - 1;
        }

        private void cbx_path_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            clearDictionary();

            String path = cbx_path.SelectedItem.ToString();
            if (path.Equals("")) path = "C:";

            DirectoryInfo di = new DirectoryInfo(path.ToString());
            TreeNode node = new TreeNode(di.Name);

            treeView.Nodes.Add(node);
            treeView.TopNode.Tag = path;
            CreateDirectoryNode(di, node);

            treeView.TopNode.Expand();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String path = cbx_path.SelectedItem.ToString();

            int lastIndex = path.LastIndexOf("\\");

            if (lastIndex < 2) return;

            path = path.Substring(0, lastIndex);

            if (path.IndexOf("\\") == -1)
            {
                cbx_path.Items.Add(path + "\\");
            }
            else
            {
                cbx_path.Items.Add(path);
            }

            cbx_path.SelectedIndex = cbx_path.Items.Count - 1;

        }

        private void RowCheck()
        {

            overLap = true;

            Dictionary<String, List<DataGridViewRow>> list = new Dictionary<string, List<DataGridViewRow>>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                String name = row.Cells[0].Value.ToString();
                if (list.ContainsKey(name))
                {
                    list[name].Add(row);
                    
                }
                else
                {
                    list.Add(name, new List<DataGridViewRow> { row });
                }
            }

            foreach (KeyValuePair<String, List<DataGridViewRow>> pair in list)
            {
                List<DataGridViewRow> rows = pair.Value;
                if(rows.Count == 1)
                {
                    rows[0].DefaultCellStyle.BackColor = Color.White;
                    rows[0].Cells[0].Style.ForeColor = Color.Black;
                    rows[0].Cells[1].Style.ForeColor = Color.Black;
                    continue;
                }
                
                foreach(DataGridViewRow row in rows)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.Cells[0].Style.ForeColor = Color.White;
                    row.Cells[1].Style.ForeColor = Color.White;
                }

                overLap = false;
            }

        }

        private void RowSort()
        {
            int index = sortBox.SelectedIndex;

            switch (index)
            {

                case 0:
                    dgv.Sort(new DataSort(true, 0, 0, 0));
                    break;
                case 1:
                    dgv.Sort(new DataSort(false, 3, 2, 1));
                    break;
                case 2:
                    dgv.Sort(new DataSort(false, 2, 3, 1));
                    break;
                case 3:
                    dgv.Sort(new DataSort(false, 2 ,1, 3));
                    break;

            }
           
        }


        private void button5_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            selectNode.Clear();

            ReDrawNode();
        }


        private void button3_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> fjm_rows = new List<DataGridViewRow>();
            List<DataGridViewRow> fjs_rows = new List<DataGridViewRow>();


            bool isOver = true;

            StringBuilder ErrorMessage = new StringBuilder();

            if (!overLap) ErrorMessage.Append("  重複したファイルがあります。" + "\n");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                String ext = Path.GetExtension(row.Cells[0].Value.ToString());
                String name = row.Cells[0].Value.ToString();

                switch (ext)
                {
                    case ".fjm":
                        fjm_rows.Add(row);
                        break;
                    case ".fjs":
                        fjs_rows.Add(row);
                        break;
                }


            }

            //Exception bool
            if (fjm_rows.Count == 0)
            {
                ErrorMessage.Append("  FJMファイルがありません。" + "\n");
            }
            else if (fjm_rows.Count != 1)
            {
                isOver = false;
            }


            if (fjs_rows.Count == 0)
            {
                ErrorMessage.Append("  FJSファイルがありません。" + "\n");
            }
            else if (fjs_rows.Count != 1)
            {
                isOver = false;
            }
            //end


            if (ErrorMessage.Length != 0)
            {
                MessageBoxEx.Show(this, ErrorMessage.ToString(), Resources.NULLERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// NullPoint if


            if (!isOver)
            {
                if (fjm_rows.Count > 1)
                {
                    SelectForm sForm = new SelectForm(this, "FJMファイル", fjm_rows);
                    sForm.ShowDialog();

                }

                if (fjs_rows.Count > 1)
                {
                    SelectForm sForm = new SelectForm(this, "FJSファイル", fjs_rows);
                    sForm.ShowDialog();

                }

            }//OverLap if


            bool selectNull = true;

            if (select_fjm >= 0)
            {
                for (int i = 0; i < fjm_rows.Count; i++)
                {
                    if (i != select_fjm)
                    {
                        DataGridViewRow row = fjm_rows[i];
                        String tag = row.Cells[2].Value.ToString();

                        dgv.Rows.Remove(row);
                        selectNode.Remove(tag);
                    }
                }
            }
            else if(select_fjm == -1)
            {
                selectNull = false;
            }


            if (select_fjs >= 0)
            {
                for (int i = 0; i < fjs_rows.Count; i++)
                {
                    if (i != select_fjs)
                    {
                        DataGridViewRow row = fjs_rows[i];
                        String tag = row.Cells[2].Value.ToString();

                        dgv.Rows.Remove(row);
                        selectNode.Remove(tag);
                    }
                }
            }
            else if(select_fjs == -1)
            {
                selectNull = false;
            }

            select_fjm = -2;
            select_fjs = -2;

            if (!selectNull) return;


            ReDrawNode();


            StringBuilder file_log = new StringBuilder();
            foreach(DataGridViewRow row in dgv.Rows)
            {
                file_log.Append(row.Cells[0].Value.ToString() + '\n');
            }

            if (MessageBoxEx.Show(this, file_log.ToString(), "UPLOAD FILES" , MessageBoxButtons.OKCancel) != DialogResult.OK) return;

            //
            //ファイル伝送ソース
            //

            FileUpload load = new FileUpload(hostData, selectNode);
            load.Uploader();
        }


        private void Header_Count()
        {
            int rank = 1;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = rank + "";

                String ext = Path.GetExtension(row.Cells[0].Value.ToString());
                if (ext.Equals(Resources.EXT_FJM))
                {
                    row.Cells[0].Style.ForeColor = Color.DarkViolet;
                    row.Cells[1].Style.ForeColor = Color.DarkViolet;
                }
                else if (ext.Equals(Resources.EXT_FJS))
                {
                    row.Cells[0].Style.ForeColor = Color.OrangeRed;
                    row.Cells[1].Style.ForeColor = Color.OrangeRed;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                rank++;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            INIFile.WriteIniFile(cbx_path.SelectedItem.ToString());
        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RowSort();
            Header_Count();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmForm confirm = new ConfirmForm(hostData);
            confirm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
