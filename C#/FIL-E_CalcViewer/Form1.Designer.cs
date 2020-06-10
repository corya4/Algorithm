namespace FIL_E_CalcViewer
{
    partial class FIL_E_CACLVIEWER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIL_E_CACLVIEWER));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEquipment = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblHighLow = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRight_fill = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txbFilesValue = new System.Windows.Forms.RichTextBox();
            this.pnlRight_bot = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlLeft_fill = new System.Windows.Forms.Panel();
            this.btnRate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProcessing = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDiff = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.rbxLow = new System.Windows.Forms.RadioButton();
            this.rbxHigh = new System.Windows.Forms.RadioButton();
            this.cbxUnit = new System.Windows.Forms.ComboBox();
            this.cbxEquipment = new System.Windows.Forms.ComboBox();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.pnlLeft_bot = new System.Windows.Forms.Panel();
            this.btnFileView = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.METADATA = new System.Windows.Forms.Label();
            this.pnlRight.SuspendLayout();
            this.pnlRight_fill.SuspendLayout();
            this.pnlRight_bot.SuspendLayout();
            this.pnlLeft_fill.SuspendLayout();
            this.pnlLeft_bot.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitle.Location = new System.Drawing.Point(24, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FIL-E処理時間演算画面";
            // 
            // lblEquipment
            // 
            this.lblEquipment.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblEquipment.Location = new System.Drawing.Point(25, 83);
            this.lblEquipment.Name = "lblEquipment";
            this.lblEquipment.Size = new System.Drawing.Size(209, 22);
            this.lblEquipment.TabIndex = 1;
            this.lblEquipment.Text = "装　置　名　* 　　　　　：";
            // 
            // lblUnit
            // 
            this.lblUnit.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUnit.Location = new System.Drawing.Point(25, 118);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(198, 23);
            this.lblUnit.TabIndex = 2;
            this.lblUnit.Text = "処理ユニット  *　　  　　：";
            // 
            // lblInitial
            // 
            this.lblInitial.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInitial.Location = new System.Drawing.Point(25, 185);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(198, 24);
            this.lblInitial.TabIndex = 3;
            this.lblInitial.Text = "InitialTHK  *　 　　　　 ：";
            // 
            // lblHighLow
            // 
            this.lblHighLow.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHighLow.Location = new System.Drawing.Point(25, 153);
            this.lblHighLow.Name = "lblHighLow";
            this.lblHighLow.Size = new System.Drawing.Size(198, 23);
            this.lblHighLow.TabIndex = 4;
            this.lblHighLow.Text = "High or Low *           ：";
            // 
            // lblTarget
            // 
            this.lblTarget.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTarget.Location = new System.Drawing.Point(25, 222);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(198, 26);
            this.lblTarget.TabIndex = 5;
            this.lblTarget.Text = "狙い膜厚  * 　　　　　　：";
            // 
            // lblDiff
            // 
            this.lblDiff.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDiff.Location = new System.Drawing.Point(25, 263);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(209, 28);
            this.lblDiff.TabIndex = 6;
            this.lblDiff.Text = "差分値(オプション)  　  ：";
            // 
            // lblRate
            // 
            this.lblRate.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRate.Location = new System.Drawing.Point(25, 301);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(209, 29);
            this.lblRate.TabIndex = 7;
            this.lblRate.Text = "RATE(オプション)　　　 ：";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Red;
            this.pnlRight.Controls.Add(this.pnlRight_fill);
            this.pnlRight.Controls.Add(this.pnlRight_bot);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(462, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(575, 524);
            this.pnlRight.TabIndex = 8;
            // 
            // pnlRight_fill
            // 
            this.pnlRight_fill.BackColor = System.Drawing.Color.White;
            this.pnlRight_fill.Controls.Add(this.lblFileName);
            this.pnlRight_fill.Controls.Add(this.txbFilesValue);
            this.pnlRight_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight_fill.Location = new System.Drawing.Point(0, 0);
            this.pnlRight_fill.Name = "pnlRight_fill";
            this.pnlRight_fill.Size = new System.Drawing.Size(575, 447);
            this.pnlRight_fill.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFileName.Location = new System.Drawing.Point(19, 23);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(266, 28);
            this.lblFileName.TabIndex = 24;
            this.lblFileName.Text = "-";
            // 
            // txbFilesValue
            // 
            this.txbFilesValue.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txbFilesValue.Location = new System.Drawing.Point(23, 72);
            this.txbFilesValue.Name = "txbFilesValue";
            this.txbFilesValue.Size = new System.Drawing.Size(528, 356);
            this.txbFilesValue.TabIndex = 0;
            this.txbFilesValue.Text = "";
            // 
            // pnlRight_bot
            // 
            this.pnlRight_bot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlRight_bot.Controls.Add(this.btnClose);
            this.pnlRight_bot.Controls.Add(this.btnLoad);
            this.pnlRight_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRight_bot.Location = new System.Drawing.Point(0, 447);
            this.pnlRight_bot.Name = "pnlRight_bot";
            this.pnlRight_bot.Size = new System.Drawing.Size(575, 77);
            this.pnlRight_bot.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(118, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoad.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLoad.Location = new System.Drawing.Point(324, 21);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(141, 34);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "保存";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlLeft_fill
            // 
            this.pnlLeft_fill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlLeft_fill.Controls.Add(this.METADATA);
            this.pnlLeft_fill.Controls.Add(this.btnRate);
            this.pnlLeft_fill.Controls.Add(this.label5);
            this.pnlLeft_fill.Controls.Add(this.label4);
            this.pnlLeft_fill.Controls.Add(this.label3);
            this.pnlLeft_fill.Controls.Add(this.label2);
            this.pnlLeft_fill.Controls.Add(this.label1);
            this.pnlLeft_fill.Controls.Add(this.txtProcessing);
            this.pnlLeft_fill.Controls.Add(this.txtRate);
            this.pnlLeft_fill.Controls.Add(this.txtDiff);
            this.pnlLeft_fill.Controls.Add(this.txtTarget);
            this.pnlLeft_fill.Controls.Add(this.txtInitial);
            this.pnlLeft_fill.Controls.Add(this.rbxLow);
            this.pnlLeft_fill.Controls.Add(this.rbxHigh);
            this.pnlLeft_fill.Controls.Add(this.cbxUnit);
            this.pnlLeft_fill.Controls.Add(this.cbxEquipment);
            this.pnlLeft_fill.Controls.Add(this.lblProcessing);
            this.pnlLeft_fill.Controls.Add(this.lblTitle);
            this.pnlLeft_fill.Controls.Add(this.lblEquipment);
            this.pnlLeft_fill.Controls.Add(this.lblRate);
            this.pnlLeft_fill.Controls.Add(this.lblUnit);
            this.pnlLeft_fill.Controls.Add(this.lblDiff);
            this.pnlLeft_fill.Controls.Add(this.lblInitial);
            this.pnlLeft_fill.Controls.Add(this.lblTarget);
            this.pnlLeft_fill.Controls.Add(this.lblHighLow);
            this.pnlLeft_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft_fill.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft_fill.Name = "pnlLeft_fill";
            this.pnlLeft_fill.Size = new System.Drawing.Size(462, 447);
            this.pnlLeft_fill.TabIndex = 9;
            // 
            // btnRate
            // 
            this.btnRate.BackgroundImage = global::FIL_E_CalcViewer.Properties.Resources.file_121247;
            this.btnRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRate.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnRate.Location = new System.Drawing.Point(416, 293);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(30, 31);
            this.btnRate.TabIndex = 23;
            this.btnRate.UseVisualStyleBackColor = false;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(340, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "sec";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(340, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "nm";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(340, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "nm";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(340, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "nm/sec";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(340, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "nm";
            // 
            // txtProcessing
            // 
            this.txtProcessing.BackColor = System.Drawing.SystemColors.Menu;
            this.txtProcessing.Location = new System.Drawing.Point(240, 387);
            this.txtProcessing.Name = "txtProcessing";
            this.txtProcessing.ReadOnly = true;
            this.txtProcessing.Size = new System.Drawing.Size(94, 22);
            this.txtProcessing.TabIndex = 17;
            this.txtProcessing.TabStop = false;
            this.txtProcessing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(240, 301);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(94, 22);
            this.txtRate.TabIndex = 16;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtDiff
            // 
            this.txtDiff.Location = new System.Drawing.Point(240, 263);
            this.txtDiff.Name = "txtDiff";
            this.txtDiff.Size = new System.Drawing.Size(94, 22);
            this.txtDiff.TabIndex = 15;
            this.txtDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(240, 226);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(94, 22);
            this.txtTarget.TabIndex = 14;
            this.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtInitial
            // 
            this.txtInitial.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtInitial.Location = new System.Drawing.Point(240, 187);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(94, 22);
            this.txtInitial.TabIndex = 13;
            this.txtInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // rbxLow
            // 
            this.rbxLow.Location = new System.Drawing.Point(323, 158);
            this.rbxLow.Name = "rbxLow";
            this.rbxLow.Size = new System.Drawing.Size(58, 24);
            this.rbxLow.TabIndex = 12;
            this.rbxLow.Text = "Low";
            this.rbxLow.UseVisualStyleBackColor = true;
            // 
            // rbxHigh
            // 
            this.rbxHigh.Checked = true;
            this.rbxHigh.Location = new System.Drawing.Point(240, 157);
            this.rbxHigh.Name = "rbxHigh";
            this.rbxHigh.Size = new System.Drawing.Size(77, 24);
            this.rbxHigh.TabIndex = 11;
            this.rbxHigh.TabStop = true;
            this.rbxHigh.Text = "High";
            this.rbxHigh.UseVisualStyleBackColor = true;
            // 
            // cbxUnit
            // 
            this.cbxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnit.FormattingEnabled = true;
            this.cbxUnit.Items.AddRange(new object[] {
            "P1",
            "P2"});
            this.cbxUnit.Location = new System.Drawing.Point(240, 117);
            this.cbxUnit.Name = "cbxUnit";
            this.cbxUnit.Size = new System.Drawing.Size(121, 23);
            this.cbxUnit.TabIndex = 10;
            // 
            // cbxEquipment
            // 
            this.cbxEquipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEquipment.FormattingEnabled = true;
            this.cbxEquipment.Items.AddRange(new object[] {
            "UV12G55",
            "UN85G58",
            "UV12G60"});
            this.cbxEquipment.Location = new System.Drawing.Point(240, 82);
            this.cbxEquipment.Name = "cbxEquipment";
            this.cbxEquipment.Size = new System.Drawing.Size(121, 23);
            this.cbxEquipment.TabIndex = 9;
            // 
            // lblProcessing
            // 
            this.lblProcessing.Location = new System.Drawing.Point(25, 390);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(198, 25);
            this.lblProcessing.TabIndex = 8;
            this.lblProcessing.Text = "処理時間　　　  　　　　　 ：";
            // 
            // pnlLeft_bot
            // 
            this.pnlLeft_bot.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlLeft_bot.Controls.Add(this.btnFileView);
            this.pnlLeft_bot.Controls.Add(this.btnCalc);
            this.pnlLeft_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLeft_bot.Location = new System.Drawing.Point(0, 447);
            this.pnlLeft_bot.Name = "pnlLeft_bot";
            this.pnlLeft_bot.Size = new System.Drawing.Size(462, 77);
            this.pnlLeft_bot.TabIndex = 10;
            // 
            // btnFileView
            // 
            this.btnFileView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFileView.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnFileView.Location = new System.Drawing.Point(58, 21);
            this.btnFileView.Name = "btnFileView";
            this.btnFileView.Size = new System.Drawing.Size(141, 34);
            this.btnFileView.TabIndex = 1;
            this.btnFileView.Text = "ファイルView";
            this.btnFileView.UseVisualStyleBackColor = false;
            this.btnFileView.Click += new System.EventHandler(this.btnFileView_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCalc.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCalc.Location = new System.Drawing.Point(264, 21);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(141, 34);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "演算";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlLeft_fill);
            this.pnlLeft.Controls.Add(this.pnlLeft_bot);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(462, 524);
            this.pnlLeft.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "file_121247.png");
            // 
            // METADATA
            // 
            this.METADATA.AutoSize = true;
            this.METADATA.Font = new System.Drawing.Font("MS UI Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.METADATA.ForeColor = System.Drawing.Color.Red;
            this.METADATA.Location = new System.Drawing.Point(39, 330);
            this.METADATA.Name = "METADATA";
            this.METADATA.Size = new System.Drawing.Size(73, 12);
            this.METADATA.TabIndex = 24;
            this.METADATA.Text = "*は必須です。";
            // 
            // FIL_E_CACLVIEWER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 524);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Name = "FIL_E_CACLVIEWER";
            this.Text = "FIL_E_CalcViewer";
            this.Load += new System.EventHandler(this.FIL_E_CalcViewer_Load);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight_fill.ResumeLayout(false);
            this.pnlRight_bot.ResumeLayout(false);
            this.pnlLeft_fill.ResumeLayout(false);
            this.pnlLeft_fill.PerformLayout();
            this.pnlLeft_bot.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEquipment;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblHighLow;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlRight_fill;
        private System.Windows.Forms.Panel pnlRight_bot;
        private System.Windows.Forms.Panel pnlLeft_fill;
        private System.Windows.Forms.Panel pnlLeft_bot;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.ComboBox cbxEquipment;
        private System.Windows.Forms.RadioButton rbxHigh;
        private System.Windows.Forms.RadioButton rbxLow;
        private System.Windows.Forms.TextBox txtProcessing;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDiff;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.Button btnFileView;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.RichTextBox txbFilesValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label METADATA;
    }
}

