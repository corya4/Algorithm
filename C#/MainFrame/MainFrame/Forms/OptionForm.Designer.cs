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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.grb_local = new System.Windows.Forms.GroupBox();
            this.cbx_logWrite = new System.Windows.Forms.CheckBox();
            this.btn_LogDialog = new System.Windows.Forms.Button();
            this.txt_LogPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.txt_id.TabIndex = 1;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(147, 105);
            this.txt_pw.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.PasswordChar = '●';
            this.txt_pw.Size = new System.Drawing.Size(166, 22);
            this.txt_pw.TabIndex = 2;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(147, 26);
            this.txt_ip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(166, 22);
            this.txt_ip.TabIndex = 0;
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
            this.btn_OK.Location = new System.Drawing.Point(66, 352);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(141, 33);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // btn_CANCEL
            // 
            this.btn_CANCEL.Location = new System.Drawing.Point(215, 352);
            this.btn_CANCEL.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CANCEL.Name = "btn_CANCEL";
            this.btn_CANCEL.Size = new System.Drawing.Size(145, 33);
            this.btn_CANCEL.TabIndex = 8;
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
            this.grb_host.Controls.Add(this.label1);
            this.grb_host.Controls.Add(this.txt_port);
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
            this.grb_host.Size = new System.Drawing.Size(339, 183);
            this.grb_host.TabIndex = 2;
            this.grb_host.TabStop = false;
            this.grb_host.Text = "HOST";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "ポート番号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(147, 187);
            this.txt_port.Margin = new System.Windows.Forms.Padding(4);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(166, 22);
            this.txt_port.TabIndex = 4;
            this.txt_port.Visible = false;
            // 
            // grb_local
            // 
            this.grb_local.Controls.Add(this.cbx_logWrite);
            this.grb_local.Controls.Add(this.btn_LogDialog);
            this.grb_local.Controls.Add(this.txt_LogPath);
            this.grb_local.Controls.Add(this.label2);
            this.grb_local.Controls.Add(this.btn_OpenDialog);
            this.grb_local.Controls.Add(this.txt_localPath);
            this.grb_local.Controls.Add(this.lbl_localPath);
            this.grb_local.Location = new System.Drawing.Point(21, 199);
            this.grb_local.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_local.Name = "grb_local";
            this.grb_local.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_local.Size = new System.Drawing.Size(339, 147);
            this.grb_local.TabIndex = 11;
            this.grb_local.TabStop = false;
            this.grb_local.Text = "LOCAL";
            // 
            // cbx_logWrite
            // 
            this.cbx_logWrite.Location = new System.Drawing.Point(211, 86);
            this.cbx_logWrite.Name = "cbx_logWrite";
            this.cbx_logWrite.Size = new System.Drawing.Size(122, 17);
            this.cbx_logWrite.TabIndex = 11;
            this.cbx_logWrite.Text = "ファイル作成";
            this.cbx_logWrite.UseVisualStyleBackColor = true;
            this.cbx_logWrite.CheckedChanged += new System.EventHandler(this.cbx_logWrite_CheckStateChanged);
            this.cbx_logWrite.CheckStateChanged += new System.EventHandler(this.cbx_logWrite_CheckStateChanged);
            // 
            // btn_LogDialog
            // 
            this.btn_LogDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LogDialog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LogDialog.BackgroundImage")));
            this.btn_LogDialog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LogDialog.Enabled = false;
            this.btn_LogDialog.Location = new System.Drawing.Point(283, 108);
            this.btn_LogDialog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LogDialog.Name = "btn_LogDialog";
            this.btn_LogDialog.Size = new System.Drawing.Size(35, 25);
            this.btn_LogDialog.TabIndex = 9;
            this.btn_LogDialog.UseVisualStyleBackColor = false;
            this.btn_LogDialog.Click += new System.EventHandler(this.btn_LogDialog_Click);
            // 
            // txt_LogPath
            // 
            this.txt_LogPath.Enabled = false;
            this.txt_LogPath.Location = new System.Drawing.Point(15, 110);
            this.txt_LogPath.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LogPath.Name = "txt_LogPath";
            this.txt_LogPath.Size = new System.Drawing.Size(264, 22);
            this.txt_LogPath.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "ログファイル";
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
            this.btn_OpenDialog.TabIndex = 6;
            this.btn_OpenDialog.UseVisualStyleBackColor = false;
            this.btn_OpenDialog.Click += new System.EventHandler(this.FolderDialog_OPen_Click);
            // 
            // txt_localPath
            // 
            this.txt_localPath.Location = new System.Drawing.Point(15, 44);
            this.txt_localPath.Margin = new System.Windows.Forms.Padding(4);
            this.txt_localPath.Name = "txt_localPath";
            this.txt_localPath.Size = new System.Drawing.Size(264, 22);
            this.txt_localPath.TabIndex = 5;
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
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(380, 404);
            this.Controls.Add(this.grb_local);
            this.Controls.Add(this.grb_host);
            this.Controls.Add(this.btn_CANCEL);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(398, 451);
            this.MinimumSize = new System.Drawing.Size(398, 451);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_LogDialog;
        private System.Windows.Forms.TextBox txt_LogPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbx_logWrite;
    }
}