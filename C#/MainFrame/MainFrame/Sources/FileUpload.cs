using MainFrame.Properties;
using mem_hkj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainFrame.Sources
{
    class FileUpload
    {
        MainForm main;
        HostData confirm;
        List<String> files;
        List<String> errorFiles;

        FtpWebRequest request;

        public FileUpload(MainForm main, HostData data, List<String> list)
        {
            this.main = main;
            confirm = data;
            files = list;
            errorFiles = new List<String>();
        }

        public void Uploader(String folder, HostData hostData)
        {
            
            if(!DirectoryCheck(folder, hostData))
            {
                return;
            }


            foreach (String file in files)
            {
                if(!FtpUpload(hostData, folder, file))
                {
                    return;
                }

            }//Loop end
            
            if(errorFiles.Count > 0)
            {
                MessageBoxEx.Show(main, SetErrorFiles(), Resources.ERROR_NOTSEARCH, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private bool DirectoryCheck(String folder, HostData hostData)
        {

            try
            {
                request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}{1}/{2}", hostData.IP, hostData.UploadPath, folder))) as FtpWebRequest;

                request.Credentials = new NetworkCredential(hostData.ID, hostData.PW);
  
                request.Method = WebRequestMethods.Ftp.MakeDirectory;

                WebResponse reps = request.GetResponse();
                reps.Close();

                Console.WriteLine("Connect");
                return true;
            }
            catch (WebException We)
            {

                if (We.Message.Contains(Resources.NOTLOGIN))
                {
                    MessageBoxEx.Show(main, Resources.SERVER_LOGIN_ERROR, Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBoxEx.Show(main, Resources.HOST_CONNECT_ERROR, Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            catch(UriFormatException Ue)
            {
                MessageBoxEx.Show(main, Resources.HOST_CONNECT_ERROR, Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return false;
        }

        private String SetErrorFiles()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("下記のパイルが見つかりません。"+ '\n');

            foreach(String f in errorFiles)
            {
                sb.Append(f + '\n');
            }

            errorFiles.Clear();
            return sb.ToString();
        }

        private bool FtpUpload(HostData hostData, String folder, String file)
        {

            Stream streamRequest = null;
            FileStream fs = null;

            try
            {
                fs = File.OpenRead(file);

                request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}{1}/{2}/{3}", hostData.IP, hostData.UploadPath, folder, Path.GetFileName(file)))) as FtpWebRequest;
                request.Credentials = new NetworkCredential(hostData.ID, hostData.PW);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                streamRequest = request.GetRequestStream();


                byte[] byteBuffer = new byte[1024];

                while (true)
                {
                    int byteLength = fs.Read(byteBuffer, 0, byteBuffer.Length);

                    if (byteLength == 0) break;

                    streamRequest.Write(byteBuffer, 0, byteLength);
                }

                fs.Close();
                streamRequest.Close();

                return true;



            }
            catch (WebException we)  //パスエラーがあった時、パスをDefaultにする
            {
                String message = we.Message;

                if (message.IndexOf("550") != -1)
                {
                    hostData.UploadPath = "";
                }
                else if (message.IndexOf("530") != -1)
                {
                    MessageBoxEx.Show(main, "ホストアカウントをご確認してください", Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBoxEx.Show(main, "ホストアドレス(IP)をご確認してください", Resources.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;

            }
            catch (IOException ioe)
            {
                errorFiles.Add(file);
                return true;
            }

       
        }

    }
}
