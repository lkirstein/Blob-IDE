using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Configuration;
using System.Reflection;
using System.IO;

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

            Console.Title = "Blob IDE Output  -  State : Running";

            bool noParamStart = true;

            var language = ConfigurationManager.AppSettings["language"];

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);

            string version = "3.0.0.0";

            int i;


            bool enableVisualStyles = true;
            for (i = 0; i < argv.Length; i++)
            {

                if (argv[i] == "-draw")
                {
                    noParamStart = false;


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Starting!");


                    Application.EnableVisualStyles();
                    Application.Run(new GraphEdit());

                }
                if (argv[i] == "-console")
                {
                    noParamStart = false;

                    Console.WriteLine("Open BLOB-IDE -> Options -> Application -> Consolestart (check this) -> Save and close -> Restart Application");

                }
                if (argv[i] == "-nosplash")
                {

                    noParamStart = false;

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Starting without splashscreen...\n");


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Enabled Visual Styles");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Starting!");

                    Application.EnableVisualStyles();
                    Application.Run(new Form1());


                }
                if (argv[i] == "-colorpicker")
                {


                    noParamStart = false;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Checking if colorpicker exists ...");

                    if (File.Exists(Application.StartupPath + "\\BlobIDE_ColorPicker.exe") == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Colorpciker exists!\nStarting..!");

                        Process.Start(Application.StartupPath + "\\BlobIDE_ColorPicker.exe");
                    }

                }
                if (argv[i] == "-encrypt")
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Starting!");


                    noParamStart = false;

                    Application.EnableVisualStyles();
                    Application.Run(new MD5_encryption());

                }
                if (argv[i] == "-decrypt")
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Starting!");


                    noParamStart = false;

                    Application.EnableVisualStyles();
                    Application.Run(new MD5_decryption());

                }
                if (argv[i] == "-compileCS")
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Starting!");


                    noParamStart = false;

                    Application.EnableVisualStyles();
                    Application.Run(new Cs_CompileWindow());

                }
                if (argv[i] == "-compileVB")
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Starting!");


                    noParamStart = false;

                    Application.EnableVisualStyles();
                    Application.Run(new VB_CompileWindow());

                }
                if (argv[i] == "-dvs")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Set Visual Styles to disabled.");
                    enableVisualStyles = false;

                }
                else if (argv[i] == "-github")
                {

                    Process.Start("https://github.com/FreshPlayer/Blob-IDE");

                }
                else if (argv[i] == "-help")
                {

                    Process.Start("https://github.com/FreshPlayer/Blob-IDE/wiki");

                }
                else if(argv[i] == "-parameter")
                {
                    noParamStart = false;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\nHelp for parameters : \n\n-parameters        Shows this list.\n-help        Opens the Wikipage.\n-github        Opens the github-repo.\n-dvs        Disables Visual Styles\n-compileCS        Opens the C# compiler tool.\n-compileVB        Opens the VB compiler tool.\n-encypt        Opens the encrypt tool\n-decrypt        Opens the decrypt tool\n-colorpicker        Opens the colorpicker tool.\n-draw         Opens the (very bad) Drawingtool.\n-nosplash        Starts the application, without the Splash screen, even if the option in the program is checked.\n");

                }

            }





            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\ConsoleStart") == false)
            {


                if (noParamStart == true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("NoParameterStart = true");


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Langage : \"" + language + "\"");




                    Application.SetCompatibleTextRenderingDefault(false);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("SetCompatibleTextRenderingDefault(false)");

                    if (enableVisualStyles)
                    {

                        Application.EnableVisualStyles();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Visual Styles : ENABLED");

                    }
                    if (enableVisualStyles == false)
                    {

                        Console.WriteLine("Visual Styles : DISABLED OR NO VALUE");

                    }


                    if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Starting!");
                        Application.Run(new SplashScreen());

                    }
                    if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen") == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Starting!");
                        Application.Run(new Form1());
                    }
                }
                if (noParamStart == false)
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("NoParameterStart = false");

                }
            }
            if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\ConsoleStart") == true)
            {

            ConsoleStart:

                Console.Title = "Blob IDE Console  -  State : Running";

                Console.WriteLine("\"Console Start\" is activated.\nIf you want to start the application, enter \"load\".\nIf you need help with Commands, type \"help\"\nYou can try some repair options, if you have some problems with errors.\n\n");
                bool input_avalible = false;
                Console.Write("User (" + Environment.UserName + ") >> ");
                string input = Console.ReadLine();
                input_avalible = true;


            ConsoleMain:
                if(input_avalible == false)
                {
                    Console.Write("User (" + Environment.UserName + ") >> ");
                    input = Console.ReadLine();
                }
                if(input_avalible = true)
                {

                    //nothing in here

                }






                if (input == "help")
                {
                    input_avalible = false;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n--- HELP ----------\n\nload            Starts the editor\nabout           Displays informations about the program\nrepair /av      Check if the files for a repair are avalible\nrepair /set     Resets the ENTIRE settings.\nrestart         Restarts the application\nhelp            Shows this list\ncls             Clears the console\nexit            Closes the program\n\n--- HELP ----------\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    goto ConsoleMain;

                }
                if (input == "about")
                {

                    input_avalible = false;



                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n--- ABOUT ----------\n\nCreator : FreshPlayer_YT\nApplication name : Blob IDE\nVersion : " + version + "\n\n--- ABOUT ----------\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    goto ConsoleMain;

                }
                if (input == "restart")
                {

                    input_avalible = false;

                    Application.Restart();


                }
                if (input == "repair /av")
                {

                    input_avalible = false;

                    if (Directory.Exists(Application.StartupPath + "\\backups\\Data") == true)
                    {

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The resources are avalible. You can repair the program, if you need to.");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The files for a repair are MISSING!");
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    goto ConsoleMain;

                }
                if (input == "repair /set")
                {

                    input_avalible = false;

                    if (Directory.Exists(Application.StartupPath + "\\backups\\Data") == true)
                    {

                        File.Delete("C:\\Users\\" + Environment.UserName + "\\appdata\\roaming\\Blob-IDE\\Data\\config\\checkboxes.txt");
                        File.Copy(Application.StartupPath + "\\backups\\Data\\config\\checkboxes.txt", "C:\\Users\\" + Environment.UserName + "\\appdata\\roaming\\Blob-IDE\\Data\\config\\checkboxes.txt");


                        File.Delete("C:\\Users\\" + Environment.UserName + "\\appdata\\roaming\\Blob-IDE\\Data\\config\\language.txt");
                        File.Copy(Application.StartupPath + "\\backups\\Data\\config\\language.txt", "C:\\Users\\" + Environment.UserName + "\\appdata\\roaming\\Blob-IDE\\Data\\config\\language.txt");


                        File.Delete("C:\\Users\\" + Environment.UserName + "\\appdata\\roaming\\Blob-IDE\\Data\\config\\options\\save_img.txt");
                        File.Copy(Application.StartupPath + "\\backups\\Data\\config\\options\\save_img.txt", "C:\\Users\\" + Environment.UserName + "\\appdata\\roaming\\Blob-IDE\\Data\\config\\options\\save_img.txt");

                        if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\ConsoleStart") == true)
                        {

                            File.Delete("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\ConsoleStart");

                        }
                        if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen") == false)
                        {

                            File.Copy(Application.StartupPath + "\\backups\\Data\\config\\options\\SplashScreen", "C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen");

                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("repair was successful!");
                        Console.ForegroundColor = ConsoleColor.White;

                        goto ConsoleMain;

                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Could not repair! The backup-files / folders are missing!");
                        Console.ForegroundColor = ConsoleColor.White;


                        goto ConsoleMain;
                    }
                }
                if (input == "cls")
                {

                    input_avalible = false;
                    Console.Clear();

                    goto ConsoleMain;

                }
                if (input == "exit")
                {

                    input_avalible = false;
                    Application.ExitThread();

                }
                if(input == "load")
                {
                    Console.Clear();
                    Console.Title = "Blob IDE Output  -  State : Running";

                    if (noParamStart == true)
                    {
                        input_avalible = false;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("NoParameterStart = true");


                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Langage : \"" + language + "\"");




                        Application.SetCompatibleTextRenderingDefault(false);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("SetCompatibleTextRenderingDefault(false)");

                        if (enableVisualStyles)
                        {

                            Application.EnableVisualStyles();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Visual Styles : ENABLED");

                        }
                        if (enableVisualStyles == false)
                        {

                            Console.WriteLine("Visual Styles : DISABLED OR NO VALUE");

                        }


                        if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Starting!");
                            Application.Run(new SplashScreen());

                        }
                        if (File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\SplashScreen") == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Starting!");
                            Application.Run(new Form1());
                        }
                    }
                    if (noParamStart == false)
                    {

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("NoParameterStart = false");

                    }

                }




                if ((input != "load" ) && (input != "cls") && (input != "exit") && (input != "help") && (input != "restart") && (input != "repair /set") && (input != "repair /av") && (input != "about"))
                {
                    input_avalible = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("This is an invalid command!");
                    Console.ForegroundColor = ConsoleColor.White;

                    goto ConsoleMain;

                }



            }





            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
