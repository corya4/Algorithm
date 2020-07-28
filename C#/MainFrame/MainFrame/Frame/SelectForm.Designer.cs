namespace MainFrame.Frame
{
    partial class SelectForm
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
            this.lbl_text = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_ext = new System.Windows.Forms.Label();
            this.pnl_radio = new System.Windows.Forms.Panel();
            this.lbl_folder = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_button = new System.Windows.Forms.Panel();
            this.pnl_radio.SuspendLayout();
            this.pnl_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_text.Location = new System.Drawing.Point(111, 9);
            this.lbl_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(301, 25);
            this.lbl_text.TabIndex = 0;
            this.lbl_text.Text = "に重複あります。一つを選んでください";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(162, 4);
            this.btn_select.Margin = new System.Windows.Forms.Padding(4);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(130, 27);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "選　択";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(312, 4);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 27);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "キャンセル";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_ext
            // 
            this.lbl_ext.AutoSize = true;
            this.lbl_ext.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ext.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_ext.Location = new System.Drawing.Point(25, 9);
            this.lbl_ext.Name = "lbl_ext";
            this.lbl_ext.Size = new System.Drawing.Size(0, 25);
            this.lbl_ext.TabIndex = 4;
            // 
            // pnl_radio
            // 
            this.pnl_radio.Controls.Add(this.lbl_folder);
            this.pnl_radio.Controls.Add(this.lbl_ext);
            this.pnl_radio.Controls.Add(this.lbl_name);
            this.pnl_radio.Controls.Add(this.lbl_text);
            this.pnl_radio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_radio.Location = new System.Drawing.Point(0, 0);
            this.pnl_radio.Name = "pnl_radio";
            this.pnl_radio.Size = new System.Drawing.Size(449, 135);
            this.pnl_radio.TabIndex = 5;
            // 
            // lbl_folder
            // 
            this.lbl_folder.AutoSize = true;
            this.lbl_folder.Location = new System.Drawing.Point(186, 55);
            this.lbl_folder.Name = "lbl_folder";
            this.lbl_folder.Size = new System.Drawing.Size(75, 22);
            this.lbl_folder.TabIndex = 1;
            this.lbl_folder.Text = "フォルダ名";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(51, 55);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(74, 22);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "ファイル名";
            // 
            // pnl_button
            // 
            this.pnl_button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_button.Controls.Add(this.btn_select);
            this.pnl_button.Controls.Add(this.btn_cancel);
            this.pnl_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_button.Location = new System.Drawing.Point(0, 135);
            this.pnl_button.Name = "pnl_button";
            this.pnl_button.Size = new System.Drawing.Size(449, 35);
            this.pnl_button.TabIndex = 6;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(449, 170);
            this.Controls.Add(this.pnl_radio);
            this.Controls.Add(this.pnl_button);
            this.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(467, 379);
            this.Name = "SelectForm";
            this.pnl_radio.ResumeLayout(false);
            this.pnl_radio.PerformLayout();
            this.pnl_button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_ext;
        private System.Windows.Forms.Panel pnl_radio;
        private System.Windows.Forms.Label lbl_folder;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel pnl_button;
    }
}