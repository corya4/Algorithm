using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_hkj.Util
{   

    [Serializable]
    class ShapeData
    {
        public List<Point> pointIndex { get; set; }
        public Color color { get; set; }
        public int state { get; set; }
        public bool fill { get; set; }
        public FontData font { get; set; }


        public ShapeData()
        {
            pointIndex = new List<Point>();
        }

        public Point getPoint(int index)
        {
            if (pointIndex != null)
            {
                return pointIndex[index];
            }

            return new Point(); //Nullの代わり
        }



        /// <summary>
        /// ParameterのGrahpicsにDrawする
        /// </summary>
        /// <param name="gps"></param>
        /// <param name="check"></param>
        /// <param name="ratio"></param>
        /// <returns></returns>
        public bool DrawShape(Graphics gps, bool check, float ratio)
        {
            bool init = false;
            List<Point> tmpList = RePoint(ratio);

            Pen p = new Pen(color, 1);

            switch (state)
            {
                case 1: //線の場合

                    if (tmpList.Count == 2)　//Panelを二回押した時
                    {
                        
                        gps.DrawLine(p, tmpList[0], tmpList[1]);
                        init = true;
                    }

                    break;
                case 2:　//三角の場合


                    if (tmpList.Count > 2)　//Panelを二回以上押した時
                    {
                        gps.DrawLine(p, tmpList[2], tmpList[0]);
                        gps.DrawLine(p, tmpList[1], tmpList[2]);

                        if (check)　//塗りつぶしをCheckedした時
                        {
                            gps.FillPolygon(new SolidBrush(p.Color), new Point[] { tmpList[0], tmpList[1], tmpList[2] });
                            init = true;
                        }


                    }
                    else if (tmpList.Count > 1)
                    {
                        gps.DrawLine(p, tmpList[0], tmpList[1]);
                    }

                    break;
                case 3: //四角の場合

                    if (tmpList.Count == 2)　//Panelを二回押した時
                    {

                        int x = tmpList[1].X - tmpList[0].X;
                        int y = tmpList[1].Y - tmpList[0].Y;

                        Size s;
                        Rectangle rg = new Rectangle();
                        if (x < 0 && y < 0) // xとyが0より低い場合
                        {
                            int tmpX = tmpList[0].X;
                            int tmpY = tmpList[0].Y;

                            s = new Size(tmpX - tmpList[1].X, tmpY - tmpList[1].Y);
                            rg = new Rectangle(tmpList[1], s);

                            //二番目のClickが一番目のClickより小さい場合
                        }
                        else
                        {
                            s = new Size(x, y);
                            rg = new Rectangle(tmpList[0], s);
                        }

                        gps.DrawRectangle(p, rg);
                        init = true;

                        if (check)　//塗りつぶしをCheckedした時
                        {
                            gps.FillRectangle(new SolidBrush(p.Color), rg);
                        }

                    }

                    break;
                case 4:　//円の場合

                    if (tmpList.Count == 2)　//Panelを二回押した時
                    {
                        int ls = 0;

                        if ((tmpList[1].X - tmpList[0].X) > (tmpList[1].Y - tmpList[0].Y))
                        {
                            ls = tmpList[1].X - tmpList[0].X;
                        }
                        else
                        {
                            ls = tmpList[1].Y - tmpList[0].Y;
                        }
                        //XとYの中で長い方の値を入力する。


                        Size s = new Size(Math.Abs(ls), Math.Abs(ls));
                        Rectangle rg = new Rectangle();

                        int x = tmpList[1].X - tmpList[0].X;
                        int y = tmpList[1].Y - tmpList[0].Y;

                        if (x < 0 && y < 0)
                        {
                            rg = new Rectangle(tmpList[1], s);
                            //二番目のClickが一番目のClickより小さい場合
                        }
                        else
                        {
                            rg = new Rectangle(tmpList[0], s);

                        }

                        gps.DrawEllipse(p, rg);
                        init = true;

                        if (check)　//塗りつぶしをCheckedした時
                        {
                            gps.FillEllipse(new SolidBrush(p.Color), rg);
                        }

                    }
                    break;
                case 5:　//文字の場合

                    Font tmpF = new Font(font.font, font.getFont().Size * ratio, font.style);
                    
                    SizeF sf = gps.MeasureString(font.text, tmpF);
                    gps.DrawString(font.text, tmpF, Brushes.Black, tmpList[0].X - sf.Width, tmpList[0].Y - sf.Height);
                    init = true;
                    break;
            }

            return init;

        }



        /// <summary>
        /// 倍率が変更するとき、ShapeのLocationも変更
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        private List<Point> RePoint(float r)
        {
            List<Point> list = new List<Point>();

            foreach(Point p in pointIndex)
            {
                Point tmpP = new Point((int)(p.X * r), (int)(p.Y * r));
                list.Add(tmpP);
            }

            return list;
        }
    }
}
