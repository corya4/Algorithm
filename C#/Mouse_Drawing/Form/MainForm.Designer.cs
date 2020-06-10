namespace Drawing_hkj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_shape = new System.Windows.Forms.Label();
            this.cbx_shape = new System.Windows.Forms.ComboBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_fill = new System.Windows.Forms.Label();
            this.chx_fill = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lbl_line_1 = new System.Windows.Forms.Label();
            this.btn_draw = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.lbl_font = new System.Windows.Forms.Label();
            this.txt_font = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_input = new System.Windows.Forms.Button();
            this.lbl_line_2 = new System.Windows.Forms.Label();
            this.btn_preview = new System.Windows.Forms.Button();
            this.stateScript = new System.Windows.Forms.StatusStrip();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.pnl_paper = new System.Windows.Forms.Panel();
            this.ptb = new System.Windows.Forms.Panel();
            this.pnl_color = new System.Windows.Forms.Panel();
            this.printPreviewer = new System.Windows.Forms.PrintPreviewDialog();
            this.printPage = new System.Drawing.Printing.PrintDocument();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbx_elas = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.xmlBox = new System.Windows.Forms.GroupBox();
            this.xmlList = new System.Windows.Forms.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRead = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pnl_paper.SuspendLayout();
            this.xmlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmlList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_shape
            // 
            this.lbl_shape.AutoSize = true;
            this.lbl_shape.Location = new System.Drawing.Point(51, 30);
            this.lbl_shape.Name = "lbl_shape";
            this.lbl_shape.Size = new System.Drawing.Size(53, 12);
            this.lbl_shape.TabIndex = 0;
            this.lbl_shape.Text = "図形種類";
            // 
            // cbx_shape
            // 
            this.cbx_shape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_shape.FormattingEnabled = true;
            this.cbx_shape.Items.AddRange(new object[] {
            "線",
            "三角",
            "四角",
            "円"});
            this.cbx_shape.Location = new System.Drawing.Point(137, 30);
            this.cbx_shape.Name = "cbx_shape";
            this.cbx_shape.Size = new System.Drawing.Size(81, 20);
            this.cbx_shape.TabIndex = 1;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(87, 65);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(17, 12);
            this.lbl_color.TabIndex = 2;
            this.lbl_color.Text = "色";
            // 
            // lbl_fill
            // 
            this.lbl_fill.AutoSize = true;
            this.lbl_fill.Location = new System.Drawing.Point(46, 93);
            this.lbl_fill.Name = "lbl_fill";
            this.lbl_fill.Size = new System.Drawing.Size(58, 12);
            this.lbl_fill.TabIndex = 3;
            this.lbl_fill.Text = "塗りつぶし";
            // 
            // chx_fill
            // 
            this.chx_fill.AutoSize = true;
            this.chx_fill.Location = new System.Drawing.Point(137, 91);
            this.chx_fill.Name = "chx_fill";
            this.chx_fill.Size = new System.Drawing.Size(15, 14);
            this.chx_fill.TabIndex = 4;
            this.chx_fill.UseVisualStyleBackColor = true;
            // 
            // lbl_line_1
            // 
            this.lbl_line_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_line_1.Location = new System.Drawing.Point(20, 169);
            this.lbl_line_1.MaximumSize = new System.Drawing.Size(0, 2);
            this.lbl_line_1.Name = "lbl_line_1";
            this.lbl_line_1.Size = new System.Drawing.Size(0, 2);
            this.lbl_line_1.TabIndex = 5;
            // 
            // btn_draw
            // 
            this.btn_draw.Location = new System.Drawing.Point(89, 132);
            this.btn_draw.Name = "btn_draw";
            this.btn_draw.Size = new System.Drawing.Size(96, 18);
            this.btn_draw.TabIndex = 6;
            this.btn_draw.Text = "図形描画";
            this.btn_draw.UseVisualStyleBackColor = true;
            this.btn_draw.Click += new System.EventHandler(this.DrawShape);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(60, 210);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(44, 12);
            this.lbl_text.TabIndex = 7;
            this.lbl_text.Text = "テキスト";
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(137, 207);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(178, 19);
            this.txt_text.TabIndex = 8;
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Location = new System.Drawing.Point(60, 252);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(42, 12);
            this.lbl_font.TabIndex = 9;
            this.lbl_font.Text = "フォント";
            // 
            // txt_font
            // 
            this.txt_font.Location = new System.Drawing.Point(137, 252);
            this.txt_font.Name = "txt_font";
            this.txt_font.ReadOnly = true;
            this.txt_font.Size = new System.Drawing.Size(95, 19);
            this.txt_font.TabIndex = 10;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(257, 252);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(58, 19);
            this.btn_select.TabIndex = 11;
            this.btn_select.Text = "設定";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.SelectFont);
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(137, 297);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(95, 19);
            this.btn_input.TabIndex = 12;
            this.btn_input.Text = "ﾃｷｽﾄ作成";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.DrawShape);
            // 
            // lbl_line_2
            // 
            this.lbl_line_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_line_2.Location = new System.Drawing.Point(23, 328);
            this.lbl_line_2.MaximumSize = new System.Drawing.Size(0, 2);
            this.lbl_line_2.Name = "lbl_line_2";
            this.lbl_line_2.Size = new System.Drawing.Size(0, 2);
            this.lbl_line_2.TabIndex = 13;
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(89, 370);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(95, 19);
            this.btn_preview.TabIndex = 14;
            this.btn_preview.Text = "印刷プレビュー";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.Previewer);
            // 
            // stateScript
            // 
            this.stateScript.Location = new System.Drawing.Point(0, 472);
            this.stateScript.Name = "stateScript";
            this.stateScript.Size = new System.Drawing.Size(1386, 22);
            this.stateScript.TabIndex = 15;
            this.stateScript.Text = "statusStrip1";
            // 
            // pnl_paper
            // 
            this.pnl_paper.AutoScroll = true;
            this.pnl_paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_paper.Controls.Add(this.ptb);
            this.pnl_paper.Location = new System.Drawing.Point(416, 54);
            this.pnl_paper.Name = "pnl_paper";
            this.pnl_paper.Size = new System.Drawing.Size(451, 334);
            this.pnl_paper.TabIndex = 16;
            this.pnl_paper.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pnl_paper_Scroll);
            this.pnl_paper.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_paper_Paint);
            this.pnl_paper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetPoint);
            // 
            // ptb
            // 
            this.ptb.AutoSize = true;
            this.ptb.BackColor = System.Drawing.SystemColors.Window;
            this.ptb.Location = new System.Drawing.Point(-1, 1);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(450, 331);
            this.ptb.TabIndex = 0;
            this.ptb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetPoint);
            this.ptb.MouseLeave += new System.EventHandler(this.ptb_MouseLeave);
            this.ptb.MouseHover += new System.EventHandler(this.ptb_MouseHover);
            // 
            // pnl_color
            // 
            this.pnl_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_color.Location = new System.Drawing.Point(137, 65);
            this.pnl_color.Name = "pnl_color";
            this.pnl_color.Size = new System.Drawing.Size(15, 12);
            this.pnl_color.TabIndex = 17;
            this.pnl_color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectColor);
            // 
            // printPreviewer
            // 
            this.printPreviewer.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewer.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewer.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewer.Enabled = true;
            this.printPreviewer.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewer.Icon")));
            this.printPreviewer.Name = "printPreviewer";
            this.printPreviewer.Visible = false;
            // 
            // printPage
            // 
            this.printPage.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.GetPage);
            // 
            // cbx_elas
            // 
            this.cbx_elas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_elas.FormattingEnabled = true;
            this.cbx_elas.Items.AddRange(new object[] {
            "50%",
            "100%",
            "200%"});
            this.cbx_elas.Location = new System.Drawing.Point(440, 414);
            this.cbx_elas.Name = "cbx_elas";
            this.cbx_elas.Size = new System.Drawing.Size(76, 20);
            this.cbx_elas.TabIndex = 18;
            this.cbx_elas.SelectedIndexChanged += new System.EventHandler(this.ElasChange);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(755, 412);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 23);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "XMLアップロード";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // xmlBox
            // 
            this.xmlBox.Controls.Add(this.xmlList);
            this.xmlBox.Location = new System.Drawing.Point(926, 52);
            this.xmlBox.Name = "xmlBox";
            this.xmlBox.Size = new System.Drawing.Size(414, 334);
            this.xmlBox.TabIndex = 21;
            this.xmlBox.TabStop = false;
            this.xmlBox.Text = "XMLファイルリスト";
            // 
            // xmlList
            // 
            this.xmlList.AllowUserToAddRows = false;
            this.xmlList.AllowUserToResizeColumns = false;
            this.xmlList.AllowUserToResizeRows = false;
            this.xmlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xmlList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.xmlList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xmlList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colName,
            this.colRead});
            this.xmlList.Location = new System.Drawing.Point(13, 18);
            this.xmlList.MultiSelect = false;
            this.xmlList.Name = "xmlList";
            this.xmlList.ReadOnly = true;
            this.xmlList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.xmlList.RowHeadersVisible = false;
            this.xmlList.RowTemplate.Height = 21;
            this.xmlList.Size = new System.Drawing.Size(395, 310);
            this.xmlList.TabIndex = 0;
            this.xmlList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.XML_Read);
            // 
            // colNumber
            // 
            this.colNumber.Frozen = true;
            this.colNumber.HeaderText = "番号";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            this.colNumber.Width = 90;
            // 
            // colName
            // 
            this.colName.Frozen = true;
            this.colName.HeaderText = "XMLファイル";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 212;
            // 
            // colRead
            // 
            this.colRead.Frozen = true;
            this.colRead.HeaderText = "読み込み";
            this.colRead.Name = "colRead";
            this.colRead.ReadOnly = true;
            this.colRead.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRead.Width = 90;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(416, 27);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(86, 22);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "Panel Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 494);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.xmlBox);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cbx_elas);
            this.Controls.Add(this.pnl_color);
            this.Controls.Add(this.pnl_paper);
            this.Controls.Add(this.stateScript);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.lbl_line_2);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txt_font);
            this.Controls.Add(this.lbl_font);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_draw);
            this.Controls.Add(this.lbl_line_1);
            this.Controls.Add(this.chx_fill);
            this.Controls.Add(this.lbl_fill);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.cbx_shape);
            this.Controls.Add(this.lbl_shape);
            this.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Drawing課題「洪基正」";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_paper.ResumeLayout(false);
            this.pnl_paper.PerformLayout();
            this.xmlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xmlList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_shape;
        private System.Windows.Forms.ComboBox cbx_shape;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_fill;
        private System.Windows.Forms.CheckBox chx_fill;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lbl_line_1;
        private System.Windows.Forms.Button btn_draw;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Label lbl_font;
        private System.Windows.Forms.TextBox txt_font;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Label lbl_line_2;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.StatusStrip stateScript;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Panel pnl_paper;
        private System.Windows.Forms.Panel pnl_color;
        private System.Windows.Forms.PrintPreviewDialog printPreviewer;
        private System.Drawing.Printing.PrintDocument printPage;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbx_elas;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel ptb;
        private System.Windows.Forms.GroupBox xmlBox;
        private System.Windows.Forms.DataGridView xmlList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewButtonColumn colRead;
        private System.Windows.Forms.Button btn_clear;
    }
}

