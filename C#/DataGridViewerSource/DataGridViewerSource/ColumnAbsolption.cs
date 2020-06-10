using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewerSource
{
    public partial class Form1 : Form
    {
        List<AlignmentData> dataList;
        List<SimpleData1> simpleList;

        public Form1()
        {
            dataList = new List<AlignmentData>(); //Test파일값 Model List
            simpleList = new List<SimpleData1>(); //Test2파일값 Model List
            InitializeComponent(); //컴포넌트 초기화
            TestFileReader(); //파일 Reader
            TestFile2Reader();

        }

        /// <summary>
        /// dataList길이 * 2 만큼 컬럼 추가후, 값 세팅
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataList.Count; i++)
            {
                Viewer1.Columns.Add(dataList[i].dataName + "1", " ");
                Viewer1.Columns.Add(dataList[i].dataName + "2", " ");
            }

            Viewer1.Columns[0].Frozen = true; // cell lock
            Viewer1.Columns[1].Frozen = true; // cell lock

            HeaderSet(); 
            CellDataSet();
        }

        /// <summary>
        /// 헤더값 셋팅
        /// </summary>
        private void HeaderSet()
        {
            String[] header = Properties.Resources.HeaderValue.Split(' ');

            Viewer1.CellPainting += Viewer1_CellPainting;

            for (int i = 0; i < 6; i++)
            {
                Viewer1.Rows.Add();
                Viewer1.Rows[i].Cells[1].Value = header[i % 3];
            }

            StringFormat format = new StringFormat();

            Viewer1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Viewer1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //가운데 정렬

            Viewer1.Rows[1].Cells[0].Value = "X";
            Viewer1.Rows[4].Cells[0].Value = "Y";

        }

        /// <summary>
        /// 셀값 셋팅
        /// </summary>
        private void CellDataSet()
        {
            for (int i = 0; i < dataList.Count-1; i++)
            {

                AlignmentData data = dataList[i+1];
                int index = (i * 2) + 2;

                Viewer1.Rows[0].Cells[index].Value = data.codeX[0];
                Viewer1.Rows[0].Cells[index + 1].Value = data.codeX[1];

                Viewer1.Rows[1].Cells[index].Value = data.xlocX[0];
                Viewer1.Rows[1].Cells[index + 1].Value = data.xlocX[1];

                Viewer1.Rows[2].Cells[index].Value = data.xlocY[0];
                Viewer1.Rows[2].Cells[index + 1].Value = data.xlocY[1];

                Viewer1.Rows[3].Cells[index].Value = data.codeY[0];
                Viewer1.Rows[3].Cells[index + 1].Value = data.codeY[1];

                Viewer1.Rows[4].Cells[index].Value = data.ylocX[0];
                Viewer1.Rows[4].Cells[index + 1].Value = data.ylocX[1];

                Viewer1.Rows[5].Cells[index].Value = data.ylocY[0];
                Viewer1.Rows[5].Cells[index + 1].Value = data.ylocY[1];
            }
        }


        /// <summary>
        /// 헤더의 Row 0번째 셀 병합
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Viewer1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

            if (e.RowIndex % 3 != 0 && e.ColumnIndex == 0)
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            }
            else
            {
                e.AdvancedBorderStyle.Top = Viewer1.AdvancedCellBorderStyle.Top;
            }
        }


        /// <summary>
        /// Paint로 컬럼병합
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Viewer1_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < dataList.Count; i++) // 리스트 길이 만큼 반복
            {

                Rectangle r1 = Viewer1.GetCellDisplayRectangle((i*2), -1, true); // 위치값의 Cell값을 읽어와 Rectangle로 변환
                                                                //(row, col, borderStyle값을 포함할것인가 )
                                                                //-1은 컬럼을 의미
                
                r1.X += 1;
                r1.Y += 1;
                r1.Width = (r1.Width*2) - 2; // 병합을 위해 cell 두개값을 넣음
                r1.Height -= 6;
                //Drawing좌표 수정

                using (SolidBrush br = new SolidBrush(Viewer1.ColumnHeadersDefaultCellStyle.BackColor)) // 배경색
                {
                    e.Graphics.FillRectangle(br, r1);
                }


                using (SolidBrush br = new SolidBrush(this.Viewer1.ColumnHeadersDefaultCellStyle.ForeColor)) // 텍스트
                {
                    StringFormat sf = new StringFormat
                    {
                        LineAlignment = StringAlignment.Center,
                        Alignment = StringAlignment.Center
                    };
                    // cell 두개를 덮은 Graphics 중앙에 텍스트 Draw
                    e.Graphics.DrawString(dataList[i].dataName, Viewer1.ColumnHeadersDefaultCellStyle.Font, br, r1, sf);
                }
            }
        }

        /// <summary>
        /// 스크롤시 그래픽소실 현상 방지
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Viewer1_Scroll(object sender, ScrollEventArgs e)
        {
            Rectangle parentHeaderRectangle = Viewer1.DisplayRectangle;
            parentHeaderRectangle.Height = Viewer1.ColumnHeadersHeight;
            //DataGridView의 Graphics를 복사해서 Rectangle로 변환

            Viewer1.Invalidate(parentHeaderRectangle);
            //Paint 재호출
        }
    
        private void TestFileReader()
        {
            dataList.Add(new AlignmentData { dataName = "LAYER" }); // 세로 헤더값

            String[] fileRead = File.ReadAllLines(System.Windows.Forms.Application.StartupPath + "\\NSR_Test.txt");

            AlignmentData data = new AlignmentData();

            for (int i = 0; i < fileRead.Length;)
            {
                if (fileRead[i].Equals(""))
                {
                    data = new AlignmentData();
                    i++;
                }
                data.dataName = fileRead[i++];
                data.codeX = fileRead[i++].Split(' ');
                data.xlocX = fileRead[i++].Split(' ');
                data.xlocY = fileRead[i++].Split(' ');
                data.codeY = fileRead[i++].Split(' ');
                data.ylocX = fileRead[i++].Split(' ');
                data.ylocY = fileRead[i++].Split(' ');

                dataList.Add(data);
            }// 읽어온 값을 data에 셋팅후 List에 담음.

            data = null;
        }


        private void TestFile2Reader()
        {
            String[] data = File.ReadAllLines(System.Windows.Forms.Application.StartupPath + "\\FPA_Test.txt");

            for(int i = 0; i < data.Length; i++)
            {
                SimpleData1 simple = new SimpleData1();
              

            }


            
        }
    }

}
