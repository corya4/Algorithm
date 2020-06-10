namespace mem_hkj.FormView
{
    partial class IOCsvForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tdb_model = new System.Windows.Forms.DataGridView();
            this.tbl_cbx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbl_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblWork = new System.Windows.Forms.Label();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.btn_rowAdd = new System.Windows.Forms.Button();
            this.btn_rowRemove = new System.Windows.Forms.Button();
            this.btn_rowCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tdb_model)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tdb_model
            // 
            this.tdb_model.AllowUserToAddRows = false;
            this.tdb_model.AllowUserToDeleteRows = false;
            this.tdb_model.AllowUserToResizeColumns = false;
            this.tdb_model.AllowUserToResizeRows = false;
            this.tdb_model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tdb_model.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.tdb_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tdb_model.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tdb_model.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tdb_model.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbl_cbx,
            this.tbl_serial,
            this.tbl_text});
            this.tdb_model.Location = new System.Drawing.Point(42, 49);
            this.tdb_model.Name = "tdb_model";
            this.tdb_model.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tdb_model.RowHeadersVisible = false;
            this.tdb_model.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.tdb_model.RowTemplate.Height = 23;
            this.tdb_model.Size = new System.Drawing.Size(420, 178);
            this.tdb_model.TabIndex = 0;
            this.tdb_model.DoubleClick += new System.EventHandler(this.RowDoubleClickEvent);
            // 
            // tbl_cbx
            // 
            this.tbl_cbx.HeaderText = "";
            this.tbl_cbx.Name = "tbl_cbx";
            this.tbl_cbx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tbl_cbx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tbl_cbx.Width = 35;
            // 
            // tbl_serial
            // 
            this.tbl_serial.HeaderText = "ページ番号";
            this.tbl_serial.Name = "tbl_serial";
            this.tbl_serial.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_serial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tbl_serial.Width = 178;
            // 
            // tbl_text
            // 
            this.tbl_text.HeaderText = "テキスト";
            this.tbl_text.Name = "tbl_text";
            this.tbl_text.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tbl_text.Width = 178;
            // 
            // lblIndex
            // 
            this.lblIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(334, 35);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(17, 12);
            this.lblIndex.TabIndex = 1;
            this.lblIndex.Text = "総";
            // 
            // lblWork
            // 
            this.lblWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblWork.AutoSize = true;
            this.lblWork.Location = new System.Drawing.Point(377, 34);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(21, 12);
            this.lblWork.TabIndex = 2;
            this.lblWork.Text = " 件";
            // 
            // lblRowCount
            // 
            this.lblRowCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(368, 34);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(11, 12);
            this.lblRowCount.TabIndex = 3;
            this.lblRowCount.Text = "0";
            // 
            // btn_rowAdd
            // 
            this.btn_rowAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_rowAdd.Location = new System.Drawing.Point(78, 233);
            this.btn_rowAdd.Name = "btn_rowAdd";
            this.btn_rowAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_rowAdd.TabIndex = 4;
            this.btn_rowAdd.Text = "追加";
            this.btn_rowAdd.UseVisualStyleBackColor = true;
            this.btn_rowAdd.Click += new System.EventHandler(this.btn_rowAdd_Click);
            // 
            // btn_rowRemove
            // 
            this.btn_rowRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_rowRemove.Location = new System.Drawing.Point(203, 233);
            this.btn_rowRemove.Name = "btn_rowRemove";
            this.btn_rowRemove.Size = new System.Drawing.Size(75, 23);
            this.btn_rowRemove.TabIndex = 5;
            this.btn_rowRemove.Text = "削除";
            this.btn_rowRemove.UseVisualStyleBackColor = true;
            this.btn_rowRemove.Click += new System.EventHandler(this.btn_rowRemove_Click);
            // 
            // btn_rowCancel
            // 
            this.btn_rowCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_rowCancel.Location = new System.Drawing.Point(323, 233);
            this.btn_rowCancel.Name = "btn_rowCancel";
            this.btn_rowCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_rowCancel.TabIndex = 6;
            this.btn_rowCancel.Text = "閉める";
            this.btn_rowCancel.UseVisualStyleBackColor = true;
            this.btn_rowCancel.Click += new System.EventHandler(this.btn_rowCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_rowRemove);
            this.panel1.Controls.Add(this.btn_rowAdd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 279);
            this.panel1.TabIndex = 8;
            // 
            // IOCsvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 279);
            this.Controls.Add(this.btn_rowCancel);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.lblWork);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.tdb_model);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "IOCsvForm";
            this.Text = "IOCsvForm";
            this.Activated += new System.EventHandler(this.IOCsvForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IOCsvForm_FormClosing);
            this.Load += new System.EventHandler(this.IOCsvForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tdb_model)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tdb_model;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Button btn_rowAdd;
        private System.Windows.Forms.Button btn_rowRemove;
        private System.Windows.Forms.Button btn_rowCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn tbl_cbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbl_text;
        private System.Windows.Forms.Panel panel1;
    }
}