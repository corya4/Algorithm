using MainFrame.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame.Sources
{
    class DataSort : System.Collections.IComparer
    {
        bool NAME;
        int FJS;
        int FJM;
        int TXT;


        public DataSort(bool f, int i1, int i2, int i3)
        {
            NAME = f;
            FJS = i1;
            FJM = i2;
            TXT = i3;
        }

        int IComparer.Compare(object x, object y)
        {
            DataGridViewRow r1 = x as DataGridViewRow;
            DataGridViewRow r2 = y as DataGridViewRow;

            String f1 = r1.Cells[0].Value.ToString();
            String f2 = r2.Cells[0].Value.ToString();

            if (NAME)
            {

                String n1 = Path.GetFileName(f1);
                String n2 = Path.GetFileName(f2);

                return n1.CompareTo(n2);

            }
            else
            {

                String ex1 = Path.GetExtension(f1);
                String ex2 = Path.GetExtension(f2);

                int e1 = ex1.Equals(Resources.EXT_FJS) ? FJS : ex1.Equals(Resources.EXT_FJM) ? FJM : TXT;
                int e2 = ex2.Equals(Resources.EXT_FJS) ? FJS : ex2.Equals(Resources.EXT_FJM) ? FJM : TXT;

                return e2 - e1;
            }

        }
    }
}
