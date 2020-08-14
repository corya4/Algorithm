using MainFrame.Forms;
using MainFrame.Properties;
using mem_hkj;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame.Sources
{
    class FileUpload
    {
        MainForm main;
        HostData data;
        List<String> files;
        List<String> errorFiles;

        StringBuilder PrintLog { get; set; }

        Process p;

        public FileUpload(MainForm main, HostData data, List<String> list)
        {
            this.main = main;
            this.data = data;
            files = list;
            errorFiles = new List<String>();
            PrintLog = new StringBuilder();

            ProcessIni();
        }

        public void ProcessIni()
        {
            p = new Process();

            p.StartInfo.FileName = "ftp";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;

        }

        public void _FTPConnect()
        {
            p.Start();

            p.StandardInput.WriteLine(Resources.OPEN + data.IP);
            p.StandardInput.WriteLine(data.ID);
            p.StandardInput.WriteLine(data.PW);
            p.StandardInput.WriteLine(Resources.CD + data.UploadPath);


        }

        private void _CreateMoveFolder(String folder)
        {
            p.StandardInput.WriteLine(Resources.MKDIR + folder);
            p.StandardInput.WriteLine(Resources.CD + folder);

        }

        private String _LogString()
        {
            p.StandardInput.Close();
            return p.StandardOutput.ReadToEnd();
            

        }

        public void _CloseProcess()
        {
            p.WaitForExit();
            p.Close();
        }

        public void _ConnectHost()
        {
            ProcessIni();
            _FTPConnect();
        }

        public bool _ErrorMessage()
        {
            String tmpLog = _LogString();
            String[] logs = tmpLog.Split('\n');

            StringBuilder connect_error = new StringBuilder();
            StringBuilder trance_error = new StringBuilder();

            int fail_state = 0;

            foreach (String log in logs)
            {

                if (log.Contains(Resources.HOST_UNKNOWN))
                {
                    connect_error.Append("不明なIPです。" + "\n");
                }
                else if (log.Contains(Resources.LOGIN_INCORRECT))
                {
                    connect_error.Append("アカウントをご確認ください。" + "\n");
                }
                else if (log.Contains(Resources.PATH_FAILD))
                {
                    connect_error.Append("パス移動ができません。" + "\n");
                }
                else if (log.Contains(Resources.FILE_NOTFOUND))
                {
                    //LOG_Write
                    if(fail_state == 0)
                    {
                        PrintLog.Append("\n" + "Fail List : " + "\n");
                    }

                    PrintLog.Append(Log_Time() + Resources.FAIL + log + "\n");
                    trance_error.Append(log + "\n");

                    fail_state++;
                }
                else if(log.Contains(Resources.EXIST_DIRECTORY))
                {
                    MessageBoxEx.Show(main, "すでに" + FullPath + "が存在します。", Resources.ERROR, MessageBoxButtons.OK);
                    return false;
                }

            }

            if(connect_error.Length > 1)
            {
                MessageBoxEx.Show(main, Resources.HOST_CONNECT_ERROR + connect_error.ToString(), Resources.ERROR, MessageBoxButtons.OK);
                return false;
            }
            
            if(trance_error.Length > 1)
            {
                MessageBoxEx.Show(main, trance_error.ToString(), Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Warning) ;
            }

            return true;

        }

        String FullPath;

        public bool Uploader(String folder)
        {
            _FTPConnect();
            _CreateMoveFolder(folder);

            FullPath = data.UploadPath + Path.AltDirectorySeparatorChar + folder;


            //LOG Writhe
            PrintLog.Append(Log_Time() + "Start FTP " + "\n");
            PrintLog.Append(Log_Time() + "Connect Host : " + data.IP + "\n");
            PrintLog.Append(Log_Time() + "Upload Path  : " + data.UploadPath + "\n");
            PrintLog.Append(Log_Time() + "Create Folder : " + folder + "\n");
            PrintLog.Append(Log_Time() + "Send Result >> " + "\n");

            foreach (String file in files)
            {
                p.StandardInput.WriteLine(Resources.PUT + file);
                //LOG Write
                PrintLog.Append(Log_Time() + "Send File : " + file + FileSize(file) + "\n");
            }

            bool result = _ErrorMessage();
            
             p.StandardOutput.Close();
            _CloseProcess();
            //LOG Write
            PrintLog.Append(Log_Time() + "Close FTP " + "\n");
            main.logs= PrintLog;

            if(data.LogWrited.Equals(Resources.TRUE)) _CreateLogFile();

            return result;
        }

        private void _CreateLogFile()
        {

            StreamWriter sw = null;
            try
            {
                sw = File.AppendText(data.LogFilePath);
                sw.Write(PrintLog.ToString());
                sw.WriteLine();
            }
            catch (Exception e)
            {
                MessageBoxEx.Show(main, "ログファイルが生成できませんでした。パスをご確認ください。", "パスエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if(sw != null) sw.Close();

            }
        }

        private String FileSize(String file)
        {
            FileInfo info = new FileInfo(file);

            return null;
        }

        private String Log_Time()
        {
            return "["+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ff") + "] " ;
        }

    }
}







