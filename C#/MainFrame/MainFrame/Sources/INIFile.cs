using MainFrame.Sources;
using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                GetPrivateProfileString("STARTPATH", "LOAD", "", sb, sb.Capacity, ini_path);
            }
            catch (Exception e)
            {
                File.Create(ini_path);
            }
            return sb;
        }

        public static void WriteIniFile(String lastPath)
        {
            WritePrivateProfileString("STARTPATH", "LOAD", lastPath, ini_path);
        }


        public static StringBuilder ReadIniHost(HostData host, StringBuilder sb)
        {
            try
            {
                GetPrivateProfileString("HOSTDATA", "IP", "", sb, sb.Capacity, ini_path);
                host.IP = sb.ToString();
                GetPrivateProfileString("HOSTDATA", "HOSTPATH", "", sb, sb.Capacity, ini_path);
                host.UploadPath = sb.ToString();
                GetPrivateProfileString("HOSTDATA", "ID", "", sb, sb.Capacity, ini_path);
                host.ID = sb.ToString();
                GetPrivateProfileString("HOSTDATA", "PW", "", sb, sb.Capacity, ini_path);
                host.PW = sb.ToString();

            }
            catch (Exception e)
            {
                
            }

            return sb;

        }

        public static void WriteIniHost(HostData datas)
        {

            try
            {
                WritePrivateProfileString("HOSTDATA", "IP", datas.IP, ini_path);
                WritePrivateProfileString("HOSTDATA", "HOSTPATH", datas.UploadPath, ini_path);
                WritePrivateProfileString("HOSTDATA", "ID", datas.ID, ini_path);
                WritePrivateProfileString("HOSTDATA", "PW", datas.PW, ini_path);

            } catch (Exception e)
            {
                Console.WriteLine("HostData == 74 : ERROR");
            }
        }


        public static void ReadInCreateFolderName(StringBuilder sb, String fjm_path)
        {
            GetPrivateProfileString("HEADER", "TPNO", "", sb, sb.Capacity, fjm_path);
        }

    }
}
