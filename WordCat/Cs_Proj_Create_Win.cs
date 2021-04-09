using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WordCat
{
    public partial class Cs_Proj_Create_Win : Form
    {


        Editor calling_form;


        public Cs_Proj_Create_Win(Form caller)
        {
            InitializeComponent();
            calling_form = (Editor)caller;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (project_Name_Text.Text == string.Empty)
            {

                this.Text = "New C# Project";

            }
            else
            {

                this.Text = "New C# Project - " + project_Name_Text.Text;

            }
        }

        private void Cs_Proj_Create_Win_Load(object sender, EventArgs e)
        {
            Random rndm = new Random();
            project_Name_Text.Text = "New Project #" + rndm.Next(1, 9999).ToString();

            creator_Text.Text = Environment.UserName.ToString();

            path_Text.Text = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Blob-IDE\\Data\\Projects\\";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            
            if(fbd.ShowDialog() == DialogResult.OK)
            {

                path_Text.Text = fbd.SelectedPath;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (project_Name_Text.Text != string.Empty)
            {
                if (Directory.Exists(path_Text.Text))
                {
                    string create_path = path_Text.Text + project_Name_Text.Text + "\\";

                    Directory.CreateDirectory(create_path);

                    StreamWriter sw1 = new StreamWriter(create_path + "Project.xml");
                    sw1.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    sw1.WriteLine("<project>");
                    sw1.WriteLine("  <info>");
                    sw1.WriteLine("    <name value=\"" + project_Name_Text.Text + "\" />");
                    sw1.WriteLine("    <creator value=\"" + creator_Text.Text + "\" />");
                    sw1.WriteLine("    <type value=\"C# Project\" />");
                    sw1.WriteLine("  </info>");
                    sw1.WriteLine("</project>");
                    sw1.Close();

                    StreamWriter sw2 = new StreamWriter(create_path + "AssemblyInfo.cs");
                    sw2.WriteLine("using System.Reflection;");
                    sw2.WriteLine("using System.Runtime.CompilerServices;");
                    sw2.WriteLine("using System.Runtime.InteropServices;");
                    sw2.WriteLine("");
                    sw2.WriteLine("");
                    sw2.WriteLine("[assembly: AssemblyTitle(" + program_Name_Text.Text + ")]");
                    sw2.WriteLine("[assembly: AssemblyDescription(\"\")]");
                    sw2.WriteLine("[assembly: AssemblyConfiguration(\"\")]");
                    sw2.WriteLine("[assembly: AssemblyCompany(" + creator_Text + ")]");
                    sw2.WriteLine("[assembly: AssemblyProduct(" + program_Name_Text + ")]");
                    sw2.WriteLine("[assembly: AssemblyCopyright(\"Copyright ©" + creator_Text + "2021\")]");
                    sw2.WriteLine("[assembly: AssemblyTrademark(\"\")]");
                    sw2.WriteLine("[assembly: AssemblyCulture(\"\")]");
                    sw2.WriteLine("");
                    sw2.WriteLine("");
                    sw2.WriteLine("[assembly: ComVisible(false)]");
                    sw2.WriteLine("");
                    sw2.WriteLine("");
                    sw2.WriteLine("[assembly: AssemblyVersion(\"1.0.0.0\")]");
                    sw2.WriteLine("[assembly: AssemblyFileVersion(\"1.0.0.0\")]");
                    sw2.Close();

                    StreamWriter sw3 = new StreamWriter(create_path + "Program.cs");
                    sw3.WriteLine("using System;\nusing System.Collections.Generic;\nusing System.Text;\n\nnamespace newConsoleApp\n{     \n    class Program\n   {\n\n       static void Main(string[] args)\n       {\n             Console.WriteLine(\"Hello World!\");\n             Console.ReadLine();\n       }\n\n   }\n\n}");
                    sw3.Close();

                    File.Copy("C:\\users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\resources\\Project.csproj", path_Text.Text + project_Name_Text.Text + "\\Project.csproj");

                    calling_form.open_project(path_Text.Text + project_Name_Text.Text, "program.cs");

                    this.Close();
                }
                else
                {

                    MessageBox.Show("Path does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {

                MessageBox.Show("No project name!\nYou need to name the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
