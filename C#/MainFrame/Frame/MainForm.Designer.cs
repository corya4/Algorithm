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
            this.treeView = new TreeViewMS.TreeViewMS();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnl_left_head = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_btns = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_left.SuspendLayout();
            this.pnl_left_fill.SuspendLayout();
            this.pnl_left_head.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.Controls.Add(this.pnl_left_fill);
            this.pnl_left.Controls.Add(this.pnl_left_head);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.MinimumSize = new System.Drawing.Size(334, 445);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(334, 445);
            this.pnl_left.TabIndex = 0;
            // 
            // pnl_left_fill
            // 
            this.pnl_left_fill.Controls.Add(this.treeView);
            this.pnl_left_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_left_fill.Location = new System.Drawing.Point(0, 34);
            this.pnl_left_fill.Name = "pnl_left_fill";
            this.pnl_left_fill.Size = new System.Drawing.Size(334, 411);
            this.pnl_left_fill.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.SelectedNodes = ((System.Collections.ArrayList)(resources.GetObject("treeView.SelectedNodes")));
            this.treeView.Size = new System.Drawing.Size(334, 399);
            this.treeView.TabIndex = 1;
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "FolderClosed_16x.png");
            this.imageList.Images.SetKeyName(1, "TextFile_16x.png");
            // 
            // pnl_left_head
            // 
            this.pnl_left_head.Controls.Add(this.toolStrip);
            this.pnl_left_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_left_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_left_head.Name = "pnl_left_head";
            this.pnl_left_head.Size = new System.Drawing.Size(334, 34);
            this.pnl_left_head.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripComboBox1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(334, 34);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(236, 34);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.pnl_btns);
            this.pnl_main.Controls.Add(this.splitter1);
            this.pnl_main.Controls.Add(this.pnl_left);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(886, 445);
            this.pnl_main.TabIndex = 1;
            // 
            // pnl_btns
            // 
            this.pnl_btns.Controls.Add(this.button2);
            this.pnl_btns.Controls.Add(this.button1);
            this.pnl_btns.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_btns.Location = new System.Drawing.Point(344, 0);
            this.pnl_btns.Name = "pnl_btns";
            this.pnl_btns.Size = new System.Drawing.Size(143, 445);
            this.pnl_btns.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "プル";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "プッシュ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(334, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 445);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(886, 445);
            this.Controls.Add(this.pnl_main);
            this.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinimumSize = new System.Drawing.Size(904, 492);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_left.ResumeLayout(false);
            this.pnl_left_fill.ResumeLayout(false);
            this.pnl_left_head.ResumeLayout(false);
            this.pnl_left_head.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.pnl_btns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_left_head;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.Panel pnl_left_fill;
        private System.Windows.Forms.ImageList imageList;
        private TreeViewMS.TreeViewMS treeView;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnl_btns;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

