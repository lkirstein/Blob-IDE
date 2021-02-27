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
    public partial class HTML_Browser : Form
    {

        string path;

        public HTML_Browser(string caller_path)
        {
            InitializeComponent();
            path = (string)caller_path;
        }



        public void refresh()
        {

            webBrowser1.Refresh();

        }

        private void HTML_Browser_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(path);
        }
    }
}
