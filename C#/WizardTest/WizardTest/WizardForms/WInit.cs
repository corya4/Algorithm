using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardTest.WizardForms
{
    public partial class WInit : Form
    {

        int counting = 0;
        private Form1 form;


        public WInit(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;
        }

        private void wizardControl1_NextButtonClicked(object sender, CancelEventArgs e)
        {

            form.Text = Convert.ToString(++counting);
        }

        private void wizardControl1_BackButtonClicked(object sender, CancelEventArgs e)
        {
            form.Text = Convert.ToString(--counting);
        }

        private void wizardControl1_CloseButtonClicked(object sender, CancelEventArgs e)
        {

            form.Text = Convert.ToString((counting = 0));
        }
    }
}
