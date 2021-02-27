using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WordCat
{
    public partial class VB_CompileWindow : Form
    {
        public VB_CompileWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Visual Basic-Files|*.vb";
            ofd.Title = "Select file";

            if(ofd.ShowDialog() == DialogResult.OK)
            {

                textBox1.Text = ofd.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter("C:\\Users\\" + Environment.UserName  + "\\appdata\\roaming\\Blob-IDE\\Data\\compile\\vbc\\locate.txt");
            sw.WriteLine(textBox1.Text);
            sw.Close();

            Process.Start("C:\\Users\\" + Environment.UserName  + "\\appdata\\roaming\\Blob-IDE\\Data\\compile\\vbc\\Compile.cmd");
        }
    }
}
