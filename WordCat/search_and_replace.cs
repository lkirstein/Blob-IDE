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
    public partial class search_and_replace : Form
    {

        string search;
        Form1 calling_form;
        int insert_position = 0;

        public search_and_replace(Form caller)
        {
            InitializeComponent();
            calling_form = (Form1)caller;
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

                MessageBox.Show("Error : \"" + textBox1.Text + "\" Not found!", "WordCat", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(calling_form.search_and_select(textBox2.Text, checkBox2.Checked) == false)
            {

                MessageBox.Show("Error : \"" + textBox2.Text + "\" Not found!", "WordCat", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
