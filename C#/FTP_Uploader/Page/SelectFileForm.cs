using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTP_Uploader_2.Page
{
    public partial class SelectFileForm : Form
    {
        MainForm parent;
        Dictionary<String, TreeNode> files;
        public SelectFileForm(MainForm main, Dictionary<String, TreeNode> dic)
        {
            InitializeComponent();
            files = dic;
            parent = main;
            this.parent = main;
        }


        private void SelectFileForm_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<String, TreeNode> kvp in files)
            {
                cbxBox.Items.Add(kvp.Key);
            }
        }

        /// <summary>
        /// Form Closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int index = cbxBox.SelectedIndex;
            
            if(index != -1)
            {
                parent.selectIndex = index;
                this.Close();
            }
        }
    }
}
