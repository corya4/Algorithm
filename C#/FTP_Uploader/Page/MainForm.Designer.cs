namespace FTP_Uploader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LocalTable = new System.Windows.Forms.DataGridView();
            this.local_col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local_col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local_col_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HostTable = new System.Windows.Forms.DataGridView();
            this.host_col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host_col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.host_col_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.LocalPath = new System.Windows.Forms.ToolStripComboBox();
            this.LocalBar = new System.Windows.Forms.ToolStrip();
            this.lbl_error = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.LocalBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.hostToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(53, 34);
            this.connectionToolStripMenuItem.Text = "接続";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // hostToolStripMenuItem
            // 
            this.hostToolStripMenuItem.Name = "hostToolStripMenuItem";
            this.hostToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.hostToolStripMenuItem.Text = "ホスト";
            this.hostToolStripMenuItem.Click += new System.EventHandler(this.hostToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LocalTable);
            this.panel1.Controls.Add(this.LocalBar);
            this.panel1.Location = new System.Drawing.Point(8, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 355);
            this.panel1.TabIndex = 1;
            // 
            // LocalTable
            // 
            this.LocalTable.AllowUserToAddRows = false;
            this.LocalTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.LocalTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.LocalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.local_col_name,
            this.local_col_date,
            this.local_col_size});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocalTable.DefaultCellStyle = dataGridViewCellStyle11;
            this.LocalTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalTable.EnableHeadersVisualStyles = false;
            this.LocalTable.Location = new System.Drawing.Point(0, 28);
            this.LocalTable.Name = "LocalTable";
            this.LocalTable.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LocalTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.LocalTable.RowHeadersVisible = false;
            this.LocalTable.RowHeadersWidth = 51;
            this.LocalTable.RowTemplate.Height = 24;
            this.LocalTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LocalTable.Size = new System.Drawing.Size(510, 323);
            this.LocalTable.TabIndex = 1;
            this.LocalTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LocalTable_CellDoubleClick);
            // 
            // local_col_name
            // 
            this.local_col_name.HeaderText = "名前";
            this.local_col_name.MinimumWidth = 6;
            this.local_col_name.Name = "local_col_name";
            this.local_col_name.ReadOnly = true;
            this.local_col_name.Width = 196;
            // 
            // local_col_date
            // 
            this.local_col_date.HeaderText = "日付";
            this.local_col_date.MinimumWidth = 6;
            this.local_col_date.Name = "local_col_date";
            this.local_col_date.ReadOnly = true;
            this.local_col_date.Width = 125;
            // 
            // local_col_size
            // 
            this.local_col_size.HeaderText = "サイズ";
            this.local_col_size.MinimumWidth = 6;
            this.local_col_size.Name = "local_col_size";
            this.local_col_size.ReadOnly = true;
            this.local_col_size.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.HostTable);
            this.panel2.Location = new System.Drawing.Point(528, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 417);
            this.panel2.TabIndex = 2;
            // 
            // HostTable
            // 
            this.HostTable.AllowUserToAddRows = false;
            this.HostTable.BackgroundColor = System.Drawing.SystemColors.Window;
            this.HostTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HostTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HostTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.host_col_name,
            this.host_col_date,
            this.host_col_size});
            this.HostTable.Location = new System.Drawing.Point(-2, 0);
            this.HostTable.Name = "HostTable";
            this.HostTable.ReadOnly = true;
            this.HostTable.RowHeadersVisible = false;
            this.HostTable.RowHeadersWidth = 51;
            this.HostTable.RowTemplate.Height = 24;
            this.HostTable.Size = new System.Drawing.Size(449, 415);
            this.HostTable.TabIndex = 0;
            // 
            // host_col_name
            // 
            this.host_col_name.HeaderText = "名前";
            this.host_col_name.MinimumWidth = 6;
            this.host_col_name.Name = "host_col_name";
            this.host_col_name.ReadOnly = true;
            this.host_col_name.Width = 138;
            // 
            // host_col_date
            // 
            this.host_col_date.HeaderText = "日付";
            this.host_col_date.MinimumWidth = 6;
            this.host_col_date.Name = "host_col_date";
            this.host_col_date.ReadOnly = true;
            this.host_col_date.Width = 125;
            // 
            // host_col_size
            // 
            this.host_col_size.HeaderText = "サイズ";
            this.host_col_size.MinimumWidth = 6;
            this.host_col_size.Name = "host_col_size";
            this.host_col_size.ReadOnly = true;
            this.host_col_size.Width = 120;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.richTextBox1);
            this.panel3.Location = new System.Drawing.Point(8, 392);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 146);
            this.panel3.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(0, -2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 146);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "伝　　　　　　　送";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // LocalPath
            // 
            this.LocalPath.Name = "LocalPath";
            this.LocalPath.Size = new System.Drawing.Size(288, 28);
            // 
            // LocalBar
            // 
            this.LocalBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.LocalBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.LocalPath,
            this.toolStripButton3});
            this.LocalBar.Location = new System.Drawing.Point(0, 0);
            this.LocalBar.Name = "LocalBar";
            this.LocalBar.Size = new System.Drawing.Size(510, 28);
            this.LocalBar.TabIndex = 0;
            this.LocalBar.Text = "toolStrip1";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(547, 464);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 19);
            this.lbl_error.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1012, 552);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocalTable)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HostTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.LocalBar.ResumeLayout(false);
            this.LocalBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView LocalTable;
        private System.Windows.Forms.DataGridView HostTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn local_col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn local_col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn local_col_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn host_col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn host_col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn host_col_size;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip LocalBar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripComboBox LocalPath;
        private System.Windows.Forms.Label lbl_error;
    }
}

