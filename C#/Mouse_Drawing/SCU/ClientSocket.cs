using Drawing_hkj.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Drawing_hkj.SCU
{
    class ClientSocket
    {

        public Socket client;
        byte[] nameByte;


        public ClientSocket()
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //Socket設定
            client.Connect(new IPEndPoint(IPAddress.Parse("172.16.23.60"), 9013)); //Ipと Port設定
            nameByte = new byte[1024]; //Packet代わり

        }


        /// <summary>
        /// ServerにXMLFileNameをRecive
        /// </summary>
        /// <returns></returns>
        public String[] Recive_FileName()
        {
            byte[] buf = new byte[1];

            client.Send(buf, 0, buf.Length, SocketFlags.None) ;
            int size = client.Receive(nameByte, 0, nameByte.Length, SocketFlags.None);
            String files = "";
            files = Encoding.UTF8.GetString(nameByte, 0, size);
            String[] filenames = files.Split(',');

            return filenames;

        }


        /// <summary>
        /// ServerにfileNameのDataをRecive
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<ShapeData> Recive_Shape(String fileName)
        {
            byte[] buf = Encoding.UTF8.GetBytes(fileName);
            
            NetworkStream ns = new NetworkStream(client);
            IFormatter format = new BinaryFormatter();

            
            client.Send(buf, 0, buf.Length, SocketFlags.None);
            List<ShapeData> shapeList = (List<ShapeData>)format.Deserialize(ns);
            ns.Close();

            return shapeList;
        }


        /// <summary>
        /// ServerにDrawしたDataをSend
        /// </summary>
        /// <param name="list"></param>
        public void Send_Shape(List<ShapeData> list)
        {
            byte[] buf = new byte[2];
            client.Send(buf, 0, buf.Length, SocketFlags.None);

            NetworkStream ns = new NetworkStream(client); //Stream連結
            IFormatter format = new BinaryFormatter(); //Serializable方式
            format.Serialize(ns, list); //SerializableしたDataをStreamに伝送
            ns.Close(); //Stream終了
        }
    }

}
