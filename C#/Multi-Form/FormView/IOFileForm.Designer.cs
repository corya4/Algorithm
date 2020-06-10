namespace mem_hkj
{
    partial class IOFileForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbxBasic = new System.Windows.Forms.GroupBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.gbxAddData = new System.Windows.Forms.GroupBox();
            this.cmbxDay = new System.Windows.Forms.ComboBox();
            this.rbxLeft = new System.Windows.Forms.RadioButton();
            this.rbxRight = new System.Windows.Forms.RadioButton();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.lblEngNum = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.txtNumEng = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblPullDown = new System.Windows.Forms.Label();
            this.btn_inset = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gbxBasic.SuspendLayout();
            this.gbxAddData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBasic
            // 
            this.gbxBasic.Controls.Add(this.txtText);
            this.gbxBasic.Controls.Add(this.txtSerial);
            this.gbxBasic.Controls.Add(this.lblText);
            this.gbxBasic.Controls.Add(this.lblSerial);
            this.gbxBasic.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxBasic.Location = new System.Drawing.Point(5, 5);
            this.gbxBasic.Name = "gbxBasic";
            this.gbxBasic.Size = new System.Drawing.Size(415, 72);
            this.gbxBasic.TabIndex = 0;
            this.gbxBasic.TabStop = false;
            this.gbxBasic.Text = "基本情報";
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.Location = new System.Drawing.Point(145, 44);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(214, 22);
            this.txtText.TabIndex = 1;
            this.txtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subFormKeyPress);
            // 
            // txtSerial
            // 
            this.txtSerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerial.Location = new System.Drawing.Point(145, 15);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(214, 22);
            this.txtSerial.TabIndex = 3;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(31, 47);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(63, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "テキスト";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(31, 18);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(77, 13);
            this.lblSerial.TabIndex = 1;
            this.lblSerial.Text = "ページ番号";
            // 
            // gbxAddData
            // 
            this.gbxAddData.Controls.Add(this.cmbxDay);
            this.gbxAddData.Controls.Add(this.rbxLeft);
            this.gbxAddData.Controls.Add(this.rbxRight);
            this.gbxAddData.Controls.Add(this.cbx3);
            this.gbxAddData.Controls.Add(this.cbx2);
            this.gbxAddData.Controls.Add(this.cbx1);
            this.gbxAddData.Controls.Add(this.lblEngNum);
            this.gbxAddData.Controls.Add(this.lblNumber);
            this.gbxAddData.Controls.Add(this.lblCheck);
            this.gbxAddData.Controls.Add(this.txtNumEng);
            this.gbxAddData.Controls.Add(this.txtNum);
            this.gbxAddData.Controls.Add(this.lblRadio);
            this.gbxAddData.Controls.Add(this.lblPullDown);
            this.gbxAddData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxAddData.Location = new System.Drawing.Point(5, 77);
            this.gbxAddData.Name = "gbxAddData";
            this.gbxAddData.Size = new System.Drawing.Size(415, 171);
            this.gbxAddData.TabIndex = 1;
            this.gbxAddData.TabStop = false;
            this.gbxAddData.Text = "追加情報";
            // 
            // cmbxDay
            // 
            this.cmbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDay.FormattingEnabled = true;
            this.cmbxDay.Items.AddRange(new object[] {
            "1番目",
            "2番目",
            "3番目",
            "4番目",
            "5番目",
            "6番目",
            "7番目",
            "8番目",
            "9番目",
            "10番目"});
            this.cmbxDay.Location = new System.Drawing.Point(145, 15);
            this.cmbxDay.Name = "cmbxDay";
            this.cmbxDay.Size = new System.Drawing.Size(84, 21);
            this.cmbxDay.TabIndex = 12;
            // 
            // rbxLeft
            // 
            this.rbxLeft.AutoSize = true;
            this.rbxLeft.Location = new System.Drawing.Point(190, 47);
            this.rbxLeft.Name = "rbxLeft";
            this.rbxLeft.Size = new System.Drawing.Size(39, 17);
            this.rbxLeft.TabIndex = 11;
            this.rbxLeft.Text = "左";
            this.rbxLeft.UseVisualStyleBackColor = true;
            // 
            // rbxRight
            // 
            this.rbxRight.AutoSize = true;
            this.rbxRight.Checked = true;
            this.rbxRight.Location = new System.Drawing.Point(145, 47);
            this.rbxRight.Name = "rbxRight";
            this.rbxRight.Size = new System.Drawing.Size(39, 17);
            this.rbxRight.TabIndex = 10;
            this.rbxRight.TabStop = true;
            this.rbxRight.Text = "右";
            this.rbxRight.UseVisualStyleBackColor = true;
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.Font = new System.Drawing.Font("궁서체", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbx3.Location = new System.Drawing.Point(145, 77);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(78, 15);
            this.cbx3.TabIndex = 9;
            this.cbx3.Text = "チェック1";
            this.cbx3.UseVisualStyleBackColor = true;
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Font = new System.Drawing.Font("궁서체", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbx2.Location = new System.Drawing.Point(229, 77);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(78, 15);
            this.cbx2.TabIndex = 8;
            this.cbx2.Text = "チェック2";
            this.cbx2.UseVisualStyleBackColor = true;
            // 
            // cbx1
            // 
            this.cbx1.Font = new System.Drawing.Font("궁서체", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbx1.Location = new System.Drawing.Point(313, 72);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(78, 20);
            this.cbx1.TabIndex = 7;
            this.cbx1.Text = "チェック3";
            this.cbx1.UseVisualStyleBackColor = true;
            // 
            // lblEngNum
            // 
            this.lblEngNum.AutoSize = true;
            this.lblEngNum.Location = new System.Drawing.Point(31, 137);
            this.lblEngNum.Name = "lblEngNum";
            this.lblEngNum.Size = new System.Drawing.Size(77, 13);
            this.lblEngNum.TabIndex = 6;
            this.lblEngNum.Text = "英数字入力";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(31, 108);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(63, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "数字入力";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(31, 79);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(63, 13);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "チェック";
            // 
            // txtNumEng
            // 
            this.txtNumEng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumEng.Location = new System.Drawing.Point(145, 134);
            this.txtNumEng.Name = "txtNumEng";
            this.txtNumEng.Size = new System.Drawing.Size(214, 22);
            this.txtNumEng.TabIndex = 1;
            this.txtNumEng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subFormKeyPress);
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.txtNum.Location = new System.Drawing.Point(145, 105);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(214, 22);
            this.txtNum.TabIndex = 3;
            this.txtNum.TextChanged += new System.EventHandler(this.numLenghChanged);
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.subFormKeyPress);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(31, 47);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(49, 13);
            this.lblRadio.TabIndex = 2;
            this.lblRadio.Text = "ラジオ";
            // 
            // lblPullDown
            // 
            this.lblPullDown.AutoSize = true;
            this.lblPullDown.Location = new System.Drawing.Point(31, 18);
            this.lblPullDown.Name = "lblPullDown";
            this.lblPullDown.Size = new System.Drawing.Size(77, 13);
            this.lblPullDown.TabIndex = 1;
            this.lblPullDown.Text = "プルダウン";
            // 
            // btn_inset
            // 
            this.btn_inset.Location = new System.Drawing.Point(74, 254);
            this.btn_inset.Name = "btn_inset";
            this.btn_inset.Size = new System.Drawing.Size(115, 22);
            this.btn_inset.TabIndex = 2;
            this.btn_inset.Text = "適用";
            this.btn_inset.UseVisualStyleBackColor = true;
            this.btn_inset.Click += new System.EventHandler(this.btn_inset_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(234, 254);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 22);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "閉める";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // IOFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 293);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_inset);
            this.Controls.Add(this.gbxAddData);
            this.Controls.Add(this.gbxBasic);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("궁서체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KeyPreview = true;
            this.Name = "IOFileForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubForm_FormClosing);
            this.gbxBasic.ResumeLayout(false);
            this.gbxBasic.PerformLayout();
            this.gbxAddData.ResumeLayout(false);
            this.gbxAddData.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.GroupBox gbxBasic;
        public System.Windows.Forms.TextBox txtText;
        public System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblSerial;
        public System.Windows.Forms.GroupBox gbxAddData;
        public System.Windows.Forms.CheckBox cbx3;
        public System.Windows.Forms.CheckBox cbx2;
        public System.Windows.Forms.CheckBox cbx1;
        private System.Windows.Forms.Label lblEngNum;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCheck;
        public System.Windows.Forms.TextBox txtNumEng;
        public System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblPullDown;
        public System.Windows.Forms.ComboBox cmbxDay;
        public System.Windows.Forms.RadioButton rbxLeft;
        public System.Windows.Forms.RadioButton rbxRight;
        private System.Windows.Forms.Button btn_inset;
        private System.Windows.Forms.Button btn_cancel;
    }
}



