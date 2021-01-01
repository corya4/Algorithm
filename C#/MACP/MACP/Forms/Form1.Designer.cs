namespace MACP
{
    partial class Form1
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
            this.MacroViewer = new System.Windows.Forms.DataGridView();
            this.Macr = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MacroViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // MacroViewer
            // 
            this.MacroViewer.BackgroundColor = System.Drawing.SystemColors.Window;
            this.MacroViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MacroViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MacroViewer.ColumnHeadersVisible = false;
            this.MacroViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Macr});
            this.MacroViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MacroViewer.Location = new System.Drawing.Point(0, 36);
            this.MacroViewer.Name = "MacroViewer";
            this.MacroViewer.ReadOnly = true;
            this.MacroViewer.RowHeadersVisible = false;
            this.MacroViewer.RowTemplate.Height = 23;
            this.MacroViewer.Size = new System.Drawing.Size(258, 264);
            this.MacroViewer.TabIndex = 0;
            this.MacroViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MacroViewer_CellClick);
            // 
            // Macr
            // 
            this.Macr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Macr.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Macr.HeaderText = "";
            this.Macr.Name = "Macr";
            this.Macr.ReadOnly = true;
            this.Macr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 300);
            this.Controls.Add(this.MacroViewer);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "KM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClose);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.MacroViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MacroViewer;
        private System.Windows.Forms.DataGridViewButtonColumn Macr;
    }
}

