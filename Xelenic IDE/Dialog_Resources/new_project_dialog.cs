using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Xelenic_IDE.Dialog_Resources
{
    public partial class New_Project_Wizard : DevExpress.XtraEditors.XtraForm
    {
        public New_Project_Wizard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xtraFolderBrowserDialog1.ShowDialog();
        }

        private void New_Project_Wizard_Load(object sender, EventArgs e)
        {
            
            textEdit3.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Tasks";
       

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void xtraFolderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            textEdit3.Text = textEdit3.Text + "\\" + textEdit1.Text;
        }
    }
}