using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Drawing_hkj.SCU
{
    class ServerSocket
    {
        public Socket server;

        public ServerSocket()
        {

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(new IPEndPoint(IPAddress.Any, 9013));
            server.Listen(10);


            while (true)
            {
                Socket connect = server.Accept();

                connect.Send(Encoding.Default.GetBytes("Hi Client"));
                connect.Close();
            
            }
        }
    }
}
