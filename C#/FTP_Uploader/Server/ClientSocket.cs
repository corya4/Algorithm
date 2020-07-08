using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FTP_Uploader_2.Server
{
    class ClientSocket
    {

        public Thread loader;

        //Upload socket
        public Socket socket;
        //UploadFile
        public List<FileInfo> uploadFiles;

        public ClientSocket(List<FileInfo> files)
        {
            uploadFiles = files;
            loader = new Thread(new ThreadStart(Upload_files));
        }

        public void Upload_files()
        {

        }
    }
}
