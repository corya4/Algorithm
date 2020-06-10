using Drawing_hkj.Util;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Windows;
using System.Drawing;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Drawing_hkj.Properties;
using System.Diagnostics;

namespace Drawing_hkj.SCU
{
    class ServerSocket
    {
        public Socket server; //Accept処理Socket
        public Socket client; //Serverと連結したSocket

        public byte[] byteName = new byte[1024];
        public String path = Application.StartupPath +  Resources.FileSeparator + Resources.Directory; //Directory Path

        DirectoryInfo directory;
        FileInfo[] files;

        public ServerSocket()
        {
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //ServerSocket設定
            server.Bind(new IPEndPoint(IPAddress.Any, 9013)); //IPとPort設定
            server.Listen(10);　//同時連結Socket数

            Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■");
            Console.WriteLine("■■■■■■■■ サービス開始 ■■■■■■■■");

            client = server.Accept(); //連結するときまでWait
            client.BeginReceive(byteName, 0, byteName.Length, SocketFlags.None, new AsyncCallback(waitOrder), client);
            //Dataを伝送して Callbackメソッドを呼び出し
        }


        /// <summary>
        /// Clientの要求を待つメソッド
        /// </summary>
        /// <param name="ar"></param>
        private void waitOrder(IAsyncResult ar)
        {                          //Begin.. メソッドのLastParameterのSocketの情報

            Socket anync = ar.AsyncState as Socket; //連結要求したSocket

            try {
                int size = anync.EndReceive(ar); //連結を切ってDataのLenthをReturn
                String fileName = Encoding.UTF8.GetString(byteName, 0, size);

                if (size == 1) //DataのLengthが1の場合
                {
                    Console.WriteLine("[" + anync.RemoteEndPoint.ToString().Split(':') + "]" + Resources.ReciveCursor + Resources.XMLRecive);
                    fileNameSet();
                    Console.WriteLine("[" + anync.RemoteEndPoint.ToString().Split(':') + "]" + Resources.SendCursor + Resources.XMLSend);

                }
                else if(size == 2)　//DataのLengthが2の場合
                {
                    NetworkStream ns = new NetworkStream(anync); //入ったClientのStream
                    IFormatter format = new BinaryFormatter();
                    SaveXML((List<ShapeData>)format.Deserialize(ns)); //Clientで serializeしたDataを受ける
                    ns.Close();
                    Console.WriteLine("[" + anync.RemoteEndPoint.ToString().Split(':') + "]" + Resources.ReciveCursor + Resources.DataUpload);

                }
                else
                {
                    List<ShapeData> sList = new List<ShapeData>();

                    if (fileCheck(fileName)) //FileNameチェック
                    {
                        TranceData(sList, fileName); //XMLFileをShapeに変更

                        Console.WriteLine("[" + anync.RemoteEndPoint.ToString().Split(':') + "]" + Resources.ReciveCursor + "[" + fileName + "]" + Resources.DataRecive);
                        NetworkStream ns = new NetworkStream(anync); //入ったClientのStream
                        IFormatter format = new BinaryFormatter();
                        format.Serialize(ns, sList); //DataをSerializeする
                        ns.Close();
                        Console.WriteLine("[" + anync.RemoteEndPoint.ToString().Split(':') + "]" + Resources.SendCursor + "[" + fileName + "]" + Resources.DataSend);


                    }
                
                 }

                anync.BeginReceive(byteName, 0, byteName.Length, SocketFlags.None, new AsyncCallback(waitOrder), anync);
                //次のClientにSendがくるまで待つ
            }
            catch (ObjectDisposedException se)
            {

            }
        }



        /// <summary>
        /// XMLFileNameをSendするメソッド
        /// </summary>
        private void fileNameSet()
        {

            directory = new DirectoryInfo(path); //経路のForder情報
            int length = directory.GetFiles().Length; //directoryにあるFile数
            files = new FileInfo[length];
            String sendData = "";

            for (int i = 0; i < length; i++)
            {
                files[i] = directory.GetFiles()[i];

                if (i == length - 1)
                {
                    sendData += files[i].Name;
                }
                else
                {
                    sendData += files[i].Name + ",";
                }

            }

            byte[] buf = Encoding.UTF8.GetBytes(sendData);
            client.Send(buf, 0, buf.Length, SocketFlags.None); //ClientにSend


        }



        /// <summary>
        /// XMLFileをSaveするメソッド
        /// </summary>
        /// <param name="shapeList"></param>
        private void SaveXML(List<ShapeData> shapeList)
        {

            XmlDocument doc = new XmlDocument();　//XML生成
            XmlElement root = doc.CreateElement(Resources.Root);

            for (int i = 0; i < shapeList.Count; i++)
            {
                ShapeData s = shapeList[i];

                XmlElement shape = doc.CreateElement(Resources.Shape);

                shape.SetAttribute(Resources.Order, (i + 1) + ""); //生成Number
                shape.SetAttribute(Resources.Kind, getKind(s.state)); //Shpae状態
                shape.SetAttribute(Resources.BackColor, (s.fill) ? "Y" : "N"); //Fil状態

                setElement(doc, shape, s.state, s.pointIndex, s.font);

                if (s.state != 5) //文字がない場合
                {
                    XmlElement color = doc.CreateElement(Resources.Color);
                    Color c = s.color;
                    color.InnerText = String.Format("{0}.{1}.{2}", c.R, c.G, c.B); //ColorのRGB値
                    shape.AppendChild(color);

                }

                root.AppendChild(shape);
            }

            doc.AppendChild(root);

            DateTime now = DateTime.Now;
            String fileName = String.Format(Resources.FileTime, now) + Resources.XML;
            doc.Save(path + Resources.FileSeparator + fileName); //経路にXML生成
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private String getKind(int index)　//Shape状態にあうStringをRetrun
        {
            switch (index)
            {
                case 1: return Resources.Line;
                case 2: return Resources.Triangle;
                case 3: return Resources.Square;
                case 4: return Resources.Circle;
                case 5: return Resources.Text;
            }
            return null;
        }



        /// <summary>
        /// ChildElementをSetするメソッド
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="xel"></param>
        /// <param name="type"></param>
        /// <param name="pList"></param>
        /// <param name="f"></param>
        private void setElement(XmlDocument doc, XmlElement xel, int type, List<Point> pList, FontData f)
        {
            XmlElement position = null;
            int x = 0;
            int y = 0;

            for (int i = 0; i < pList.Count; i++)　//ShapeDataにあるPointを検索
            {
                Point p = pList[i];
                if (type <= 3 && position == null) position = doc.CreateElement(Resources.Position);　//線、三角、四角の場合
                switch (type)
                {
                    case 1:　//線

                        XmlElement locSE = doc.CreateElement(Resources.StartEnd.Split(' ')[i]);
                        locSE.InnerText = String.Format("{0},{1}", p.X, p.Y); //Locationの値
                        position.AppendChild(locSE);

                        if (i == 1) xel.AppendChild(position);
                        break;

                    case 2: //三角

                        XmlElement locP = doc.CreateElement(Resources.Location.Split(' ')[i]);
                        locP.InnerText = String.Format("{0},{1}", p.X, p.Y);　//Locationの値
                        position.AppendChild(locP);

                        if (i == 2) xel.AppendChild(position);
                        break;

                    case 3: //四角

                        XmlElement locSE2 = doc.CreateElement(Resources.StartEnd.Split(' ')[i]);
                        locSE2.InnerText = String.Format("{0},{1}", p.X, p.Y);　//Locationの値
                        position.AppendChild(locSE2);

                        if (i == 1) xel.AppendChild(position);
                        break;

                    case 4: //円

                        if (i == 1)
                        {
                            int radiusX = Math.Abs(p.X - x);
                            int radiusY = Math.Abs(p.Y - y);

                            int pi = (radiusX > radiusY) ? radiusX : radiusY; //長い値で描く

                            XmlElement locC = doc.CreateElement(Resources.Radius.Split(' ')[0]);
                            locC.InnerText = String.Format("{0},{1}", x + (pi / 2), y + (pi / 2));
                            xel.AppendChild(locC);

                            XmlElement locR = doc.CreateElement(Resources.Radius.Split(' ')[1]);
                            locR.InnerText = String.Format("{0}", (pi / 2)); //Radius
                            xel.AppendChild(locR);
                        }

                        x = p.X;
                        y = p.Y;

                        break;


                    case 5: //文字
                        String[] ele = Resources.Font.Split(' ');

                        XmlElement locT = doc.CreateElement(ele[0]);
                        locT.InnerText = f.text;

                        XmlElement locL = doc.CreateElement(Resources.Location.Split(' ')[3]);
                        locL.InnerText = String.Format("{0},{1}", p.X, p.Y);

                        XmlElement locF = doc.CreateElement(ele[1]);
                        XmlElement locM = doc.CreateElement(ele[2]);
                        locM.InnerText = f.font.ToString();

                        XmlElement locS = doc.CreateElement(ele[3]);
                        locS.InnerText = Convert.ToString((int)f.size);

                        locF.AppendChild(locM);
                        locF.AppendChild(locS);
                        xel.AppendChild(locT);
                        xel.AppendChild(locL);
                        xel.AppendChild(locF);
                        //FontのDataを入れる
                        break;
                }
            }
        }



        /// <summary>
        /// ParameterのFileNameがあるか確認するメソッド
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private bool fileCheck(String fileName)
        {
            
            foreach(FileInfo file in files)
            {
                if (file.Name.Equals(fileName))
                {
                    return true;
                }
            }

            return false;
        }



        /// <summary>
        /// fileStrのXMLをShape客体で変更してlistに混む
        /// </summary>
        /// <param name="list"></param>
        /// <param name="fileStr"></param>
        private void TranceData(List<ShapeData> list, String fileStr)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path + "\\" + fileStr); // XmlFileを読み込む
            XmlNodeList xList = doc.SelectNodes("/Root/Shape"); //ShapeNodeだけを抽出

            foreach (XmlElement ele in xList) //ShapeNode数だけ繰り返し
            {

                String kind = ele.GetAttribute(Resources.Kind); //ShapeのState

                ShapeData loadshape = new ShapeData();
                String[] color;
                bool fill;
                Pen p;

                if (kind.Equals(Resources.Line)) //線の場合
                {
                    String[] start = ele.SelectSingleNode("Position/Start").InnerText.Split(',');
                    String[] end = ele.SelectSingleNode("Position/End").InnerText.Split(',');
                    color = ele.SelectSingleNode("Color").InnerText.Split('.');
                    fill = ele.GetAttribute(Resources.Fill).Equals("Y");
                    p = new Pen(Color.FromArgb(Int32.Parse(color[0]), Int32.Parse(color[1]), Int32.Parse(color[2])));

                    loadshape.state = 1;
                    loadshape.color = p.Color;
                    loadshape.pointIndex.Add(new Point(Int32.Parse(start[0]), Int32.Parse(start[1])));
                    loadshape.pointIndex.Add(new Point(Int32.Parse(end[0]), Int32.Parse(end[1])));
                    loadshape.fill = fill;

                }
                else if (kind.Equals(Resources.Triangle)) //三角の場合
                {
                    String[] p1 = ele.SelectSingleNode("Position/P1").InnerText.Split(',');
                    String[] p2 = ele.SelectSingleNode("Position/P2").InnerText.Split(',');
                    String[] p3 = ele.SelectSingleNode("Position/P3").InnerText.Split(',');
                    color = ele.SelectSingleNode("Color").InnerText.Split('.');
                    fill = ele.GetAttribute(Resources.Fill).Equals("Y");
                    p = new Pen(Color.FromArgb(Int32.Parse(color[0]), Int32.Parse(color[1]), Int32.Parse(color[2])));

                    loadshape.state = 2;
                    loadshape.color = p.Color;
                    loadshape.pointIndex.Add(new Point(Int32.Parse(p1[0]), Int32.Parse(p1[1])));
                    loadshape.pointIndex.Add(new Point(Int32.Parse(p2[0]), Int32.Parse(p2[1])));
                    loadshape.pointIndex.Add(new Point(Int32.Parse(p3[0]), Int32.Parse(p3[1])));
                    loadshape.fill = fill;

                }
                else if (kind.Equals(Resources.Square)) // 四角の場合
                {

                    String[] start = ele.SelectSingleNode("Position/Start").InnerText.Split(',');
                    String[] end = ele.SelectSingleNode("Position/End").InnerText.Split(',');
                    color = ele.SelectSingleNode(Resources.Color).InnerText.Split('.');
                    fill = ele.GetAttribute(Resources.Fill).Equals("Y");
                    p = new Pen(Color.FromArgb(Int32.Parse(color[0]), Int32.Parse(color[1]), Int32.Parse(color[2])));

                    loadshape.state = 3;
                    loadshape.color = p.Color;
                    loadshape.pointIndex.Add(new Point(Int32.Parse(start[0]), Int32.Parse(start[1])));
                    loadshape.pointIndex.Add(new Point(Int32.Parse(end[0]), Int32.Parse(end[1])));
                    loadshape.fill = fill;

                }
                else if (kind.Equals(Resources.Circle)) // 円の場合
                {

                    String[] arrCircle = Resources.Radius.Split(' ');
                    String[] center = ele.SelectSingleNode(arrCircle[0]).InnerText.Split(',');
                    int radius = Int32.Parse(ele.SelectSingleNode(arrCircle[1]).InnerText);
                    color = ele.SelectSingleNode(Resources.Color).InnerText.Split('.');
                    fill = ele.GetAttribute(Resources.Fill).Equals("Y");
                    p = new Pen(Color.FromArgb(Int32.Parse(color[0]), Int32.Parse(color[1]), Int32.Parse(color[2])));

                    loadshape.state = 4;
                    loadshape.color = p.Color;
                    loadshape.pointIndex.Add(new Point(Int32.Parse(center[0]) - radius, Int32.Parse(center[1]) - radius));
                    loadshape.pointIndex.Add(new Point(Int32.Parse(center[0]) + radius, Int32.Parse(center[1]) + radius));
                    //CenterのLocationにradiusを演算してPoint生成

                    loadshape.fill = fill;

                }
                else if (kind.Equals(Resources.Text)) //Textの場合
                {

                    String[] arrFont = Resources.Font.Split(' ');
                    String[] loc = ele.SelectSingleNode("Location").InnerText.Split(',');
                    String text = ele.SelectSingleNode(arrFont[0]).InnerText;
                    String family = ele.SelectSingleNode(arrFont[1] + "/" + arrFont[2]).InnerText;
                    String size = ele.SelectSingleNode(arrFont[1] + "/" + arrFont[3]).InnerText;
                    fill = ele.GetAttribute(Resources.Fill).Equals("Y");

                    loadshape.state = 5;
                    loadshape.pointIndex.Add(new Point(Int32.Parse(loc[0]), Int32.Parse(loc[1])));
                    loadshape.font = new FontData(family, Int32.Parse(size));
                    loadshape.font.text = text;

                }

                list.Add(loadshape); //生成したShapeDataを含む
            }


        }
    }
}
