using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WordCat
{
    public partial class SplashScreen : Form
    {



        public SplashScreen()
        {
            InitializeComponent();

        }



        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            this.Hide();
            this.ShowInTaskbar = false;

            timer1.Stop();


            Editor f1 = new Editor(string.Empty);
            f1.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
