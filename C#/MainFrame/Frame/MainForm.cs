using MainFrame.INI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame
{
    public partial class MainForm : Form
    {

        static StringBuilder path = new StringBuilder(255);
        List<String> deletedList = new List<String>();
        List<String> selectNode = new List<String>();
        List<String> addList = new List<String>();
        List<String> openNode = new List<String>();

        bool flag = true;

        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            INIFile.ReadIniFile(path);

            cbx_path.Items.Add(path);
            cbx_path.SelectedIndex = cbx_path.Items.Count - 1;
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

            if (treeView.TopNode != e.Node)
            {
                e.Node.Nodes.Clear();
                DirectoryInfo di = new DirectoryInfo(e.Node.Tag.ToString());
                CreateDirectoryNode(di, e.Node);
            }


            //if (!flag) return;
            ReDrawNode(e.Node);
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


            ReDrawNode(treeView.TopNode);
            ToggleNode(treeView.TopNode);

            openNode.Clear();
            clearSelected();
            clearDictionary();


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
            ReDrawNode(treeView.TopNode);

            ToggleNode(treeView.TopNode);

            openNode.Clear();
            deletedList.Clear();
            dgv.ClearSelection();
            clearSelected();
            clearDictionary();
        }

  

        //boolean 형으로 연산 줄이기
        private void ToggleNode(TreeNode node)
        {
            
            foreach(TreeNode n in node.Nodes)
            {

                if (n.Tag == null) continue;

                if (n.Nodes != null)
                {
                    ToggleNode(n);
                }

                String dir = n.Tag.ToString();

                if (openNode.Contains(dir))
                {
                    
                    if (n.IsExpanded)
                    {
                        n.Collapse(true);
                        flag = false;
                        n.Expand();
                        flag = true;
                    }
                }

            }

        }

        private void SelectedReMove()
        {
            foreach (String tag in deletedList)
            {
                selectNode.Remove(tag);

                String dir = Path.GetDirectoryName(tag);

                if (!openNode.Contains(dir))
                {
                    openNode.Add(dir);
                }

            }
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


        private void ReDrawNode(TreeNode node)
        {

            if (node.Nodes != null)
            {
                
                foreach (TreeNode n in node.Nodes)
                {
                    ReDrawNode(n);
                }
            }

            if (node.Tag == null) return;

            if (selectNode.Contains(node.Tag.ToString()))
            {
                node.ForeColor = Color.Gray;
            }
            else
            {
                node.ForeColor = Color.Black;
                  
            }



        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            INIFile.WriteIniFile(cbx_path.SelectedItem.ToString());
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

            if(path.IndexOf("\\") == -1)
            {
                cbx_path.Items.Add(path+"\\");
            }
            else
            {
                cbx_path.Items.Add(path);
            }

            cbx_path.SelectedIndex = cbx_path.Items.Count - 1;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            selectNode.Clear();

            String topNode = treeView.TopNode.Tag.ToString();
            treeView.TopNode.Nodes.Clear();
            DirectoryInfo di = new DirectoryInfo(topNode);
            CreateDirectoryNode(di, treeView.TopNode);
        }


        //중복 처리 [ 동적 폼 ]
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            String str1 = Path.GetExtension(dgv.Rows[e.RowIndex1].Cells[0].Value.ToString());
            String str2 = Path.GetExtension(dgv.Rows[e.RowIndex2].Cells[0].Value.ToString());

            int r1 = str1.Equals(".fjm") ? 3 : str1.Equals(".fjs") ? 2 : 1;
            int r2 = str2.Equals(".fjm") ? 3 : str2.Equals(".fjs") ? 2 : 1;

            e.SortResult = r2 - r1;

            e.Handled = true;
        }

    }
}
