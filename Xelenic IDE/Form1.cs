using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
