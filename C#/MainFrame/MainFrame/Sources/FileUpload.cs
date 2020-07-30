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

        FtpWebRequest request;

        public FileUpload(MainForm main, HostData data, List<String> list)
        {
            this.main = main;
            confirm = data;
            files = list;
        }

        public void Uploader(String folder, HostData hostData)
        {
            request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}{1}/{2}", hostData.IP, hostData.UploadPath, folder))) as FtpWebRequest;
            request.Credentials = new NetworkCredential(hostData.ID, hostData.PW);
            request.Method = WebRequestMethods.Ftp.MakeDirectory;

            try
            {
                WebResponse reps = request.GetResponse();
                reps.Close();
            }
            catch(Exception e)
            {
                main.strip_status.Text = "フォルダ生成中にエラーが発生しました";
                return;
            }


            foreach (String file in files)
            {
                if(!FtpUpload(hostData, folder, file))
                {
                    return;
                }

            }//Loop end

            main.strip_status.Text = "伝送が完了しました";
        }

        private bool FtpUpload(HostData hostData, String folder, String file)
        {

            Stream streamRequest = null;

            try
            {
                request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}{1}/{2}/{3}", hostData.IP, hostData.UploadPath, folder, Path.GetFileName(file)))) as FtpWebRequest;
                request.Credentials = new NetworkCredential(hostData.ID, hostData.PW);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                streamRequest = request.GetRequestStream();

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
                    MessageBoxEx.Show(main, "ホストアカウントをご確認してください", "接続エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBoxEx.Show(main, "ホストアドレス(IP)をご確認してください","接続エラー",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }


            FileStream fs = File.OpenRead(file);
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

    }
}
