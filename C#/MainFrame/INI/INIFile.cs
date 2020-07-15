using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame.INI
{
    public static class INIFile
    {

        static String ini_path = Application.StartupPath + "\\" + "path.ini";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(String section, String key, String val, String filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(String section, String key, String def, StringBuilder retVal, int size, String filePath);

        public static StringBuilder ReadIniFile(StringBuilder sb)
        {
            GetPrivateProfileString("STARTPATH", "LOAD", "", sb, sb.Capacity, ini_path);
            return sb;
        }

        public static void WriteIniFile(String lastPath)
        {
            WritePrivateProfileString("STARTPATH","LOAD", lastPath, ini_path);
        }

    }
}
