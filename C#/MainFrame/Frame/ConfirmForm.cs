using MainFrame.Sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame.Frame
{
    public partial class ConfirmForm : Form
    {

        HostData hostData;

        public ConfirmForm(HostData data)
        {
            InitializeComponent();
            hostData = data;
        }

    }
}
