using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WordCat
{
    public partial class Optns_Window : Form
    {
        public Optns_Window()
        {
            InitializeComponent();
        }

        string program_name = "Blob IDE";
        string version = "v3";

        ChangeLanguage_Class changeLang = new ChangeLanguage_Class();

        private void Optns_Window_Load(object sender, EventArgs e)
        {
            this.Text = program_name + " " + version + " Options" ;

            StreamReader sr1 = new StreamReader("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\save_img.txt");
            string read_save_imgs = "disks";
            read_save_imgs = sr1.ReadLine();
            sr1.Close();

            if (read_save_imgs == "disks")
            {
                radioButton_saveImg_disks.Checked = true;
            }
            else if (read_save_imgs == "hdd")
            {
                radioButton_saveImg_HDD.Checked = true;
            }



            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen"))
            {
                checkBox1.Checked = true;
            }
            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen") == false)
            {
                checkBox1.Checked = false;
            }


            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\ConsoleStart"))
            {
                checkBox2.Checked = true;
            }
            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\ConsoleStart") == false)
            {
                checkBox2.Checked = false;
            }

        }

        private void Optns_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
           //EMPTY
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(select_LANG_comboBox.SelectedIndex == 0)
            {

                changeLang.UpdateConfig("language", "en-US");

            }
            if (select_LANG_comboBox.SelectedIndex == 1)
            {

                changeLang.UpdateConfig("language", "de-DE");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw1 = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\save_img.txt");
            if (radioButton_saveImg_disks.Checked)
            {
                sw1.WriteLine("disks");
            }
            else if (radioButton_saveImg_HDD.Checked)
            {
                sw1.WriteLine("hdd");
            }
            sw1.Close();





            if(checkBox1.Checked == true)
            {

                File.Create("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen");

            }

            if (checkBox1.Checked == false)
            {

                File.Delete("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen");

            }


            if (checkBox2.Checked == true)
            {

                File.Create("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\ConsoleStart");

            }

            if (checkBox2.Checked == false)
            {

                File.Delete("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\ConsoleStart");

            }


            if (Thread.CurrentThread.CurrentCulture.Name == "en-US")
            {
                if(MessageBox.Show("The settings will apply after you restarted the IDE. If you did change some settings you need to restart. Do you want to restart now?", program_name + " " + version, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Application.Restart();

                }
            }
            if (Thread.CurrentThread.CurrentCulture.Name == "de-DE")
            {
                if(MessageBox.Show("Die Einstellungen werden in kraft treten, wenn sie die IDE das nächst mal starten. Wenn sie änderungen vorgenommen haben müssen sie das Programm neustarten. Wollen sie jetzt neustarten?", program_name + " " + version, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Application.Restart();

                }
            }
            this.Close();

        }
    }
}
