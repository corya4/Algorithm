using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_REF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TRANSE_Click(object sender, EventArgs e)
        {
            int r = 0;
            int g = 0;
            int b = 0;
            long t = (1 << 8) - 1;
            Console.WriteLine("byte = " + t);

            long loValue = 0;
            try
            {

                loValue = Convert.ToInt64(txt_cValue.Text, 10);
                Console.WriteLine("Color Value = " + loValue);

                r = (int)((loValue & (t)));
                Console.WriteLine("BLUE = " + b);

                loValue = loValue >> 8;
                g = (int)((loValue & (t)));
                Console.WriteLine("GREEN = " + g);

                loValue = loValue >> 8;
                b = (int)((loValue & (t)));
                Console.WriteLine("RED = " + r);

                Console.WriteLine();
                pnl_paint.BackColor = Color.FromArgb(r, g, b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
