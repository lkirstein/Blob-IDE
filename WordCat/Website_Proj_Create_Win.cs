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
    public partial class Website_Proj_Create_Win : Form
    {

        Editor calling_form;

        public Website_Proj_Create_Win(Form caller)
        {
            InitializeComponent();
            calling_form = (Editor)caller;
        }

        private void Website_Proj_Create_Win_Load(object sender, EventArgs e)
        {
            Random rndm = new Random();
            name_Text.Text = "New Project #" + rndm.Next(1, 9999);

            creator_Text.Text = Environment.UserName;

            path_Text.Text = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Blob-IDE\\Data\\projects\\";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (name_Text.Text == string.Empty)
            {

                this.Text = "New Website Project";

            }
            else
            {

                this.Text = "New Website Project - " + name_Text.Text;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {

                path_Text.Text = fbd.SelectedPath;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (name_Text.Text != string.Empty)
            {
                if (Directory.Exists(path_Text.Text))
                {
                    string create_path = path_Text.Text + name_Text.Text + "\\";

                    Directory.CreateDirectory(create_path);

                    StreamWriter sw1 = new StreamWriter(create_path + "Project.xml");
                    sw1.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    sw1.WriteLine("<project>");
                    sw1.WriteLine("  <info>");
                    sw1.WriteLine("    <name value=\"" + name_Text.Text + "\" />");
                    sw1.WriteLine("    <creator value=\"" + creator_Text.Text + "\" />");
                    sw1.WriteLine("    <type value=\"HTML Website Project\" />");
                    sw1.WriteLine("  </info>");
                    sw1.WriteLine("</project>");
                    sw1.Close();

                    StreamWriter sw2 = new StreamWriter(create_path + "index.html");
                    sw2.WriteLine("<html>");
                    sw2.WriteLine(" <head>");
                    sw2.WriteLine("");
                    sw2.WriteLine("  <title>Website</title>");
                    if (checkBox2.Checked)
                    {
                        sw2.WriteLine("  <link rel=\"stylesheet\" href=\"styles.css\">");
                    }
                    if (checkBox1.Checked)
                    {
                        sw2.WriteLine("  <link rel=\"shortcut icon\" type=\"image / x - icon\" href=\"favicon.ico\">");
                    }
                    sw2.WriteLine("");
                    sw2.WriteLine("");
                    sw2.WriteLine("  <meta name=\"description\" content=\"\">");
                    sw2.WriteLine("  <meta name=\"author\" content=\"" + creator_Text.Text + "\">");
                    sw2.WriteLine("");
                    sw2.WriteLine(" </head>");
                    sw2.WriteLine(" <body>");
                    sw2.WriteLine("");
                    sw2.WriteLine("   <h1>Lorem ipsum</h1>");
                    sw2.WriteLine("");
                    sw2.WriteLine(" </body>");
                    sw2.WriteLine("</html>");
                    sw2.Close();

                    if (checkBox2.Checked)
                    {
                        StreamWriter sw3 = new StreamWriter(create_path + "styles.css");
                        sw3.WriteLine("body {\n  font-family: Arial, Helvetica, sans-serif;\n  margin: 0;\n}");
                        sw3.Close();
                    }

                    if (checkBox1.Checked)
                    {
                        File.Copy("C:\\users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\resources\\favicon.ico", path_Text.Text + name_Text.Text + "\\favicon.ico");
                    }

                    calling_form.open_project(path_Text.Text + name_Text.Text, "index.html");

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
