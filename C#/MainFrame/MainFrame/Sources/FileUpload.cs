using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MainFrame.Sources
{


    class FileUpload
    {
        HostData confirm;
        List<String> files;

        public FileUpload(HostData data, List<String> list)
        {
            confirm = data;
            files = list;
        }

        public void Uploader(FtpWebRequest request, HostData hostData)
        {
                        foreach (String file in files)
            {
                FtpUpload(request, hostData, file);

            }//Loop end
        }

        private void FtpUpload(FtpWebRequest request, HostData hostData, String file)
        {

            request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}/{1}/{2}", hostData.IP, hostData.UploadPath, Path.GetFileName(file)))) as FtpWebRequest;
            request.Credentials = new NetworkCredential(hostData.ID, hostData.PW);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            Stream streamRequest = request.GetRequestStream();

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
            
        }

    }
}
