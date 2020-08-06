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


        public static HostData ReadIniHost(StringBuilder sb)
        {
            HostData host = new HostData();

            try
            {
                GetPrivateProfileString("HOSTDATA", "IP", "", sb, sb.Capacity, ini_path);
                host.IP = sb.ToString();

                Crypto cry = new Crypto();
                GetPrivateProfileString("HOSTDATA", "ID", "", sb, sb.Capacity, ini_path);
                String HID = cry.Result(1, sb.ToString());
                host.ID = (HID == null) ? "" : HID;
                GetPrivateProfileString("HOSTDATA", "PW", "", sb, sb.Capacity, ini_path);
                String HPW = cry.Result(1, sb.ToString());
                host.PW = (HPW == null) ? "" : HPW;

                GetPrivateProfileString("HOSTDATA", "HOSTPATH", "", sb, sb.Capacity, ini_path);
                host.UploadPath = sb.ToString();
                GetPrivateProfileString("HOSTDATA", "PORT", "", sb, sb.Capacity, ini_path);
                host.PortNumber = sb.ToString().Equals("") ? "21" : sb.ToString();
                GetPrivateProfileString("HOSTDATA", "LOCALPATH", "", sb, sb.Capacity, ini_path);
                host.LocalPath = sb.ToString().Equals("") ? "" : sb.ToString();

            }
            catch (Exception e)
            {
                Console.WriteLine("INI READ ERROR");
            }

            return host;

        }

        public static void WriteIniHost(HostData datas)
        {

            try
            {
                
                WritePrivateProfileString("HOSTDATA", "IP", datas.IP, ini_path);

                Crypto cry = new Crypto();
                WritePrivateProfileString("HOSTDATA", "ID", datas.ID == null ? "" : cry.Result(0, datas.ID), ini_path);
                WritePrivateProfileString("HOSTDATA", "PW", datas.PW == null ? "" : cry.Result(0, datas.PW), ini_path);
                
                WritePrivateProfileString("HOSTDATA", "HOSTPATH", datas.UploadPath, ini_path);
                WritePrivateProfileString("HOSTDATA", "PORT", datas.PortNumber == null ? "21" : datas.PortNumber, ini_path);
                WritePrivateProfileString("HOSTDATA", "LOCALPATH", datas.LocalPath, ini_path);

                

            } catch (Exception e)
            {
                Console.WriteLine("HostData == 74 : ERROR");
            }
        }



    }


    
}
