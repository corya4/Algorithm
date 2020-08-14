using MainFrame.Forms;
using MainFrame.Frame;
using MainFrame.INI;
using MainFrame.Properties;
using MainFrame.Sources;
using mem_hkj;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MainFrame
{
    public partial class MainForm : Form
    {

        static StringBuilder host = new StringBuilder(255);
        HostData hostData;
        int origin_height;

        public List<String> deletedList = new List<String>();
        public List<String> selectNode = new List<String>();
        public List<String> addList = new List<String>();

        public int select_fjm { get; set; }
        public int select_fjs { get; set; }

        bool overLap = true;


        public MainForm()
        {
            InitializeComponent();
            origin_height = this.Height;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            hostData = INIFile.ReadIniHost(host);
            tsc_path.Items.Add(hostData.LocalPath);
            tsc_path.SelectedIndex = tsc_path.Items.Count - 1;
            this.pre_s = this.Height;
        }

        /// <summary>
        /// 下位フォルダを生成するメソッド
        /// </summary>
        /// <param name="info"></param>
        /// <param name="node"></param>
        private void CreateDirectoryNode(DirectoryInfo info, TreeNode node)
        {
            Icon icon = SystemIcons.WinLogo; //WindowIcon Class

            foreach (DirectoryInfo di in info.GetDirectories()) //現在のフォルダの中にあるフォルダを検査
            {
                TreeNode n = new TreeNode(di.Name);

                try
                {
                    if (di.GetDirectories().Length > 0 || di.GetFiles().Length > 0)
                    {
                        n.Nodes.Add(new TreeNode()); //　(+)表示をため
                    }

                    n.Tag = di.FullName;
                    node.Nodes.Add(n);
                }
                catch (Exception ex)
                {
                    //技能なし
                }
            }

            foreach (FileInfo fi in info.GetFiles())//現在のフォルダの中にあるファイルを検査
            {
                String ext = Path.GetExtension(fi.Name);
                TreeNode n = new TreeNode(fi.Name);

                n.ImageKey = "voidFile.png";

                if (fi.Name.IndexOf('.') != -1)
                {

                    if (ext != null && ext != String.Empty && !imageList.Images.ContainsKey(ext)) //拡張子が正常的かないか確認、そしてイメージリストにあるか確認
                    {
                        try
                        {
                            icon = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName); //ファイルの拡張子と同じIconを持ってくる
                            imageList.Images.Add(ext, icon);

                        }
                        catch (Exception e)
                        {
                            //技能なし
                        }
                    }

                    n.ImageKey = fi.Extension;
                }
                n.Tag = fi.FullName;
                node.Nodes.Add(n);
            }

        }


        /// <summary>
        /// 選択したファイルのIconの変更を防止イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeNode_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.SelectedImageKey = e.Node.ImageKey;
        }


        /// <summary>
        /// Nodeを拡張する前のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            ExpandNode(e.Node);
        }


        /// <summary>
        /// CreateDirectoryNode呼ぶメソッド
        /// </summary>
        /// <param name="e"></param>
        private void ExpandNode(TreeNode e)
        {
            e.Nodes.Clear();
            DirectoryInfo di = new DirectoryInfo(e.Tag.ToString());
            CreateDirectoryNode(di, e);
            ReDrawNode();
        }


        /// <summary>
        /// NodeのFocusを無効イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_Click(object sender, EventArgs e)
        {
            clearSelected();
        }


        /// <summary>
        /// NodeのFocusを無効するメソッド
        /// </summary>
        private void clearSelected()
        {
            treeView.removePaintFromNodes();
            pnl_left_fill.Focus();
        }


        /// <summary>
        /// MultiSelectしたNodeを初期化するメソッド
        /// </summary>
        private void clearDictionary()
        {
            treeView.SelectedNode = null;
            treeView.m_coll.Clear();
        }


        /// <summary>
        /// >>ボタンを押した時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_File_Click(object sender, EventArgs e)
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
            Sort_EXT();
            clearSelected();
            RowSort();
            RowCheck();
            Header_Count();
        }


        /// <summary>
        /// 選ばれたフォルダ中のFileを検査
        /// </summary>
        /// <param name="tag"></param>
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


        /// <summary>
        /// 選ばれたFileをDataGridViewに入れるメソッド
        /// </summary>
        /// <param name="tag"></param>
        private void moveNode(String tag)
        {
            if (!addList.Contains(tag))
            {
                if (tag.Length < 255) {
                    dgv.Rows.Add(Path.GetFileName(tag), Path.GetDirectoryName(tag), tag);
                }
                else
                {
                    Console.WriteLine(tag);
                    String head = tag.Substring(0, (tag.Length / 2) - 1);
                    String tail = tag.Substring(tag.Length / 2);

                    dgv.Rows.Add(Path.GetFileName(tag), head + tail, tag);
                }
                selectNode.Add(tag);
            }
        }

        private void Sort_EXT()
        {
            tsc_sort.Items.Clear();
            tsc_sort.Items.Add(Resources.NAME);
            foreach (String tag in selectNode)
            {
                String ext = Path.GetExtension(tag);
                if (!tsc_sort.Items.Contains(ext))
                {
                    tsc_sort.Items.Add(ext);
                }
            }

        }


        /// <summary>
        /// 重複したファイルを防止するリスト生成メソッド
        /// </summary>
        /// <returns></returns>
        private List<String> GetDataRowFullPath()
        {
            addList.Clear();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                addList.Add(row.Cells[2].Value.ToString());
            }

            return addList;
        }


        /// <summary>
        /// <<ボタンを押した時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_File_Click(object sender, EventArgs e)
        {

            if (dgv.SelectedRows == null) return;
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                String key = row.Cells[2].Value.ToString();
                deletedList.Add(key);
                dgv.Rows.Remove(row);

            }

            SelectedReMove();
            Sort_EXT();
            ReDrawNode();

            deletedList.Clear();
            dgv.ClearSelection();

            clearSelected();
            clearDictionary();
            RowCheck();
            Header_Count();
        }


        /// <summary>
        /// Insertしたファイル情報をRemove
        /// </summary>
        private void SelectedReMove()
        {
            foreach (String tag in deletedList)
            {
                selectNode.Remove(tag);
            }
        }


        /// <summary>
        /// 最上位Nodeから検査
        /// 注意 : Node.TopNode() <- メソッドは画面で見えるNodeだけを認識
        /// </summary>
        private void ReDrawNode()
        {
            ReDrawNode(treeView.Nodes[0]);
        }


        /// <summary>
        /// DataGridViewに入っているNodeは灰色にする
        /// </summary>
        /// <param name="node"></param>
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


        /// <summary>
        /// フォルダダイアロゴで選択したパスをNodeに代入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FolderDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fDlog = new FolderBrowserDialog();

            if (fDlog.ShowDialog() != DialogResult.OK) return;


            tsc_path.Items.Add(fDlog.SelectedPath);
            tsc_path.SelectedIndex = tsc_path.Items.Count - 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Path_Cash_Changed(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            clearDictionary();

            String path = tsc_path.SelectedItem.ToString();
            if (path.Equals("")) path = DriveInfo.GetDrives()[0].Name;       //path = "C:";

            DirectoryInfo di = new DirectoryInfo(path.ToString());
            TreeNode node = new TreeNode(di.Name);

            treeView.Nodes.Add(node);
            treeView.TopNode.Tag = path;
            CreateDirectoryNode(di, node);

            treeView.TopNode.Expand();


        }


        /// <summary>
        /// BackSpaceボタンを押した時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackSpace_Button_Click(object sender, EventArgs e)
        {
            String path = tsc_path.SelectedItem.ToString();

            if (path.Length < 4) return;

            char sec = Path.DirectorySeparatorChar;
            int lastIndex = path.LastIndexOf(Convert.ToString(sec));

            Console.WriteLine(Convert.ToString(sec));
            Console.WriteLine(lastIndex);

            path = path.Substring(0, lastIndex);

            if (path.IndexOf(Convert.ToString(sec)) == -1)
            {
                tsc_path.Items.Add(path + Convert.ToString(sec));
            }
            else
            {
                tsc_path.Items.Add(path);
            }

            tsc_path.SelectedIndex = tsc_path.Items.Count - 1;

        }



        /// <summary>
        /// パスが違う同じ名前のFileを検査するメソッド
        /// </summary>
        private void RowCheck()
        {
            overLap = true;

            List<String> maps = new List<String> { ".fjs", ".fjm" };
            Dictionary<String, List<DataGridViewRow>> list = new Dictionary<string, List<DataGridViewRow>>();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                String name = row.Cells[0].Value.ToString();

                if (maps.Contains(Path.GetExtension(name)))
                {

                    if (list.ContainsKey(Path.GetExtension(name)))
                    {
                        list[Path.GetExtension(name)].Add(row);
                    }
                    else
                    {
                        list.Add(Path.GetExtension(name), new List<DataGridViewRow> { row });
                    }

                    continue;
                }

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
                if (rows.Count == 1)
                {
                    rows[0].DefaultCellStyle.BackColor = Color.White;
                    rows[0].Cells[0].Style.ForeColor = Color.Black;
                    rows[0].Cells[1].Style.ForeColor = Color.Black;
                    continue;
                }

                foreach (DataGridViewRow row in rows)
                {
                    if (row.Cells[0].Value.ToString().Contains(".fjm") || row.Cells[0].Value.ToString().Contains(".fjs"))
                    {
                        row.DefaultCellStyle.BackColor = Color.Orange;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        overLap = false;
                    }

                }

            }

        }


        /// <summary>
        /// DataGridViewのDataを整列するメソッド
        /// </summary>
        private void RowSort()
        {

            int index = tsc_sort.SelectedIndex;
            List<String> ext = new List<String>();

            for (int i = 0; i < tsc_sort.Items.Count; i++)
            {
                ext.Add(tsc_sort.Items[i].ToString());

            }

            if (index == -1)
            {
                return;
            }

            dgv.Sort(new DataSort(index, ext));

        }


        /// <summary>
        /// InsertしたFileをClearするメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            selectNode.Clear();

            ReDrawNode();
        }


        /// <summary>
        /// 登録するときのイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public StringBuilder logs { get; set; }
        private void btn_Upload_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> fjm_rows = new List<DataGridViewRow>();
            List<DataGridViewRow> fjs_rows = new List<DataGridViewRow>();

            StringBuilder ErrorMessage = new StringBuilder();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                String ext = Path.GetExtension(row.Cells[0].Value.ToString());

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

            if (fjm_rows.Count == 0)
            {
                ErrorMessage.Append("  ・FJMファイルがありません。" + "\n");
            }
            if (fjs_rows.Count == 0)
            {
                ErrorMessage.Append("  ・FJSファイルがありません。" + "\n");
            }
            if (fjm_rows.Count > 1)
            {
                ErrorMessage.Append("  ・FJMファイルが複数です。" + "\n");
            }
            if (fjs_rows.Count > 1)
            {
                ErrorMessage.Append("  ・FJSファイルが複数です。" + "\n");
            }
            if (!overLap)
            {
                ErrorMessage.Append("  ・複数のファイルがあります。" + "\n");
            }
            if (ErrorMessage.Length != 0)
            {
                MessageBoxEx.Show(this, Resources.TRANCE_TYPEMISS_ERROR + ErrorMessage.ToString(), Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder file_log = new StringBuilder();
            String folder = fjm_rows[0].Cells[0].Value.ToString();
            int split = folder.IndexOf('-');

            if (split == -1)
            {
                MessageBoxEx.Show(this, Resources.FJM_FILETYPE_ERROR, Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String folderName = folder.Substring(0, split);

            FileUpload load = new FileUpload(this, hostData, selectNode);

            if (load.Uploader(folderName.ToString()))
            {
                LogForm log = new LogForm(logs);
                log.ShowDialog();
            }


        }

        /// <summary>
        /// DataGridViewのRowをカウントするメソッド
        /// </summary>
        private void Header_Count()
        {
            int rank = 1;
            Font f = new Font("Meiryo UI", 10, FontStyle.Bold);
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.HeaderCell.Value = rank + "";

                String ext = Path.GetExtension(row.Cells[0].Value.ToString());
                if (ext.Equals(Resources.EXT_FJM))
                {

                    row.DefaultCellStyle.Font = f;
                }
                else if (ext.Equals(Resources.EXT_FJS))
                {
                    row.DefaultCellStyle.Font = f;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }

                rank++;
            }

        }


        /// <summary>
        /// INIファイルを作成するメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            INIFile.WriteIniHost(hostData);
        }


        /// <summary>
        /// 整列の基準を選択した時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RowSort();
            Header_Count();
        }


        public int status;
        /// <summary>
        /// サーバーの情報を再確認するフォムをOpenするイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HostData_Setting_Click(object sender, EventArgs e)
        {
            ConfirmForm confirm = new ConfirmForm(this, hostData);
            confirm.ShowDialog();

            if (status == 0)
            {
                FileUpload upload = new FileUpload(this, hostData, null);

                LoadingForm loading = new LoadingForm(this);
                loading.Login = (()
                    =>
                {
                    upload._ConnectHost();
                });
                loading.Message = (()
                    =>
                {
                    upload._ErrorMessage();
                });

                

                Thread thread = new Thread(() =>
                {
                    loading.ShowDialog();
                });

                thread.Start();

                if (!thread.Join(2000))
                {
                    loading.Invoke((Action)(() => 
                    {
                        if (loading.Focused)
                        {
                            loading.Close();
                            MessageBoxEx.Show(this, "サーバーに接続ができません。", Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }));
                }

                upload._CloseProcess();

            }

        }

        /// <summary>
        /// 閉めるメニューを選択する時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int pre_s;
        int div;
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            int s = this.Height;
            int ps;

            if (this.MinimumSize.Height > s) return;

            ps = s - (pre_s == 0 ? this.Height : pre_s);
            
            div += ps;
            int ratio = div / 2;
            div %= 2;

            btn_insert.Location = new Point(btn_insert.Location.X, btn_insert.Location.Y + ratio);
            btn_remove.Location = new Point(btn_remove.Location.X, btn_remove.Location.Y + ratio);

            pre_s = s;

            this.Refresh();
        }

    }
}
