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
using System.Windows.Forms;

namespace MainFrame
{
    public partial class MainForm : Form
    {

        static StringBuilder path = new StringBuilder(255);
        static StringBuilder host = new StringBuilder(255);
        FtpWebRequest request;
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
            tsc_path.Items.Add(path.ToString());
            tsc_path.SelectedIndex = tsc_path.Items.Count - 1;
            tsc_sort.SelectedIndex = 0;

            hostData = new HostData();

            INIFile.ReadIniHost(hostData, host);
            hostData.LocalPath = path.ToString(); //ローカルパス
            ConnectHost();
            
        }


        /// <summary>
        /// サーバー接続確認メソッド
        /// </summary>
        private void ConnectHost()
        {

            try {

                request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}/{1}", hostData.IP, hostData.UploadPath))) as FtpWebRequest;

                request.Credentials = new NetworkCredential(hostData.ID, hostData.PW);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.GetResponse();

                tsb_image.Image = connectImage.Images[1];
                ts_label.Text = hostData.IP + Resources.Connect;

                tsb_image.ToolTipText = hostData.UploadPath;
            }
            catch (Exception e) //エラーがある時、TAG初期化
            {
                String error_type = e.Message;

                tsb_image.Image = connectImage.Images[0];
                ts_label.Text = Resources.NotConnect;

                if (error_type.IndexOf(Resources.ACOUNT_ERROR) != -1)
                {
                    tsb_image.ToolTipText = Resources.ACOUNT_ERROR_MESSAGE;
                
                } 
                else if (error_type.IndexOf(Resources.IP_ERROR) != -1)
                {
                    tsb_image.ToolTipText = Resources.IP_ERROR_MESSAGE;

                }
                else if (error_type.IndexOf(Resources.UPLOADPATH_ERROR) != -1)
                {
                    tsb_image.ToolTipText = Resources.UPLOADPATH_ERROR_MESSAGE;

                }
            }
            
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

                }
            }

            foreach (FileInfo fi in info.GetFiles())//現在のフォルダの中にあるファイルを検査
            {
                String ext = Path.GetExtension(fi.Name);
                TreeNode n = new TreeNode(fi.Name);

                if (!ext.Equals("") && ext.Length < 5 && !imageList.Images.ContainsKey(ext)) //拡張子が正常的かないか確認、そしてイメージリストにあるか確認
                {
                    try {
                        icon = System.Drawing.Icon.ExtractAssociatedIcon(fi.FullName); //ファイルの拡張子と同じなIconを持ってくる
                        imageList.Images.Add(ext, icon);

                    }
                    catch (Exception e)
                    {

                    }
                }

                if (ext.IndexOf('.') == -1) //拡張子がなかったら
                {
                    n.ImageKey = "voidFile.png";
                }
                else
                {

                    n.ImageKey = fi.Extension;
                }

                if (imageList.Images.IndexOfKey(fi.Extension) == -1) n.ImageKey = "voidFile.png"; //Windowにない拡張子だったら

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
                dgv.Rows.Add(Path.GetFileName(tag), Path.GetDirectoryName(tag), tag);
                selectNode.Add(tag);

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
            if (path.Equals("")) path = "C:";

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

            int lastIndex = path.LastIndexOf("\\");

            if (lastIndex < 2) return;

            path = path.Substring(0, lastIndex);

            if (path.IndexOf("\\") == -1)
            {
                tsc_path.Items.Add(path + "\\");
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


        /// <summary>
        /// DataGridViewのDataを整列するメソッド
        /// </summary>
        private void RowSort()
        {
            int index = tsc_sort.SelectedIndex;

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
        private void btn_Upload_Click(object sender, EventArgs e)
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

            if (ErrorMessage.Length != 0)
            {
                MessageBoxEx.Show(this, ErrorMessage.ToString(), Resources.NULLERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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

            }


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

            if (ts_label.Text.Equals(Resources.NotConnect)) return;

            FileUpload load = new FileUpload(hostData, selectNode);
            load.Uploader(request, hostData);
        }


        /// <summary>
        /// DataGridViewのRowをカウントするメソッド
        /// </summary>
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
                    row.Cells[0].Style.ForeColor = Color.BlueViolet;
                    row.Cells[1].Style.ForeColor = Color.BlueViolet;
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
            if(hostData.LocalPath != null && !hostData.LocalPath.Equals(""))
            {
                INIFile.WriteIniFile(hostData.LocalPath);
            }
            else
            {
                INIFile.WriteIniFile(tsc_path.SelectedItem.ToString());
            }

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


        /// <summary>
        /// サーバーの情報を再確認するフォムをOpenするイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HostData_Setting_Click(object sender, EventArgs e)
        {
            ConfirmForm confirm = new ConfirmForm(hostData);
            confirm.ShowDialog();

            ConnectHost();
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

        
    }
}
