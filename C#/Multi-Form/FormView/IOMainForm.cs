using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using mem_hkj.Properties;
using System.Configuration;
using mem_hkj.Model;
using mem_hkj.BL;
using mem_hkj.FormView;

namespace mem_hkj
{
    public partial class IOMainForm : Form
    {
        private IOUtil util;
        public List<IOFileForm> subList { set; get; }　//subFormを込め包み

        public IOMainForm()
        {
            InitializeComponent(); //Component 初期化
            util = new IOUtil(this); //IOUtil生成
            subList = new List<IOFileForm>(); // subForm List 初期化
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(ConfigurationSettings.AppSettings["Directory"]);
            if (directory.Exists == false) directory.Create();
            this.KeyPreview = true; // KeyEventをFormがすぐ受け取るためTrueに指定
            saveToolStripMenuItem.Enabled = false;
            LockScollBar();
        }

        /// <summary>
        /// Event - ShortcutKey入力Evnet
        /// </summary>
        private void pressCmdKey(object sender, KeyEventArgs e) 
        {
            /*PerformClick() - 他のComponentでEventを発生するMethod*/

            if(e.Control == true && e.KeyCode == Keys.N) //CtrlとNを一緒に押したとき
            {
                addToolMenuItem.PerformClick();
            }
            else if(e.Control == true && e.KeyCode == Keys.X) //CtrlとXを一緒に押したとき
            {
                exitToolMenuItem.PerformClick();
            }
            else if(e.Control == true && e.KeyCode == Keys.T) //CtrlとTを一緒に押したとき
            {
                statusToolMenuItem.PerformClick();
            }
            else if(e.Control == true && e.KeyCode == Keys.S) //CtrlとSを一緒に押したとき
            {
                saveToolStripMenuItem.PerformClick();
            }
            else if(e.Control == true && e.KeyCode == Keys.O) //CtrlとOを一緒に押したとき
            {
                openToolStripMenuItem.PerformClick();
            }
            else
            {
                //技能なし
            }
        }

        private void versionDataMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBoxEx.Show(this, IOText.VERSION_LABEL, IOText.VERSION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);　//　MainFormの中央に表示するため追加するClass (Open source)
            //アールラムFormはモニターの中央に現すように設定していてこの設定を変更するClass
        }

        /// <summary>
        /// MainFormで閉めるMenuEvent
        /// </summary>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //MainFormを終了する
        }

        /// <summary>
        /// SubForm生成Event
        /// </summary>
        private void addToolMenuItem_Click(object sender, EventArgs e) 
        {
            IOCsvForm csvForm = new IOCsvForm(this, util, true);
        }

        /// <summary>
             /// ステータスバーEvent
        /// </summary>
        private void statusToolMenuItem_Click(object sender, EventArgs e)
        {
            /*Visibleがtrueなら見える,falseなら見えない*/

            if (StripStu.Visible) //ステータスバーがみえるならTrue
            {
                StripStu.Visible = false;
                statusToolMenuItem.Checked = false;
            }
            else　//見えないならFalse
            {
                StripStu.Visible = true;
                statusToolMenuItem.Checked = true;
            }
        }


        /// <summary>
        /// SubFormが閉まる前にSaveStateかを判定するメソッド
        /// </summary>
        private void closeSubFormMenuItem_Click(object sender, EventArgs e)
        {
            IOCsvForm csvForm = util.getFoucesdForm();
            if (csvForm == null) return; //FocuesdされたSubFormがなかったらReturn
            csvForm.Close(); //しめる
            util.EnableSaveMenu();
        }

        /// <summary>
        /// SaveMenuのEvent
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //SaveMenuItemを押した場合Evnet
        {
            util.SaveFile();
        }

        /// <summary>
        /// 作成中
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e) //OpenFileButtonを押したときEvent
        {
            IOCsvForm listForm = new IOCsvForm(this, util);
        }
       
        /// <summary>
              /// SubFormがMainFormの範囲を超えてもScrollBarが生成しないようにするメソッド
        /// </summary>
        private void LockScollBar()
        {
            ScrollBarEx se = new ScrollBarEx();
            for (int i = 0; i < this.Controls.Count; i++) // Formに設定されるControlの数だけLoop
            {
                MdiClient mdiClient = this.Controls[i] as MdiClient; //FormのContorlをMDIClientに形変更 -> Formの中のMdiClientを検索
                if (mdiClient != null) // 形変更ができたら
                {
                    se.ReleaseHandle(); //基のHandlerをオフする
                    se.AssignHandle(mdiClient.Handle); //FormのMdiClientにHandlerを再定義
                }
                else
                {
                    //技能なし
                }
            }
        }

    }
}
