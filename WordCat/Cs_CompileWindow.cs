using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WordCat
{



    public partial class Cs_CompileWindow : Form
    {

        string path;

        public Cs_CompileWindow()
        {
            InitializeComponent();

        }

        private void Cs_CopileWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName_Out = textBox1.Text;
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters compars = new CompilerParameters();

            compars.GenerateExecutable = true;
            compars.OutputAssembly = fileName_Out;
            compars.GenerateInMemory = false;
            compars.TreatWarningsAsErrors = false;

            CompilerResults res = provider.CompileAssemblyFromFile(compars, path);

            if(res.Errors.Count > 0)
            {
                foreach (CompilerError ce in res.Errors)
                {

                    textBox3.AppendText(ce.ToString());

                }

            }
            else
            {

                textBox3.Clear();
                textBox3.Text = "File compiled! The is file saved here :   " + Application.StartupPath + "\\" + textBox1.Text;
                Process.Start(Application.StartupPath + "\\" + textBox1.Text);


            }
            
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSharp-Files|*.cs";
            ofd.Title = "Open File";

            if(ofd.ShowDialog() == DialogResult.OK)
            {

                path = ofd.FileName;
                textBox2.Text = path;

            }
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FreshPlayer/WordCat/Blob-IDE/Compile-Code");
        }
    }
}
