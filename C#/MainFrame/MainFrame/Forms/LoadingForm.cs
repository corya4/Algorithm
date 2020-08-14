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

namespace MainFrame.Forms
{


    public partial class LoadingForm : Form
    {

        public Action Login { get; set; }
        public Action Message { get; set; }

        public LoadingForm(MainForm main)
        {
            InitializeComponent();
            this.Location = new Point(main.Location.X + (main.Width/2) - (this.Width/2), main.Location.Y + (main.Height/2) - (this.Height/2));
        }


        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            Login?.Invoke();

            this.Invoke((Action)(() =>
            {
                this.Close();
                Message?.Invoke();
            }));

            /*Thread thread = new Thread(
                () =>
                {
                    Login?.Invoke();

                    this.Invoke((Action)(() =>
                    {
                        this.Close();
                        Message?.Invoke();
                    }));
                });
            
            thread.Start();*/
        }

 
    }
}



