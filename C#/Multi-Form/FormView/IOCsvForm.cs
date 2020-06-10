using mem_hkj.Model;
using mem_hkj.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mem_hkj.FormView
{
    public partial class IOCsvForm : Form
    {
        List<FileFormData> DataList;
        IOMainForm main;
        IOUtil prm_util;
        public bool save_state;


        /// <summary>
        /// OpenFileで生成する時
        /// </summary>
        [Obsolete]
        public IOCsvForm(IOMainForm main, IOUtil util)
        {
            InitializeComponent();
            this.main = main;
            prm_util = util;
            DataList = new List<FileFormData>();

            GetTableData();
            GetRowCount();
            this.MdiParent = main;
            this.Show();
            
        }

        /// <summary>
        /// 新規作成で生成する時
        /// </summary>
        public IOCsvForm(IOMainForm main, IOUtil util, bool flag)
        {
            InitializeComponent();
            this.Text = IOText.NEWCSV;
            this.main = main;
            prm_util = util;
            save_state = flag;

            GetTableData();
            GetRowCount();
            this.MdiParent = main;
            this.Show();
        }


        /// <summary>
        /// csvFileの中にあるDataを持ってくる
        /// </summary>
        private void GetTableData()
        {
            if (DataList == null) //新規作成だったら
            {
                DataList = new List<FileFormData>();
            }
            else //OpenFileしたら
            {
                DataList = prm_util.openCsv(this);
            }
            prm_util.SetCsvList(this, DataList);
            //現在のCSVFormにListを入れる
            if (DataList == null) return;
            SetTableData(DataList); //ListにあるDataをDataTableに入れる。
        }


        /// <summary>
        /// CsvFormのDataTableにDataを入れるメソッド
        /// </summary>
        private void SetTableData(List<FileFormData> modelList)
        {
            if(modelList == null) //Listがなかったら-
            {
                modelList = prm_util.getCsvModel(this); //持ってくる
            }

            tdb_model.Rows.Clear(); //Datatableを初期化する。

            for (int i = 0; i < DataList.Count; i++)
            {
                FileFormData data = DataList[i];
                this.tdb_model.Rows.Add(data.selected, data.serial, data.contents);

                if (data.color == 1)
                {
                    this.tdb_model.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
                else if (data.color == 2)
                {
                    this.tdb_model.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if(data.color == 0)
                {
                    this.tdb_model.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

                if ((bool)this.tdb_model.Rows[i].Cells[0].Value == true)
                {
                    this.tdb_model.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            
        }

        /// <summary>
        /// CVSFileにあるrowのcount
        /// </summary>
        private void GetRowCount()
        {
            DataList = prm_util.getCsvModel(this);
            if (DataList == null) return;
            int count = 0;
            for(int i = 0; i < DataList.Count; i++)
            {
                if(DataList[i].selected == false)
                {
                    count++;
                }
            }
            this.lblRowCount.Text = count + "";
        }


        /// <summary>
        /// DataTableのRowをDoubleClickした時、Serialの値と一致するDataを持ってくる
        /// </summary>
        private void RowDoubleClickEvent(object sender, EventArgs e)
        {
            String serial = tdb_model.CurrentRow.Cells[1].Value.ToString();
            FileFormData model = prm_util.getCsvModel(this, serial);
            prm_util.CreateFileForm(this, model); //FileFormをShow()して、Dataを入れる。
        }

        /// <summary>
        /// csvFormのAddButtonを押した時
        /// </summary>
        private void btn_rowAdd_Click(object sender, EventArgs e)
        {
            IOFileForm sub = new IOFileForm(this, prm_util);
            sub.MdiParent = main;
            sub.Show();
            //空いてあるFileFormをShow()する。
        }


        /// <summary>
        /// csvFormが活性化する時のEvent
        /// </summary>
        private void IOCsvForm_Activated(object sender, EventArgs e)
        {
            SetTableData(null); //DataTableの値が変更したか確認する。
            GetRowCount(); //現在csvFormのDataの数を表示する
            prm_util.setSaveState(this.save_state); //Saveができる状態か検査
        }

        /// <summary>
        /// CancelButtonを押した時
        /// </summary>
        private void btn_rowCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// RemoveButtonを押した時
        /// </summary>
        private void btn_rowRemove_Click(object sender, EventArgs e)
        {
            List<FileFormData> modelList = prm_util.getCsvModel(this); 
            changeState();
            for (int i = 0; i < modelList.Count; i++)
            {
                if ((bool)this.tdb_model.Rows[i].Cells[0].Value == true) //CheckBoxにチェックされたら
                {
                    modelList[i].selected = true;
                   // modelList[i].color = 3; //3は赤を意味する。
                }
                else //チェックされなかったら
                {
                    modelList[i].selected = false;

                  //  if (modelList[i].color == 3) modelList[i].color = 0;// 0は白を意味する。
                }
            }
            SetTableData(modelList);
            GetRowCount();
            prm_util.setSaveState(this.save_state);

        }


        /// <summary>
        /// 状態が変更すると、FormのTextに*をつける。
        /// </summary>
        public void changeState()
        {
            if (this.save_state == true) return;
            this.save_state = true;
            this.Text += IOText.ASTA;
        }

        private void IOCsvForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            prm_util.removeCsvModel(this);
        }

        private void IOCsvForm_Load(object sender, EventArgs e)
        {

        }
    }
}
