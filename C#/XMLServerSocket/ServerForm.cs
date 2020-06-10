using Drawing_hkj.SCU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLServerSocket
{
    public partial class ServerForm : Form
    {
        bool state = false;
        Thread thread;
        ServerSocket server;

        public ServerForm()
        {
            InitializeComponent();

        }

        private void ThreadRun()
        {
           server = new ServerSocket();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            state = !state;
            if (state)
            {
                lblState.Text = "通信　ON ";
                thread = new Thread(ThreadRun);
                thread.Start();
            }
            else
            {
                lblState.Text = "通信　OFF ";
                thread.Abort();
                server.server.Close();
                server = null;
            }

            
        }
    }
}
