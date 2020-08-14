using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame.Forms
{
    public partial class LogForm : Form
    {
        //delegate void AppendEvent(String str);
        String[] log_Content;

        public LogForm(StringBuilder logString)
        {
            InitializeComponent();
            rtb_log.Text = logString.ToString();
            log_Content = logString.ToString().Split('\n');
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
