using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;
using System.IO;

namespace WordCat
{
    public partial class ExtensionManager : Form
    {

        Form1 calling_form;

        public ExtensionManager(Form caller)
        {
            InitializeComponent();

            calling_form = (Form1)caller;

        }

        public string[] loc = new string[100];

        public string[] folder = new string[100];
        public string[] name = new string[100];
        public string[] version = new string[100];
        public string[] type = new string[100];
        public string[] icon = new string[100];
        public string[] text = new string[100];
        public string[] open = new string[100];


        private void ExtensionManager_Load(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Blob-IDE\\Data\\config\\extension_list.txt");
            StreamReader sr1 = new StreamReader("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Blob-IDE\\Data\\config\\extension_checkstates.txt");

            int i = 0;
            string XmlFilePath = "";

            while (!sr.EndOfStream)
            {

                XmlFilePath = sr.ReadLine();
                if (XmlFilePath != "")
                {
                    Ext_Load(XmlFilePath);
                }

                if (!sr1.EndOfStream)
                {
                    if (sr1.ReadLine().ToLower() == "true")
                    {
                        checkedListBox1.SetItemCheckState(i, System.Windows.Forms.CheckState.Checked);
                    }
                    else
                    {
                        checkedListBox1.SetItemCheckState(i, System.Windows.Forms.CheckState.Unchecked);
                    }

                }
                else
                {
                    MessageBox.Show("Missing entry in file for check states. " + i.ToString());
                }

                i++;
            }


            sr.Close();
            sr1.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string filename;

                filename = openFileDialog1.FileName;
                Ext_Load(filename);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((checkedListBox1.SelectedIndex >= 0) && (checkedListBox1.SelectedIndex <= 100))
            { 
                if (checkedListBox1.GetItemCheckState(checkedListBox1.SelectedIndex) == CheckState.Checked)
                {
                    label1.Text = "Name : " + name[checkedListBox1.SelectedIndex] + "\nVersion : " + version[checkedListBox1.SelectedIndex] + "\n\nActive";
                }
                else
                {
                    label1.Text = "Name : " + name[checkedListBox1.SelectedIndex] + "\nVersion : " + version[checkedListBox1.SelectedIndex] + "\n\nInactive";
                }
                
                label1.ForeColor = Color.Black;
                button2.Enabled = true;
            }
            else
            {

                button2.Enabled = false;
                label1.Text = "No Item Selected!";
                label1.ForeColor = Color.Red;

            }

        }




        private void remove_EXT_Click(object sender, EventArgs e)
        {
            if ((checkedListBox1.SelectedIndex >= 0) && (checkedListBox1.SelectedIndex <= 100))
            {

                int DelPosition = checkedListBox1.SelectedIndex;

                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);

                for (; DelPosition <= checkedListBox1.Items.Count; DelPosition++)
                {
                    folder[DelPosition] = folder[DelPosition + 1];
                    name[DelPosition] = name[DelPosition + 1];
                    version[DelPosition] = version[DelPosition + 1];
                    type[DelPosition] = type[DelPosition + 1];
                    icon[DelPosition] = icon[DelPosition + 1];
                    text[DelPosition] = text[DelPosition + 1];
                    open[DelPosition] = open[DelPosition + 1];
                    loc[DelPosition] = loc[DelPosition + 1];

                }

            }
            else
            {

                MessageBox.Show("No Item Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "No Item Selected!";
                label1.ForeColor = Color.Red;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Folder : " + folder[checkedListBox1.SelectedIndex] + "\nName : " + name[checkedListBox1.SelectedIndex] + "\nVersion : " + version[checkedListBox1.SelectedIndex] + "\nType : " + type[checkedListBox1.SelectedIndex] + "\nText : " + text[checkedListBox1.SelectedIndex] + "\nRun : " + open[checkedListBox1.SelectedIndex] + "\nIcon Path : " + icon[checkedListBox1.SelectedIndex] + "\nLocation : " + loc[checkedListBox1.SelectedIndex], "Extension Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Blob-IDE\\Data\\config\\extension_list.txt");
            StreamWriter sw1 = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Blob-IDE\\Data\\config\\extension_checkstates.txt");

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                sw.WriteLine(loc[i]);
                sw1.WriteLine(checkedListBox1.GetItemChecked(i));
            }
            sw.Close();
            sw1.Close();
        }

        private void neew_EXT_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Blob-IDE\\Data\\extensions");
        }

        private void ExtensionManager_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true;

            this.WindowState = FormWindowState.Minimized;
            //this.Hide();
        }




        public void Ext_Load(string location)
        {

            string icon_read = "";

            XmlReader reader = XmlReader.Create(location);

            while (reader.Read())
            {

                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "folder"))
                {

                    if (reader.HasAttributes)
                    {

                        folder[checkedListBox1.Items.Count] = reader.GetAttribute("string");

                    }

                }
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "name"))
                {

                    if (reader.HasAttributes)
                    {

                        name[checkedListBox1.Items.Count] = reader.GetAttribute("string");

                    }

                }
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "version"))
                {

                    if (reader.HasAttributes)
                    {

                        version[checkedListBox1.Items.Count] = reader.GetAttribute("string");

                    }

                }
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "type"))
                {

                    if (reader.HasAttributes)
                    {

                        type[checkedListBox1.Items.Count] = reader.GetAttribute("value");

                    }

                }
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "icon"))
                {

                    if (reader.HasAttributes)
                    {

                        icon_read = reader.GetAttribute("path");

                    }

                }
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "text"))
                {

                    if (reader.HasAttributes)
                    {

                        text[checkedListBox1.Items.Count] = reader.GetAttribute("string");

                    }

                }
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "open"))
                {

                    if (reader.HasAttributes)
                    {

                        open[checkedListBox1.Items.Count] = reader.GetAttribute("path");

                    }

                }


                loc[checkedListBox1.Items.Count] = location;

                icon[checkedListBox1.Items.Count] = loc[checkedListBox1.Items.Count] + "\\" + icon_read;

            }

            checkedListBox1.Items.Add(name[checkedListBox1.Items.Count] + " " + version[checkedListBox1.Items.Count].ToString());

        }


    }
}
