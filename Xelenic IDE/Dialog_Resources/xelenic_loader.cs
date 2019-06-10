using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Xelenic_IDE.Dialog_Resources
{
    public partial class xelenic_loader : SplashScreen
    {
        public xelenic_loader()
        {
            InitializeComponent();           
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {

        }

        private void xelenic_loader_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Form mainfom = new Form1();
            this.Hide();
            mainfom.Show();
                     
            
        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelControl3.Text = "Scaning Services..";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            labelControl3.Text = "Connect Package Core..";
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            labelControl3.Text = "Look let Manager Styles Cmake..";
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }
    }
}