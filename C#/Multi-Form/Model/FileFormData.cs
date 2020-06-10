using mem_hkj.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using mem_hkj.BL;

namespace mem_hkj.Model
{
    /*
     * File値DAO_Class
     */
    public class FileFormData
    {
        public String serial { get; set; }
        public String contents { get; set; }
        public String pulldown { get; set; }
        public String direction { get; set; }
        public String check { get; set; }
        public String number { get; set; }
        public String engnum { get; set; }
        public int color { get; set; } //StateValue
        public bool selected { get; set; } //checkBox_selected
       
    }
}
