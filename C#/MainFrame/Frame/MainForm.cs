using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame
{
    public partial class MainForm : Form
    {

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(String section, String key, String val, String filePath);

        [DllImport("kernel32")]
        private static extern int GetprivateProfileString(String section, String key, String def, StringBuilder retVal, int size, String filePath);

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String path = @"C:\kijung\";
            DirectoryInfo di = new DirectoryInfo(path);
            TreeNode node = new TreeNode(di.Name);
            treeView.Nodes.Add(node);
            CreateDirectoryNode(di, node);

        }

        private void CreateDirectoryNode(DirectoryInfo info, TreeNode node)
        {
            Icon icon = SystemIcons.WinLogo;

            foreach (DirectoryInfo di in info.GetDirectories())
            {
                TreeNode n = new TreeNode(di.Name);
                n.Nodes.Add(new TreeNode());
                n.Tag = di.FullName;
                node.Nodes.Add(n);
            }
           

            foreach (FileInfo fi in info.GetFiles())
            {
                String ext = Path.GetExtension(fi.Name);
               TreeNode n = new TreeNode(fi.Name);

                if (!ext.Equals("") && ext.Length < 5 && !imageList.Images.ContainsKey(ext))
                {
                    try {
                        Console.WriteLine(ext);
                        icon = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName);
                        imageList.Images.Add(ext, icon);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());

                    }
                }

                n.ImageKey = fi.Extension;
                node.Nodes.Add(n);

            }

        }


        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.SelectedImageKey = e.Node.ImageKey;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDlog = new FolderBrowserDialog();

            if (fDlog.ShowDialog() != DialogResult.OK) return;
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (treeView.TopNode != e.Node)
            {
                e.Node.Nodes.Clear();
                DirectoryInfo di = new DirectoryInfo(e.Node.Tag.ToString());
                CreateDirectoryNode(di, e.Node);
            }
        }
    }
}
