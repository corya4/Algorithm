using Drawing_hkj.Properties;
using Drawing_hkj.SCU;
using Drawing_hkj.Util;
using mem_hkj;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Drawing_hkj
{
    public partial class MainForm : Form
    {

        Bitmap memoryImage;
        ShapeData shape; // 図形のLocationと形を含むClass
        List<ShapeData> shapeList = new List<ShapeData>();
        FontData fontData; //Fontのでーたを含むClass
        bool DrawState = false;

        Size orgS;
        float ratio = 1.0f;

        ServerSocket server;
        ClientSocket client;

        Thread s_Thread; //Server Thread

        readonly int columnName = 1;
        readonly int columnBtn = 2;

        public MainForm()
        {
            InitializeComponent();
            orgS = new Size(ptb.Width, ptb.Height);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbx_elas.SelectedIndex = 1; //拡大パーセント初期化
            ptb.Parent = pnl_paper; // ドーキング
            fontData = new FontData(); //初期化

            s_Thread = new Thread(new ThreadStart(delegate ()
            {
                server = new ServerSocket();
            }));
            s_Thread.IsBackground = true;
            s_Thread.Start();
            //Loadする時、Serverを初期化及びThread Start

            client = new ClientSocket();
            GridFileNameLoad();

        }


        /// <summary>
        /// ServerにあるFile名前をGridViewに持ってくる
        /// </summary>
        private void GridFileNameLoad()
        {
            String[] FileName = client.Recive_FileName();

            xmlList.Rows.Clear();

            int index = 1;
            
            for(int i = 0; i < FileName.Length ; i++)
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                xmlList.Rows.Add(index++, FileName[i], button);
                xmlList.Rows[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                xmlList.Rows[i].Cells[columnName].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                xmlList.Rows[i].Cells[columnBtn].Value = "Read";
            }

        }



        /// <summary>
        /// 図形の色を選択するメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectColor(object sender, MouseEventArgs e)
        {
            if (colorDialog == null) colorDialog = new ColorDialog(); //初期化

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                pnl_color.BackColor = colorDialog.Color; //OKButtonを押したらColorを持ってくる
            }
        }



        /// <summary>
        /// テキストのフォントを選択するメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectFont(object sender, EventArgs e)
        {
            if (fontDialog == null) fontDialog = new FontDialog(); //初期化

            if(fontDialog.ShowDialog() == DialogResult.OK)
            {
                txt_font.Text = fontDialog.Font.Name +Resources.Comma + fontDialog.Font.Size; //OKButtonをおしたらFontの形式とSizeを持ってくる
                fontData.font = fontDialog.Font.Name;
                fontData.size = fontDialog.Font.Size;
                fontData.style = fontDialog.Font.Style;
                //Font Data Set
            }
        }



        /// <summary>
        /// PrintPreviewするEventメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Previewer(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            Size s = pnl_paper.Size;　
            memoryImage = new Bitmap(s.Width, s.Height, g); // PaperだけSizeを生成

            Graphics buf_g = Graphics.FromImage(memoryImage);
            buf_g.CopyFromScreen(this.PointToScreen(new Point(( pnl_paper.Location.X), (pnl_paper.Location.Y))), new Point(0, 0), s);
            //このLocationの画面をCopyする
            printPreviewer.Document = printPage;
            printPreviewer.ShowDialog(); //Previewする
        }



        /// <summary>
        /// PrintDocument生成メソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage,0, 0);
        }



        /// <summary>
        /// 図形Drawするメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawShape(object sender, EventArgs e)
        {
           
            shape = new ShapeData(); //データ初期化

            switch (cbx_shape.SelectedIndex)
            {
                case 0:
                    shape.state = 1; //線
                    break;
                case 1:
                    shape.state = 2;　//三角
                    break;
                case 2:
                    shape.state = 3; //四角
                    break;
                case 3:
                    shape.state = 4; //円
                    break;
            }

            if (((Button)sender).Text.Equals(Resources.BtnString)) // テキスト作成ボタンを押した場合
            {
                shape.state = 5; //テキスト
            }

            if (shape.state == 0)//何も選択しなかったらRetrun
            {
                MessageBoxEx.Show(this, Resources.ShapeError, Resources.DrawError, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DrawState = true;
            //pnl_paper.Enabled = true;
            //pnl_paper.BackColor = Color.White;
            //図形をDrawするPaperを活性化
        }



        /// <summary>
        /// DrawPanelをClickするときShape客体にLocationを設定する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetPoint(object sender, MouseEventArgs e)
        {

            if (shape == null) return;
            if (!Capture && e.Button != MouseButtons.Left) return; //Formのなかを超える時、Return

            shape.pointIndex.Add(new Point(e.X, e.Y)); //Location Add
            shape.color = pnl_color.BackColor;
            //p.StartCap = p.EndCap = LineCap.Round;
            shape.fill = chx_fill.Checked;
            fontData.text = txt_text.Text;
            shape.font = fontData;
            Graphics gps = ptb.CreateGraphics();


            if (shape.DrawShape(gps, chx_fill.Checked, 1.0f)) //Drawした場合
            {
                shapeList.Add(shape); //Listに追加
                shape = null;
                
                DrawState = false; //MauseState
                this.Cursor = Cursors.Arrow;
            }
           
        }



        /// <summary>
        /// 倍率技能Event
        /// 
        /// ratio - 倍率演算変数
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElasChange(object sender, EventArgs e) //倍率メソッド
        {

            int index = cbx_elas.SelectedIndex; //Selectした倍率の値

            if(index == 0)
            {
                ratio = 0.5f;
            }else if (index == 1)
            {
                ratio = 1.0f;
            }
            else if (index == 2)
            {
                ratio = 2.0f;
            }

            ReDrawShape();

            
        }



        /// <summary>
        /// RePaint代わりのメソッド [shapeListにあるShapeDataの情報でやり直す]
        /// </summary>
        private void ReDrawShape()
        {

            ptb.Width = (int)(orgS.Width * ratio); //ptbの基のWidthに変化
            ptb.Height = (int)(orgS.Height * ratio); //ptbの元のHeightに変化

            ptb.Refresh(); //Graphics初期化
            Graphics gps = ptb.CreateGraphics();
            gps.Clear(Color.White); //初期化の保険

            foreach (ShapeData s in shapeList)
            {
                s.DrawShape(gps, s.fill, ratio); //ReDrawするメソッド
            }
            gps.Dispose();　//Reference切り
        }



        /// <summary>
        /// Scrollする場合のEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnl_paper_Scroll(object sender, ScrollEventArgs e)
        {

            pnl_paper.Invalidate(); //PaintEvent実行
           
        }



        /// <summary>
        /// DrawPanelのPaintEvent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnl_paper_Paint(object sender, PaintEventArgs e)
        {
           
            Graphics g = ptb.CreateGraphics();

            foreach(ShapeData s in shapeList)
            {
                s.DrawShape(g, s.fill, ratio);
            }
        }


        /// <summary>
        /// XML保存するメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_save_Click(object sender, EventArgs e)
        {

            client.Send_Shape(shapeList);
            GridFileNameLoad(); //DataGridView Update

        }


        /// <summary>
        /// ClickしたRowのXMLFileを持ってくる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XML_Read(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.ColumnIndex == columnBtn)　//ClickしたCellがButtonの場合
            {
                String NameStr = (String)xmlList.Rows[e.RowIndex].Cells[1].Value;
                shapeList = client.Recive_Shape(NameStr); //Click RowのFileNameがParameter
                ReDrawShape();
            }
        }


        /// <summary>
        /// Formを終了するときSocketとThreadも終了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            server.client.Close();
            server.server.Close();
            client.client.Close();

            s_Thread.Abort();
            //終了する順番重要
        }



        /// <summary>
        /// DrawができるときCurSorがかわる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptb_MouseHover(object sender, EventArgs e)
        {
            if (!DrawState) return;
            this.Cursor = Cursors.PanNW;
        
        }


        /// <summary>
        /// Cursor初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptb_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }


        /// <summary>
        /// DrawPanel初期化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            ptb.Refresh(); //Graphics初期化
            Graphics gps = ptb.CreateGraphics();
            gps.Clear(Color.White); //初期化の保険

            shapeList.Clear(); //List初期化
        }
    }
}
