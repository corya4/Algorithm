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
        int index;
        List<String> ext;


        public DataSort(int index, List<String> ext)
        {
            Console.WriteLine(index);
            this.index = index;
            this.ext = ext;
        }

        int IComparer.Compare(object x, object y)
        {
            DataGridViewRow r1 = x as DataGridViewRow;
            DataGridViewRow r2 = y as DataGridViewRow;

            String f1 = r1.Cells[0].Value.ToString();
            String f2 = r2.Cells[0].Value.ToString();

            String n1 = Path.GetFileName(f1);
            String n2 = Path.GetFileName(f2);

            if (index == 0)
            {
                return n1.CompareTo(n2);

            }
            else
            {
                String e1 = Path.GetExtension(n1);
                String e2 = Path.GetExtension(n2);

                if(ext.IndexOf(e1) == index && ext.IndexOf(e2) == index)
                {
                    return n1.CompareTo(n2);
                }
                
                else if (ext.IndexOf(e1) == index)
                {
                    return -1;
                }

                else if (ext.IndexOf(e2) == index)
                {
                    return 1;
                }

                else return n1.CompareTo(n2);

            }

        }
    }
}
