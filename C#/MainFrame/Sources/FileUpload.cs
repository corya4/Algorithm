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
        FtpWebRequest request;

        public FileUpload(HostData data, List<String> list)
        {
            confirm = data;
            files = list;
        }

        public void Uploader()
        {
            // confirm data use
            String tmpDir = "TestUpload";
            //

           // request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}/{1}", "172.16.23.60", tmpDir))) as FtpWebRequest;
           // request.Method = WebRequestMethods.Ftp.MakeDirectory;
            

            foreach (String file in files)
            {
                FtpUpload(tmpDir, file);

            }//Loop end
        }

        private void FtpUpload(String fileDir, String file)
        {
            Console.WriteLine(file);
            //request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}/{1}/{2}", "172.16.23.60", fileDir, Path.GetFileName(file)))) as FtpWebRequest;
            request = WebRequest.Create(new Uri(String.Format(@"ftp://{0}:21/{1}", "localhost", Path.GetFileName(file)))) as FtpWebRequest;
            request.Credentials = new NetworkCredential("corya4", "dlftla-312");
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
