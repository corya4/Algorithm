namespace C_REF
{
    partial class Form1
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
            this.pnl_paint = new System.Windows.Forms.Panel();
            this.txt_cValue = new System.Windows.Forms.TextBox();
            this.btn_TRANSE = new System.Windows.Forms.Button();
            this.lbl_TEXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_paint
            // 
            this.pnl_paint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_paint.Location = new System.Drawing.Point(12, 12);
            this.pnl_paint.Name = "pnl_paint";
            this.pnl_paint.Size = new System.Drawing.Size(518, 275);
            this.pnl_paint.TabIndex = 0;
            // 
            // txt_cValue
            // 
            this.txt_cValue.Location = new System.Drawing.Point(136, 327);
            this.txt_cValue.Name = "txt_cValue";
            this.txt_cValue.Size = new System.Drawing.Size(187, 22);
            this.txt_cValue.TabIndex = 1;
            // 
            // btn_TRANSE
            // 
            this.btn_TRANSE.Location = new System.Drawing.Point(329, 327);
            this.btn_TRANSE.Name = "btn_TRANSE";
            this.btn_TRANSE.Size = new System.Drawing.Size(65, 22);
            this.btn_TRANSE.TabIndex = 2;
            this.btn_TRANSE.Text = "button1";
            this.btn_TRANSE.UseVisualStyleBackColor = true;
            this.btn_TRANSE.Click += new System.EventHandler(this.btn_TRANSE_Click);
            // 
            // lbl_TEXT
            // 
            this.lbl_TEXT.AutoSize = true;
            this.lbl_TEXT.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TEXT.Location = new System.Drawing.Point(168, 300);
            this.lbl_TEXT.Name = "lbl_TEXT";
            this.lbl_TEXT.Size = new System.Drawing.Size(221, 19);
            this.lbl_TEXT.TabIndex = 3;
            this.lbl_TEXT.Text = "Plz input Color Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 371);
            this.Controls.Add(this.lbl_TEXT);
            this.Controls.Add(this.btn_TRANSE);
            this.Controls.Add(this.txt_cValue);
            this.Controls.Add(this.pnl_paint);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "COLORREF Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_paint;
        private System.Windows.Forms.TextBox txt_cValue;
        private System.Windows.Forms.Button btn_TRANSE;
        private System.Windows.Forms.Label lbl_TEXT;
    }
}

