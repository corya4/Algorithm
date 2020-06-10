namespace mem_hkj
{
    partial class IOMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripStu = new System.Windows.Forms.StatusStrip();
            this.lblStu = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.StripStu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.signMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeFormMenuItem,
            this.toolStripSeparator1,
            this.exitToolMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(81, 20);
            this.fileMenu.Text = "ファイル(&F)";
            // 
            // addToolMenuItem
            // 
            this.addToolMenuItem.Name = "addToolMenuItem";
            this.addToolMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addToolMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addToolMenuItem.Text = "新規作成(&N)";
            this.addToolMenuItem.Click += new System.EventHandler(this.addToolMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveToolStripMenuItem.Text = "上書き保存(&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openToolStripMenuItem.Text = "開く(&O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeFormMenuItem
            // 
            this.closeFormMenuItem.Name = "closeFormMenuItem";
            this.closeFormMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeFormMenuItem.Text = "閉める(&C)";
            this.closeFormMenuItem.Click += new System.EventHandler(this.closeSubFormMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolMenuItem
            // 
            this.exitToolMenuItem.Name = "exitToolMenuItem";
            this.exitToolMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolMenuItem.Text = "終了(&X)";
            this.exitToolMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // signMenu
            // 
            this.signMenu.Checked = true;
            this.signMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.signMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusToolMenuItem});
            this.signMenu.Name = "signMenu";
            this.signMenu.Size = new System.Drawing.Size(59, 20);
            this.signMenu.Text = "表示(&V)";
            // 
            // statusToolMenuItem
            // 
            this.statusToolMenuItem.Checked = true;
            this.statusToolMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusToolMenuItem.Name = "statusToolMenuItem";
            this.statusToolMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.statusToolMenuItem.Size = new System.Drawing.Size(210, 22);
            this.statusToolMenuItem.Text = "ステータスバー(&T)";
            this.statusToolMenuItem.Click += new System.EventHandler(this.statusToolMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報ToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(72, 20);
            this.helpMenu.Text = "ヘルプ(&H)";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            this.バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            this.バージョン情報ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報ToolStripMenuItem.Click += new System.EventHandler(this.versionDataMenuItem_Click);
            // 
            // StripStu
            // 
            this.StripStu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStu,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.StripStu.Location = new System.Drawing.Point(0, 478);
            this.StripStu.Name = "StripStu";
            this.StripStu.Size = new System.Drawing.Size(734, 22);
            this.StripStu.TabIndex = 2;
            this.StripStu.Text = "statusStrip1";
            // 
            // lblStu
            // 
            this.lblStu.Name = "lblStu";
            this.lblStu.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // IOMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 500);
            this.Controls.Add(this.StripStu);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IOMainForm";
            this.Text = "ウィンドウズフォーム課題「洪基正」";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressCmdKey);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.StripStu.ResumeLayout(false);
            this.StripStu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolMenuItem;
        public System.Windows.Forms.ToolStripMenuItem closeFormMenuItem; //public 修正
        private System.Windows.Forms.ToolStripMenuItem exitToolMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signMenu;
        private System.Windows.Forms.ToolStripMenuItem statusToolMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.StatusStrip StripStu;
        public System.Windows.Forms.ToolStripStatusLabel lblStu;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

