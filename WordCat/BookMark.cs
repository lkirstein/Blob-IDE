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
    public partial class BookMark : Form
    {

        Form1 calling_form;

        public BookMark(Form caller)
        {
            InitializeComponent();
            calling_form = (Form1)caller;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal lineNum = numericUpDown1.Value;
            int lineInt = Convert.ToInt32(lineNum);
            calling_form.bookmark(lineInt);
        }
    }
}
