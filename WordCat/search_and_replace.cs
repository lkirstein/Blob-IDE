using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WordCat
{
    public partial class search_and_replace : Form
    {

        string progam_name = "WordCat";

        string search;
        Editor calling_form;
        int insert_position = 0;

        public search_and_replace(Form caller)
        {
            InitializeComponent();
            calling_form = (Editor)caller;
        }


        /*public string get_search_string()
        {

            this.Show();
            return (textBox1.Text);


        }*/

        private void button1_Click(object sender, EventArgs e)
        {

            if(calling_form.search_and_select(textBox1.Text, checkBox1.Checked) == false)
            {


                if (Thread.CurrentThread.CurrentCulture.Name == "en-US")
                {
                    MessageBox.Show("Error : \"" + textBox1.Text + "\" Not found!", progam_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Thread.CurrentThread.CurrentCulture.Name == "de-DE")
                {
                    MessageBox.Show("Fehler : \"" + textBox1.Text + "\" konnte nicht gefunden werden.", progam_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(calling_form.search_and_select(textBox2.Text, checkBox2.Checked) == false)
            {


                if (Thread.CurrentThread.CurrentCulture.Name == "en-US")
                {
                    MessageBox.Show("Error : \"" + textBox1.Text + "\" Not found!", progam_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Thread.CurrentThread.CurrentCulture.Name == "de-DE")
                {
                    MessageBox.Show("Fehler : \"" + textBox1.Text + "\" konnte nicht gefunden werden.", progam_name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calling_form.replace(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            calling_form.replace(textBox3.Text);
          
        }

        private void search_and_replace_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
        

        private void search_and_replace_Shown(object sender, EventArgs e)
        {

            textBox1.Focus();

        }

        private void search_and_replace_Load(object sender, EventArgs e)
        {

        }
    }
}
