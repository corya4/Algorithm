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
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_left_fill = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnl_left_head = new System.Windows.Forms.Panel();
            this.cbx_path = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_dgv = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnl_btns = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView = new TreeViewMS.TreeViewMS();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_left.SuspendLayout();
            this.pnl_left_fill.SuspendLayout();
            this.pnl_left_head.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_right.SuspendLayout();
            this.pnl_dgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnl_btns.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.Controls.Add(this.pnl_left_fill);
            this.pnl_left.Controls.Add(this.pnl_left_head);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnl_left.Size = new System.Drawing.Size(327, 444);
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
            this.pnl_left_fill.Size = new System.Drawing.Size(315, 415);
            this.pnl_left_fill.TabIndex = 1;
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
            this.pnl_left_head.Controls.Add(this.cbx_path);
            this.pnl_left_head.Controls.Add(this.panel3);
            this.pnl_left_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_left_head.Location = new System.Drawing.Point(12, 0);
            this.pnl_left_head.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_left_head.Name = "pnl_left_head";
            this.pnl_left_head.Size = new System.Drawing.Size(315, 29);
            this.pnl_left_head.TabIndex = 0;
            // 
            // cbx_path
            // 
            this.cbx_path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_path.FormattingEnabled = true;
            this.cbx_path.Location = new System.Drawing.Point(80, 0);
            this.cbx_path.Name = "cbx_path";
            this.cbx_path.Size = new System.Drawing.Size(235, 30);
            this.cbx_path.TabIndex = 1;
            this.cbx_path.SelectedIndexChanged += new System.EventHandler(this.cbx_path_SelectedIndexChanged);
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
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(80, 29);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 26);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 26);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.splitter1);
            this.pnl_main.Controls.Add(this.panel4);
            this.pnl_main.Controls.Add(this.pnl_left);
            this.pnl_main.Controls.Add(this.panel2);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 13);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(821, 496);
            this.pnl_main.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(327, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 444);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnl_right);
            this.panel4.Controls.Add(this.pnl_btns);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(327, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 444);
            this.panel4.TabIndex = 6;
            // 
            // pnl_right
            // 
            this.pnl_right.AutoSize = true;
            this.pnl_right.Controls.Add(this.pnl_dgv);
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_right.Location = new System.Drawing.Point(70, 0);
            this.pnl_right.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Padding = new System.Windows.Forms.Padding(0, 29, 12, 0);
            this.pnl_right.Size = new System.Drawing.Size(424, 444);
            this.pnl_right.TabIndex = 4;
            // 
            // pnl_dgv
            // 
            this.pnl_dgv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dgv.Controls.Add(this.dgv);
            this.pnl_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_dgv.Location = new System.Drawing.Point(0, 29);
            this.pnl_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_dgv.Name = "pnl_dgv";
            this.pnl_dgv.Size = new System.Drawing.Size(412, 415);
            this.pnl_dgv.TabIndex = 4;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(410, 413);
            this.dgv.TabIndex = 3;
            this.dgv.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgv_SortCompare);
            // 
            // pnl_btns
            // 
            this.pnl_btns.Controls.Add(this.button2);
            this.pnl_btns.Controls.Add(this.button1);
            this.pnl_btns.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_btns.Location = new System.Drawing.Point(0, 0);
            this.pnl_btns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Size = new System.Drawing.Size(70, 444);
            this.pnl_btns.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(18, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 44);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.LeftMove_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(18, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RightMove_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 52);
            this.panel2.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSalmon;
            this.button5.Location = new System.Drawing.Point(452, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 38);
            this.button5.TabIndex = 2;
            this.button5.Text = "リセット";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(694, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "閉じる";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(573, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 38);
            this.button3.TabIndex = 0;
            this.button3.Text = "登　　録";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 13);
            this.panel1.TabIndex = 2;
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
            this.treeView.Size = new System.Drawing.Size(313, 413);
            this.treeView.TabIndex = 1;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.Tree_BeforeExpand);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeNode_Click);
            this.treeView.Click += new System.EventHandler(this.TreeView_Click);
            // 
            // col_name
            // 
            this.col_name.HeaderText = "名前";
            this.col_name.MinimumWidth = 6;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 73;
            // 
            // col_folder
            // 
            this.col_folder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.col_folder.HeaderText = "フォルダ";
            this.col_folder.MinimumWidth = 6;
            this.col_folder.Name = "col_folder";
            this.col_folder.ReadOnly = true;
            this.col_folder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_folder.Width = 64;
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
            this.col_path.Width = 43;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(821, 509);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "FJMAP_FileUploader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left_fill.ResumeLayout(false);
            this.pnl_left_head.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl_right.ResumeLayout(false);
            this.pnl_dgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnl_btns.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_left_head;
        private System.Windows.Forms.Panel pnl_left_fill;
        private System.Windows.Forms.ImageList imageList;
        private TreeViewMS.TreeViewMS treeView;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_btns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_dgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox cbx_path;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_path;
    }
}

