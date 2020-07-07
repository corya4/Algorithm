namespace FTP_Uploader_2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_etc = new System.Windows.Forms.Label();
            this.lbl_fjm = new System.Windows.Forms.Label();
            this.lbl_fjs = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_etc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fjm = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fjs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column = new System.Windows.Forms.DataGridView();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_identity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pathBox = new System.Windows.Forms.ToolStripComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fjm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fjs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_column)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.TreeView);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 480);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_etc);
            this.panel2.Controls.Add(this.lbl_fjm);
            this.panel2.Controls.Add(this.lbl_fjs);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.dgv_etc);
            this.panel2.Controls.Add(this.dgv_fjm);
            this.panel2.Controls.Add(this.dgv_fjs);
            this.panel2.Controls.Add(this.dgv_column);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(228, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 448);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // lbl_etc
            // 
            this.lbl_etc.AutoSize = true;
            this.lbl_etc.Font = new System.Drawing.Font("MS UI Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_etc.Location = new System.Drawing.Point(79, 235);
            this.lbl_etc.Name = "lbl_etc";
            this.lbl_etc.Size = new System.Drawing.Size(30, 12);
            this.lbl_etc.TabIndex = 9;
            this.lbl_etc.Text = "ETC";
            // 
            // lbl_fjm
            // 
            this.lbl_fjm.AutoSize = true;
            this.lbl_fjm.Font = new System.Drawing.Font("MS UI Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_fjm.Location = new System.Drawing.Point(79, 146);
            this.lbl_fjm.Name = "lbl_fjm";
            this.lbl_fjm.Size = new System.Drawing.Size(31, 12);
            this.lbl_fjm.TabIndex = 8;
            this.lbl_fjm.Text = "FJM";
            // 
            // lbl_fjs
            // 
            this.lbl_fjs.AutoSize = true;
            this.lbl_fjs.Font = new System.Drawing.Font("MS UI Gothic", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_fjs.Location = new System.Drawing.Point(79, 64);
            this.lbl_fjs.Name = "lbl_fjs";
            this.lbl_fjs.Size = new System.Drawing.Size(29, 12);
            this.lbl_fjs.TabIndex = 7;
            this.lbl_fjs.Text = "FJS";
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_save.Location = new System.Drawing.Point(0, 416);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(473, 32);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "登　録";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_etc
            // 
            this.dgv_etc.AllowUserToAddRows = false;
            this.dgv_etc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_etc.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_etc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_etc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_etc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_etc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_etc.ColumnHeadersVisible = false;
            this.dgv_etc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dgv_etc.Location = new System.Drawing.Point(82, 250);
            this.dgv_etc.Name = "dgv_etc";
            this.dgv_etc.ReadOnly = true;
            this.dgv_etc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_etc.RowHeadersVisible = false;
            this.dgv_etc.RowHeadersWidth = 51;
            this.dgv_etc.RowTemplate.Height = 21;
            this.dgv_etc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_etc.Size = new System.Drawing.Size(602, 160);
            this.dgv_etc.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "名前";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "日付";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "拡張子";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "サイズ";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 120;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "パース";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 500;
            // 
            // dgv_fjm
            // 
            this.dgv_fjm.AllowUserToAddRows = false;
            this.dgv_fjm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fjm.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_fjm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_fjm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_fjm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_fjm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fjm.ColumnHeadersVisible = false;
            this.dgv_fjm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgv_fjm.Location = new System.Drawing.Point(82, 162);
            this.dgv_fjm.Name = "dgv_fjm";
            this.dgv_fjm.ReadOnly = true;
            this.dgv_fjm.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_fjm.RowHeadersVisible = false;
            this.dgv_fjm.RowHeadersWidth = 51;
            this.dgv_fjm.RowTemplate.Height = 21;
            this.dgv_fjm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fjm.Size = new System.Drawing.Size(602, 63);
            this.dgv_fjm.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "名前";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "日付";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "拡張子";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "サイズ";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "パース";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 500;
            // 
            // dgv_fjs
            // 
            this.dgv_fjs.AllowUserToAddRows = false;
            this.dgv_fjs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_fjs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_fjs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_fjs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_fjs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_fjs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fjs.ColumnHeadersVisible = false;
            this.dgv_fjs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgv_fjs.Location = new System.Drawing.Point(82, 80);
            this.dgv_fjs.Name = "dgv_fjs";
            this.dgv_fjs.ReadOnly = true;
            this.dgv_fjs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_fjs.RowHeadersVisible = false;
            this.dgv_fjs.RowHeadersWidth = 51;
            this.dgv_fjs.RowTemplate.Height = 21;
            this.dgv_fjs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fjs.Size = new System.Drawing.Size(602, 68);
            this.dgv_fjs.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "名前";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "日付";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "拡張子";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "サイズ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "パース";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 500;
            // 
            // dgv_column
            // 
            this.dgv_column.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_column.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_column.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_column.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_column.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_name,
            this.col_date,
            this.col_identity,
            this.col_size,
            this.col_path});
            this.dgv_column.Location = new System.Drawing.Point(81, 16);
            this.dgv_column.Name = "dgv_column";
            this.dgv_column.ReadOnly = true;
            this.dgv_column.RowHeadersVisible = false;
            this.dgv_column.RowHeadersWidth = 51;
            this.dgv_column.RowTemplate.Height = 21;
            this.dgv_column.Size = new System.Drawing.Size(602, 19);
            this.dgv_column.TabIndex = 2;
            // 
            // col_name
            // 
            this.col_name.HeaderText = "名前";
            this.col_name.MinimumWidth = 7;
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_name.Width = 200;
            // 
            // col_date
            // 
            this.col_date.HeaderText = "日付";
            this.col_date.MinimumWidth = 6;
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            this.col_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_date.Width = 150;
            // 
            // col_identity
            // 
            this.col_identity.HeaderText = "拡張子";
            this.col_identity.MinimumWidth = 6;
            this.col_identity.Name = "col_identity";
            this.col_identity.ReadOnly = true;
            this.col_identity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_identity.Width = 120;
            // 
            // col_size
            // 
            this.col_size.HeaderText = "サイズ";
            this.col_size.MinimumWidth = 6;
            this.col_size.Name = "col_size";
            this.col_size.ReadOnly = true;
            this.col_size.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_size.Width = 120;
            // 
            // col_path
            // 
            this.col_path.HeaderText = "パース";
            this.col_path.MinimumWidth = 6;
            this.col_path.Name = "col_path";
            this.col_path.ReadOnly = true;
            this.col_path.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_path.Width = 500;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(223, 32);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 448);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // TreeView
            // 
            this.TreeView.CheckBoxes = true;
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeView.FullRowSelect = true;
            this.TreeView.Location = new System.Drawing.Point(0, 32);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(223, 448);
            this.TreeView.TabIndex = 0;
            this.TreeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterCheck);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.pathBox});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(86, 28);
            this.toolStripMenuItem1.Text = "パース設定";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pathBox
            // 
            this.pathBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pathBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(375, 28);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 480);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(596, 392);
            this.Name = "MainForm";
            this.Text = "FJMAP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fjm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fjs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_column)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView TreeView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_column;
        private System.Windows.Forms.DataGridView dgv_fjs;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_etc;
        private System.Windows.Forms.DataGridView dgv_fjm;
        private System.Windows.Forms.Label lbl_etc;
        private System.Windows.Forms.Label lbl_fjm;
        private System.Windows.Forms.Label lbl_fjs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_identity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_path;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox pathBox;
    }
}

