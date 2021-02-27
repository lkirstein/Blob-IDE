using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordCat
{
    public partial class Loading_Form : Form
    {
        public Loading_Form()
        {
            InitializeComponent();
        }

        int move;
        int moveX;
        int moveY;

        string program_name = "Blob IDE";
        string version = "3";

        private void Loading_Form_Load(object sender, EventArgs e)
        {
            this.Text = program_name + " " + version;
            label2.Text = program_name + " " + version;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {

                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);

            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }


    }
}
