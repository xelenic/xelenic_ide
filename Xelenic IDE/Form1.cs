using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xelenic_IDE
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form new_project_form = new Dialog_Resources.New_Project_Wizard();
            new_project_form.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form reload_xelenic = new Dialog_Resources.xelenic_loader();
            reload_xelenic.Close();
            reload_xelenic.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\project\\untitle.c");
            txt.Write(fastColoredTextBox1.Text);
            txt.Close();

            string strCmdText;
            strCmdText = "/C gcc C:\\project\\untitle.c ";

            this.Text = strCmdText;
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            //System.Diagnostics.Process p = new System.Diagnostics.Process();

            //p.Start("IExplore.exe", "www.northwindtraders.com");

           // p.StartInfo.CreateNoWindow = true;
            




        }
    }
}
