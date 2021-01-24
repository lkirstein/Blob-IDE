using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace WordCat
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] argv)
        {

            int i;


            bool enableVisualStyles = true;
            for (i = 0; i < argv.Length; i++)
            {

                if (argv[i] == "-dvs")
                {

                    enableVisualStyles = false;

                }
                else if (argv[i] == "-github")
                {

                    Process.Start("https://github.com/FreshPlayer/WordCat");

                }
                else if (argv[i] == "-help")
                {

                    Process.Start("https://github.com/FreshPlayer/WordCat/blob/ROOT/HELP.md");

                }

            }


            if(enableVisualStyles)
            {

                Application.EnableVisualStyles();

            }

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
