namespace MainFrame
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_left_fill = new System.Windows.Forms.Panel();
            this.treeView = new MainFrame.TreeViewMS();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnl_left_head = new System.Windows.Forms.Panel();
            this.tsc_path = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_backSpace = new System.Windows.Forms.ToolStripButton();
            this.tsb_dialog = new System.Windows.Forms.ToolStripButton();
            this.pnl_mainFill = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnl_splitter = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_dgv = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_btns = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.pnl_mainFill_bottom = new System.Windows.Forms.Panel();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnl_mainTop = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_host = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_host_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_host_close = new System.Windows.Forms.ToolStripMenuItem();
            this.tsc_sort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.connectImage = new System.Windows.Forms.ImageList(this.components);
            this.pnl_left.SuspendLayout();
            this.pnl_left_fill.SuspendLayout();
            this.pnl_left_head.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnl_mainFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnl_splitter.SuspendLayout();
            this.pnl_right.SuspendLayout();
            this.pnl_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_btns.SuspendLayout();
            this.pnl_mainFill_bottom.SuspendLayout();
            this.pnl_mainTop.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.Controls.Add(this.pnl_left_fill);
            this.pnl_left.Controls.Add(this.pnl_left_head);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_left.MinimumSize = new System.Drawing.Size(310, 0);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnl_left.Size = new System.Drawing.Size(325, 427);
            this.pnl_left.TabIndex = 0;
            // 
            // pnl_left_fill
            // 
            this.pnl_left_fill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_left_fill.Controls.Add(this.treeView);
            this.pnl_left_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_left_fill.Location = new System.Drawing.Point(12, 29);
            this.pnl_left_fill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_left_fill.Name = "pnl_left_fill";
            this.pnl_left_fill.Size = new System.Drawing.Size(313, 398);
            this.pnl_left_fill.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.SelectedNodes = ((System.Collections.ArrayList)(resources.GetObject("treeView.SelectedNodes")));
            this.treeView.Size = new System.Drawing.Size(311, 396);
            this.treeView.TabIndex = 1;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.Tree_BeforeExpand);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeNode_Click);
            this.treeView.Click += new System.EventHandler(this.TreeView_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "FolderClosed_16x.png");
            this.imageList.Images.SetKeyName(1, "TextFile_16x.png");
            this.imageList.Images.SetKeyName(2, "voidFile.png");
            // 
            // pnl_left_head
            // 
            this.pnl_left_head.Controls.Add(this.tsc_path);
            this.pnl_left_head.Controls.Add(this.panel3);
            this.pnl_left_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_left_head.Location = new System.Drawing.Point(12, 0);
            this.pnl_left_head.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_left_head.Name = "pnl_left_head";
            this.pnl_left_head.Size = new System.Drawing.Size(313, 29);
            this.pnl_left_head.TabIndex = 0;
            // 
            // tsc_path
            // 
            this.tsc_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsc_path.FormattingEnabled = true;
            this.tsc_path.Location = new System.Drawing.Point(66, 0);
            this.tsc_path.Name = "tsc_path";
            this.tsc_path.Size = new System.Drawing.Size(247, 30);
            this.tsc_path.TabIndex = 1;
            this.tsc_path.SelectedIndexChanged += new System.EventHandler(this.Path_Cash_Changed);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.toolStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 29);
            this.panel3.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_backSpace,
            this.tsb_dialog});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(80, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_backSpace
            // 
            this.tsb_backSpace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_backSpace.Image = ((System.Drawing.Image)(resources.GetObject("tsb_backSpace.Image")));
            this.tsb_backSpace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_backSpace.Name = "tsb_backSpace";
            this.tsb_backSpace.Size = new System.Drawing.Size(29, 26);
            this.tsb_backSpace.ToolTipText = "一つの上のフォルダに移動";
            this.tsb_backSpace.Click += new System.EventHandler(this.BackSpace_Button_Click);
            // 
            // tsb_dialog
            // 
            this.tsb_dialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_dialog.Image = ((System.Drawing.Image)(resources.GetObject("tsb_dialog.Image")));
            this.tsb_dialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_dialog.Name = "tsb_dialog";
            this.tsb_dialog.Size = new System.Drawing.Size(29, 26);
            this.tsb_dialog.Text = "toolStripButton2";
            this.tsb_dialog.ToolTipText = "現在のフォルダを移動";
            this.tsb_dialog.Click += new System.EventHandler(this.FolderDialog_Click);
            // 
            // pnl_mainFill
            // 
            this.pnl_mainFill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_mainFill.Controls.Add(this.splitContainer);
            this.pnl_mainFill.Controls.Add(this.pnl_mainFill_bottom);
            this.pnl_mainFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_mainFill.Location = new System.Drawing.Point(0, 26);
            this.pnl_mainFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_mainFill.Name = "pnl_mainFill";
            this.pnl_mainFill.Size = new System.Drawing.Size(821, 483);
            this.pnl_mainFill.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnl_left);
            this.splitContainer.Panel1MinSize = 310;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnl_splitter);
            this.splitContainer.Size = new System.Drawing.Size(819, 427);
            this.splitContainer.SplitterDistance = 325;
            this.splitContainer.SplitterWidth = 7;
            this.splitContainer.TabIndex = 7;
            // 
            // pnl_splitter
            // 
            this.pnl_splitter.Controls.Add(this.pnl_right);
            this.pnl_splitter.Controls.Add(this.pnl_btns);
            this.pnl_splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_splitter.Location = new System.Drawing.Point(0, 0);
            this.pnl_splitter.Name = "pnl_splitter";
            this.pnl_splitter.Size = new System.Drawing.Size(487, 427);
            this.pnl_splitter.TabIndex = 6;
            // 
            // pnl_right
            // 
            this.pnl_right.AutoSize = true;
            this.pnl_right.Controls.Add(this.pnl_dgv);
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_right.Location = new System.Drawing.Point(76, 0);
            this.pnl_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnl_right.Size = new System.Drawing.Size(411, 427);
            this.pnl_right.TabIndex = 4;
            // 
            // pnl_dgv
            // 
            this.pnl_dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dgv.Controls.Add(this.dgv);
            this.pnl_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dgv.Location = new System.Drawing.Point(0, 0);
            this.pnl_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_dgv.Name = "pnl_dgv";
            this.pnl_dgv.Size = new System.Drawing.Size(399, 427);
            this.pnl_dgv.TabIndex = 4;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_folder,
            this.col_path});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(397, 425);
            this.dgv.TabIndex = 3;
            // 
            // col_name
            // 
            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_name.HeaderText = "名前";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_folder
            // 
            this.col_folder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_folder.HeaderText = "フォルダ";
            this.col_folder.MinimumWidth = 6;
            this.col_folder.Name = "col_folder";
            this.col_folder.ReadOnly = true;
            this.col_folder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_path
            // 
            this.col_path.HeaderText = "パス";
            this.col_path.MinimumWidth = 6;
            this.col_path.Name = "col_path";
            this.col_path.ReadOnly = true;
            this.col_path.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_path.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_path.Visible = false;
            this.col_path.Width = 36;
            // 
            // pnl_btns
            // 
            this.pnl_btns.Controls.Add(this.btn_remove);
            this.pnl_btns.Controls.Add(this.btn_insert);
            this.pnl_btns.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_btns.Location = new System.Drawing.Point(0, 0);
            this.pnl_btns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Size = new System.Drawing.Size(76, 427);
            this.pnl_btns.TabIndex = 2;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_remove.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.Location = new System.Drawing.Point(15, 255);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(44, 44);
            this.btn_remove.TabIndex = 1;
            this.btn_remove.Tag = "まとめたファイルを引き出す";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.Remove_File_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_insert.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_insert.Image")));
            this.btn_insert.Location = new System.Drawing.Point(15, 140);
            this.btn_insert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(44, 44);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Tag = "アプロードするファイルをまとめる";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.Insert_File_Click);
            // 
            // pnl_mainFill_bottom
            // 
            this.pnl_mainFill_bottom.Controls.Add(this.btn_Upload);
            this.pnl_mainFill_bottom.Controls.Add(this.panel6);
            this.pnl_mainFill_bottom.Controls.Add(this.btn_clear);
            this.pnl_mainFill_bottom.Controls.Add(this.panel7);
            this.pnl_mainFill_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_mainFill_bottom.Location = new System.Drawing.Point(0, 427);
            this.pnl_mainFill_bottom.Name = "pnl_mainFill_bottom";
            this.pnl_mainFill_bottom.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnl_mainFill_bottom.Size = new System.Drawing.Size(819, 54);
            this.pnl_mainFill_bottom.TabIndex = 5;
            // 
            // btn_Upload
            // 
            this.btn_Upload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Upload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Upload.Location = new System.Drawing.Point(694, 10);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(115, 34);
            this.btn_Upload.TabIndex = 0;
            this.btn_Upload.Text = "登　　録";
            this.btn_Upload.UseVisualStyleBackColor = false;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(809, 10);
            this.panel6.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.SeaShell;
            this.btn_clear.Location = new System.Drawing.Point(407, 10);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(115, 34);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Visible = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(809, 10);
            this.panel7.TabIndex = 3;
            // 
            // pnl_mainTop
            // 
            this.pnl_mainTop.Controls.Add(this.menuStrip);
            this.pnl_mainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_mainTop.Location = new System.Drawing.Point(0, 0);
            this.pnl_mainTop.Name = "pnl_mainTop";
            this.pnl_mainTop.Size = new System.Drawing.Size(821, 26);
            this.pnl_mainTop.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip.BackgroundImage")));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_host,
            this.tsc_sort,
            this.toolStripTextBox1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(821, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menu_host
            // 
            this.menu_host.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_host_setting,
            this.toolStripSeparator1,
            this.menu_host_close});
            this.menu_host.Name = "menu_host";
            this.menu_host.Size = new System.Drawing.Size(88, 22);
            this.menu_host.Text = "メニュー(&M)";
            // 
            // menu_host_setting
            // 
            this.menu_host_setting.Name = "menu_host_setting";
            this.menu_host_setting.Size = new System.Drawing.Size(150, 26);
            this.menu_host_setting.Text = "設定(&O)";
            this.menu_host_setting.Click += new System.EventHandler(this.HostData_Setting_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // menu_host_close
            // 
            this.menu_host_close.Name = "menu_host_close";
            this.menu_host_close.Size = new System.Drawing.Size(150, 26);
            this.menu_host_close.Text = "閉じる(&Q)";
            this.menu_host_close.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsc_sort
            // 
            this.tsc_sort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsc_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsc_sort.DropDownWidth = 121;
            this.tsc_sort.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tsc_sort.Name = "tsc_sort";
            this.tsc_sort.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.tsc_sort.Size = new System.Drawing.Size(75, 22);
            this.tsc_sort.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 22);
            this.toolStripTextBox1.Text = "整列";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // connectImage
            // 
            this.connectImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("connectImage.ImageStream")));
            this.connectImage.TransparentColor = System.Drawing.Color.Transparent;
            this.connectImage.Images.SetKeyName(0, "GreenButton.png");
            this.connectImage.Images.SetKeyName(1, "RedButton.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(821, 509);
            this.Controls.Add(this.pnl_mainFill);
            this.Controls.Add(this.pnl_mainTop);
            this.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(839, 556);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MAP UPLOADER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left_fill.ResumeLayout(false);
            this.pnl_left_head.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_mainFill.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnl_splitter.ResumeLayout(false);
            this.pnl_splitter.PerformLayout();
            this.pnl_right.ResumeLayout(false);
            this.pnl_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_btns.ResumeLayout(false);
            this.pnl_mainFill_bottom.ResumeLayout(false);
            this.pnl_mainTop.ResumeLayout(false);
            this.pnl_mainTop.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_left_head;
        private System.Windows.Forms.Panel pnl_left_fill;
        public System.Windows.Forms.ImageList imageList;
        public TreeViewMS treeView;
        private System.Windows.Forms.Panel pnl_mainFill;
        private System.Windows.Forms.Panel pnl_btns;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_dgv;
        private System.Windows.Forms.Panel pnl_mainTop;
        private System.Windows.Forms.Panel pnl_mainFill_bottom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_backSpace;
        private System.Windows.Forms.ToolStripButton tsb_dialog;
        private System.Windows.Forms.ComboBox tsc_path;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.Panel pnl_splitter;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_host;
        private System.Windows.Forms.ToolStripMenuItem menu_host_setting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_host_close;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ImageList connectImage;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_path;
        private System.Windows.Forms.ToolStripComboBox tsc_sort;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.SplitContainer splitContainer;
    }
}
