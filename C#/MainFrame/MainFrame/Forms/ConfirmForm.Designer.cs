namespace MainFrame.Frame
{
    partial class ConfirmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmForm));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_CANCEL = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_host = new System.Windows.Forms.Label();
            this.grb_host = new System.Windows.Forms.GroupBox();
            this.grb_local = new System.Windows.Forms.GroupBox();
            this.btn_OpenDialog = new System.Windows.Forms.Button();
            this.txt_localPath = new System.Windows.Forms.TextBox();
            this.lbl_localPath = new System.Windows.Forms.Label();
            this.grb_host.SuspendLayout();
            this.grb_local.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(147, 66);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(166, 22);
            this.txt_id.TabIndex = 0;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(147, 105);
            this.txt_pw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(166, 22);
            this.txt_pw.TabIndex = 1;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(147, 26);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(166, 22);
            this.txt_ip.TabIndex = 2;
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(147, 146);
            this.txt_host.Margin = new System.Windows.Forms.Padding(4);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(166, 22);
            this.txt_host.TabIndex = 3;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(66, 294);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(141, 33);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // btn_CANCEL
            // 
            this.btn_CANCEL.Location = new System.Drawing.Point(215, 294);
            this.btn_CANCEL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CANCEL.Name = "btn_CANCEL";
            this.btn_CANCEL.Size = new System.Drawing.Size(145, 33);
            this.btn_CANCEL.TabIndex = 5;
            this.btn_CANCEL.Text = "キャンセル";
            this.btn_CANCEL.UseVisualStyleBackColor = true;
            this.btn_CANCEL.Click += new System.EventHandler(this.CANCEL_button_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.Location = new System.Drawing.Point(42, 66);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(80, 20);
            this.lbl_id.TabIndex = 6;
            this.lbl_id.Text = "ユーザー名";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_pw
            // 
            this.lbl_pw.Location = new System.Drawing.Point(21, 110);
            this.lbl_pw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(101, 17);
            this.lbl_pw.TabIndex = 7;
            this.lbl_pw.Text = "パスワード";
            this.lbl_pw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ip
            // 
            this.lbl_ip.Location = new System.Drawing.Point(7, 29);
            this.lbl_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(115, 19);
            this.lbl_ip.TabIndex = 8;
            this.lbl_ip.Text = "ホスト名(アドレス)";
            this.lbl_ip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_host
            // 
            this.lbl_host.Location = new System.Drawing.Point(21, 146);
            this.lbl_host.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(101, 20);
            this.lbl_host.TabIndex = 9;
            this.lbl_host.Text = "アプロードパス";
            this.lbl_host.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grb_host
            // 
            this.grb_host.Controls.Add(this.lbl_host);
            this.grb_host.Controls.Add(this.lbl_pw);
            this.grb_host.Controls.Add(this.lbl_ip);
            this.grb_host.Controls.Add(this.txt_pw);
            this.grb_host.Controls.Add(this.lbl_id);
            this.grb_host.Controls.Add(this.txt_host);
            this.grb_host.Controls.Add(this.txt_ip);
            this.grb_host.Controls.Add(this.txt_id);
            this.grb_host.Location = new System.Drawing.Point(21, 12);
            this.grb_host.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_host.Name = "grb_host";
            this.grb_host.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_host.Size = new System.Drawing.Size(339, 190);
            this.grb_host.TabIndex = 10;
            this.grb_host.TabStop = false;
            this.grb_host.Text = "HOST";
            // 
            // grb_local
            // 
            this.grb_local.Controls.Add(this.btn_OpenDialog);
            this.grb_local.Controls.Add(this.txt_localPath);
            this.grb_local.Controls.Add(this.lbl_localPath);
            this.grb_local.Location = new System.Drawing.Point(21, 206);
            this.grb_local.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_local.Name = "grb_local";
            this.grb_local.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_local.Size = new System.Drawing.Size(339, 82);
            this.grb_local.TabIndex = 11;
            this.grb_local.TabStop = false;
            this.grb_local.Text = "LOCAL";
            // 
            // btn_OpenDialog
            // 
            this.btn_OpenDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btn_OpenDialog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_OpenDialog.BackgroundImage")));
            this.btn_OpenDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_OpenDialog.Location = new System.Drawing.Point(283, 42);
            this.btn_OpenDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_OpenDialog.Name = "btn_OpenDialog";
            this.btn_OpenDialog.Size = new System.Drawing.Size(35, 25);
            this.btn_OpenDialog.TabIndex = 11;
            this.btn_OpenDialog.UseVisualStyleBackColor = false;
            this.btn_OpenDialog.Click += new System.EventHandler(this.FolderDialog_OPen_Click);
            // 
            // txt_localPath
            // 
            this.txt_localPath.Location = new System.Drawing.Point(15, 44);
            this.txt_localPath.Margin = new System.Windows.Forms.Padding(4);
            this.txt_localPath.Name = "txt_localPath";
            this.txt_localPath.Size = new System.Drawing.Size(264, 22);
            this.txt_localPath.TabIndex = 10;
            // 
            // lbl_localPath
            // 
            this.lbl_localPath.AutoSize = true;
            this.lbl_localPath.Location = new System.Drawing.Point(13, 22);
            this.lbl_localPath.Name = "lbl_localPath";
            this.lbl_localPath.Size = new System.Drawing.Size(121, 15);
            this.lbl_localPath.TabIndex = 0;
            this.lbl_localPath.Text = "初期ディレクトリパス";
            // 
            // ConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(380, 340);
            this.Controls.Add(this.grb_local);
            this.Controls.Add(this.grb_host);
            this.Controls.Add(this.btn_CANCEL);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ConfirmForm";
            this.ShowIcon = false;
            this.Text = "ホスト設定";
            this.Load += new System.EventHandler(this.ConfirmForm_Load);
            this.grb_host.ResumeLayout(false);
            this.grb_host.PerformLayout();
            this.grb_local.ResumeLayout(false);
            this.grb_local.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_CANCEL;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.GroupBox grb_host;
        private System.Windows.Forms.GroupBox grb_local;
        private System.Windows.Forms.TextBox txt_localPath;
        private System.Windows.Forms.Label lbl_localPath;
        private System.Windows.Forms.Button btn_OpenDialog;
    }
}