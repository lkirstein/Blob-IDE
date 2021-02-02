using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Printing;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;
using System.Xml;

namespace WordCat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Int for ln & col
        int line;
        int column;

        //Strings
        string version = "2";
        string Path = "";

            //Search and replace strings
            string search_string;

        //Checkbox Bool

        string acc_tab = "true";
        string det_links = "false";
        string read_only = "false";
        string word_wrap = "false";

        string startup_lang = "TEXT";

        //TEXT TO SPEECH
        SpeechSynthesizer sp = new SpeechSynthesizer();


        //XML THEMES
        string editText_textcolor = "";
        string editText_color = "";
        string theme_name = "";
        string theme_author = "";


        //EDITOR ACTIONS




        private void cutToolStripButton_contextMenu_Click(object sender, EventArgs e)
            {
                richTextBox1.Cut();
            }

            private void copyToolStripButton_contextMenu_Click(object sender, EventArgs e)
            {
                richTextBox1.Copy();
            }

            private void pasteToolStripButton_contextMenu_Click(object sender, EventArgs e)
            {
                richTextBox1.Paste();
            }

            private void undoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                richTextBox1.Undo();
            }

            private void redoToolStripMenuItem_Click(object sender, EventArgs e)
            {
                richTextBox1.Redo();
            }

            private void cutToolStripMenuItem_Click(object sender, EventArgs e)
            {
                richTextBox1.Cut();
            }

            private void copyToolStripMenuItem_Click(object sender, EventArgs e)
            {
                richTextBox1.Copy();
            }

            private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                richTextBox1.Paste();
            }

            private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
            {
                richTextBox1.SelectAll();
            }
        //EDITOR ACTIONS.


        //FORM1
            private void Form1_Load(object sender, EventArgs e)
            {

                explorer1.Navigate("C:\\users\\" + Environment.UserName);



                sp.SelectVoiceByHints(VoiceGender.Male);

                timer1.Start();

                this.Text = "WordCat " + version;

                font_label.Text = "Font : " + richTextBox1.Font.Name;


                //Read Checkboxes
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Data\\config\\checkboxes.txt");
                acc_tab = sr.ReadLine();
                read_only = sr.ReadLine();
                word_wrap = sr.ReadLine();
                sr.Close();

                    if(acc_tab == "True")
                    {

                        checkBox_acc_tab.Checked = true;
                
                    }
                    if (read_only == "True")
                    {

                        checkBox_readOnly.Checked = true;

                    }
                    if (word_wrap == "True")
                    {

                        checkBox_wordWrap.Checked = true;

                    }



                    else if (acc_tab == "False")
                    {

                        checkBox_acc_tab.Checked = false;
                        richTextBox1.AcceptsTab = false;

                    }
                    else if (read_only == "False")
                    {

                        checkBox_readOnly.Checked = false;

                    }
                    else if (word_wrap == "False")
                    {

                         checkBox_wordWrap.Checked = false;

                    }

                string lang_select;

                StreamReader sr1 = new StreamReader(Application.StartupPath + "\\Data\\config\\language.txt");
                lang_select = sr1.ReadLine();
                if (lang_select == "TEXT")
                {
                    textToolStripMenuItem.Checked = true;
                    richTextBox1.Language = FastColoredTextBoxNS.Language.Custom;

                    hTMLToolStripMenuItem.Checked = false;
                    xMLToolStripMenuItem.Checked = false;
                    jSToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    viToolStripMenuItem.Checked = false;
                    cToolStripMenuItem1.Visible = false;
                }
                else if (lang_select == "HTML")
                {
                    hTMLToolStripMenuItem.Checked = true;
                    richTextBox1.Language = FastColoredTextBoxNS.Language.HTML;

                    textToolStripMenuItem.Checked = false;
                    xMLToolStripMenuItem.Checked = false;
                    jSToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    viToolStripMenuItem.Checked = false;
                    cToolStripMenuItem1.Visible = false;
                }
                else if (lang_select == "XML")
                {
                    xMLToolStripMenuItem.Checked = true;
                    richTextBox1.Language = FastColoredTextBoxNS.Language.XML;

                    textToolStripMenuItem.Checked = false;
                    hTMLToolStripMenuItem.Checked = false;
                    jSToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    viToolStripMenuItem.Checked = false;
                    cToolStripMenuItem1.Visible = false;
                }
                else if (lang_select == "JS")
                {
                    jSToolStripMenuItem.Checked = true;
                    richTextBox1.Language = FastColoredTextBoxNS.Language.JS;

                    hTMLToolStripMenuItem.Checked = false;
                    xMLToolStripMenuItem.Checked = false;
                    textToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    viToolStripMenuItem.Checked = false;
                    cToolStripMenuItem1.Visible = false;
                }
                else if (lang_select == "PHP")
                {
                    pHPToolStripMenuItem.Checked = true;
                    richTextBox1.Language = FastColoredTextBoxNS.Language.PHP;

                    hTMLToolStripMenuItem.Checked = false;
                    xMLToolStripMenuItem.Checked = false;
                    jSToolStripMenuItem.Checked = false;
                    textToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    viToolStripMenuItem.Checked = false;
                    cToolStripMenuItem1.Visible = false;
                }
                else if (lang_select == "CSharp")
                {
                    cToolStripMenuItem.Checked = true;
                    cToolStripMenuItem1.Visible = true;
                    richTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;

                    hTMLToolStripMenuItem.Checked = false;
                    xMLToolStripMenuItem.Checked = false;
                    jSToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    textToolStripMenuItem.Checked = false;
                    viToolStripMenuItem.Checked = false;
                }
                else if (lang_select == "VB")
                {
                    viToolStripMenuItem.Checked = true;
                    cToolStripMenuItem1.Visible = false;
                    richTextBox1.Language = FastColoredTextBoxNS.Language.VB;

                    hTMLToolStripMenuItem.Checked = false;
                    xMLToolStripMenuItem.Checked = false;
                    jSToolStripMenuItem.Checked = false;
                    pHPToolStripMenuItem.Checked = false;
                    cToolStripMenuItem.Checked = false;
                    textToolStripMenuItem.Checked = false;
                }
                sr1.Close();




            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Data\\config\\checkboxes.txt");
                sw.WriteLine(checkBox_acc_tab.Checked);
                sw.WriteLine(checkBox_readOnly.Checked);
                sw.WriteLine(checkBox_wordWrap.Checked);
                sw.Close();


                StreamWriter sw3 = new StreamWriter(Application.StartupPath + "\\Data\\config\\language.txt");
                if(textToolStripMenuItem.Checked)
                {
                    sw3.WriteLine("TEXT");
                }
                else if (hTMLToolStripMenuItem.Checked)
                {
                    sw3.WriteLine("HTML");
                }
                else if (xMLToolStripMenuItem.Checked)
                {
                    sw3.WriteLine("XML");
                }
                else if (jSToolStripMenuItem.Checked)
                {
                    sw3.WriteLine("JS");
                }
                else if (pHPToolStripMenuItem.Checked)
                {
                    sw3.WriteLine("PHP");
                }
                else if (cToolStripMenuItem.Checked)
                {
                    sw3.WriteLine("CSharp");
                }
                else if (viToolStripMenuItem.Checked)
                {
                    sw3.WriteLine("VB");
                }
                sw3.Close();




            }

        //FORM1.

        //LINK ITEMS / LABELS
            private void githubToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://github.com/FreshPlayer/WordCat/wiki");
            }

            private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://www.freshplayeryt.com/WordCat/");
            }

            private void helpToolStripMenuItem1_Click_1(object sender, EventArgs e)
            {
                Process.Start("https://github.com/FreshPlayer/WordCat/wiki");
            }


            private void iconsToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                Process.Start("http://p.yusukekamiyamane.com");
            }



        //LINK ITEMS / LABELS.

        //MENU STRIP


            private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.WindowState = FormWindowState.Minimized;
            }

            private void maximizeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if(this.WindowState == FormWindowState.Maximized)
                {

                    this.WindowState = FormWindowState.Normal;

                }
                else if (this.WindowState == FormWindowState.Normal)
                {

                    this.WindowState = FormWindowState.Maximized;

                }
            }

            private void mD5ToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MD5_encryption md5f = new MD5_encryption();
                md5f.Show();
            }

            private void mD5DercyptToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MD5_decryption md5d = new MD5_decryption();
                md5d.Show();
            }





            private void stopToolStripMenuItem_Click(object sender, EventArgs e)
            {
                sp.Dispose();
            }


            private void speakToolStripMenuItem_Click(object sender, EventArgs e)
            {


                if (richTextBox1.Text == "29.01.2021")
                {

                    sp.SpeakAsync("Hello! We have the 29th of january 2021 7:29:55 PM and Im sitting in my room. I have my window open. IT IS COLD!");

                }  
                
                else if (richTextBox1.Text !="")
                {

                    sp.Dispose();
                    sp = new SpeechSynthesizer();
                    sp.SpeakAsync(richTextBox1.SelectedText);

                }

            }

            private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("About : \n\nVersion : " + version + "\nProgrammed By : FreshPlayer_ YT\nCopyright : © FreshPlayer_YT 2021\n\n THIS SOFTWARE IS OPEN SOURCE", "About WordCat", MessageBoxButtons.OK);
            }


            private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                Process.Start("https://github.com/FreshPlayer/WordCat/blob/ROOT/HELP.md");
            }


            private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                search_and_replace sar1 = new search_and_replace(this);
                sar1.Show();
            }

            private void timeToolStripMenuItem_Click(object sender, EventArgs e)
            {

                DateTime dt = DateTime.Now;
                richTextBox1.AppendText(dt.ToString("h:mm:ss tt"));

            }

            private void dateToolStripMenuItem_Click(object sender, EventArgs e)
            {

                DateTime dt = DateTime.Now;
                richTextBox1.AppendText(dt.ToString("d"));

            }

            


            private void jSONToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SaveFileDialog sfd1 = new SaveFileDialog();
                sfd1.Filter = "JSON File|*.json";
                sfd1.FileName = "ExportedJSON";
                sfd1.Title = ("Export JSON");

                if (sfd1.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter sw = new StreamWriter(sfd1.FileName);
                    sw.Write(richTextBox1.Text);
                    sw.Close();

                }
            }

        //MENU STRIP.



        //CHECKBOXES
            private void checkBox_acc_tab_CheckedChanged(object sender, EventArgs e)
            {
                if(checkBox_acc_tab.Checked == true)
                {

                    richTextBox1.AcceptsTab = true;

                }
                if (checkBox_acc_tab.Checked == false)
                {

                    richTextBox1.AcceptsTab = false;

                }
            }

            private void checkBox_detectURLS_CheckedChanged(object sender, EventArgs e)
            {
                /*if (checkBox_detectURLS.Checked == true)
                {

                    richTextBox1.DetectUrls = true;

                }
                if (checkBox_detectURLS.Checked == false)
                {

                    richTextBox1.DetectUrls = false;

                }*/
            }

            private void checkBox_readOnly_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox_readOnly.Checked == true)
                {

                    richTextBox1.ReadOnly = true;

                }
                if (checkBox_readOnly.Checked == false)
                {

                    richTextBox1.ReadOnly = false;

                }
            }

            private void checkBox_wordWrap_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox_wordWrap.Checked == true)
                {

                    richTextBox1.WordWrap = true;

                }
                if (checkBox_wordWrap.Checked == false)
                {

                    richTextBox1.WordWrap = false;

                }
            }
        //CHECKBOXES.






        //EDITOR ZOOM

            private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
            {
                float currentSize;
                currentSize = richTextBox1.Font.Size;
                currentSize += 2.0F;
                richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize, richTextBox1.Font.Style, richTextBox1.Font.Unit);
            }

            private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
            {
                float currentSize = 1.0f;
                currentSize = richTextBox1.Font.Size;
                currentSize -= 2.0F;
                if (currentSize >= 1.0)
                {
                    richTextBox1.Font = new Font(richTextBox1.Font.Name, currentSize, richTextBox1.Font.Style, richTextBox1.Font.Unit);
                }
                else if (currentSize <= 1.0)
                {

                    MessageBox.Show("Reached Minimum Size!", "WordCat " + version, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        //EDITOR ZOOM.

        //DIALOG


            private void button1_Click(object sender, EventArgs e)
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {

                    richTextBox1.Font = fontDialog1.Font;

                    font_label.Text = "Font : " + richTextBox1.Font.Name;


                }


            }

            private void newToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("Are you sure?\nAll unsaved changes will be lost!", "WordCat " + version, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    this.Text = "WordCat " + version + " - New File (Unsaved File)";
                    richTextBox1.Clear();

                    Path = "";

                }
            }

            private void openToolStripMenuItem_Click(object sender, EventArgs e)
            {
                openFileDialog1.Filter = "Text-File|*.txt|HTML-File|*.html|XML-File|*.xml|JavaScript-File|*.js|PHP-File|*.php|CSharp-File|*.cs|Visual Basic-File|*.vb|All Files|*.*";
                openFileDialog1.FileName = "";
                

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    string file_content = sr.ReadToEnd();
                    richTextBox1.Text = file_content;

                }
            }

        //DIALOG.


        //Printing
            private void printToolStripButton_Click(object sender, EventArgs e)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

            private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

            private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {
                e.Graphics.DrawString(richTextBox1.Text, new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, richTextBox1.Font.Style), Brushes.Black, new Point(10, 10));
            }
       //Printing.

       //SAVING
            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                if (Path == String.Empty)
                {

                    DialogResult saveResult = saveFileDialog1.ShowDialog();

                    if (saveResult == DialogResult.OK)
                    {

                        Path = saveFileDialog1.FileName;

                        try
                        {

                            StreamWriter SaveStremWriter = new StreamWriter(Path);
                            SaveStremWriter.Write(richTextBox1.Text);
                            SaveStremWriter.Close();

                            this.Text = "WordCat " + version + " - " + Path;



                        }
                        catch (IOException ioe)
                        {

                            MessageBox.Show("Error Saving File : " + ioe.Message, "WordCat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }
                else
                {

                    try
                    {

                        StreamWriter SaveStremWriter = new StreamWriter(Path);
                        SaveStremWriter.Write(richTextBox1.Text);
                        SaveStremWriter.Close();

                        this.Text = "WordCat " + version + " - " + Path;



                    }
                    catch (IOException ioe)
                    {

                        MessageBox.Show("Error Saving File : " + ioe.Message, "WordCat", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


            }

            private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
            {

                DialogResult saveResult = saveFileDialog1.ShowDialog();

                if (saveResult == DialogResult.OK)
                {

                    Path = saveFileDialog1.FileName;

                    try
                    {

                        StreamWriter SaveStremWriter = new StreamWriter(Path);
                        SaveStremWriter.Write(richTextBox1.Text);
                        SaveStremWriter.Close();

                        this.Text = "WordCat " + version + " - " + Path;



                    }
                    catch (IOException ioe)
                    {

                        MessageBox.Show("Error Saving File : " + ioe.Message, "WordCat " + version, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }


            }


        //SAVING.

        //METHODS


            public string get_code()
            {

                return richTextBox1.Text;

            }


            public int replace(string replace_content)
            {

                richTextBox1.SelectedText = replace_content;

                return 0;

            }



            
            public bool search_and_select(string search_content, bool backwards)
            {

                  return (richTextBox1.SelectNext(search_content, backwards));
                
            }

            public bool systemTrayIcon(bool openWithIcon)
            {
                
                if(openWithIcon == true)
                {

                    notifyIcon1.Visible = true;
                    
                }
                return openWithIcon;

            }

        //METHODS.

        //WIKIPEDIA SEARCH

            private void wikipediaSearchToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://en.wikipedia.org/wiki/" + richTextBox1.SelectedText);
            }

            private void germanWikipediaSearchToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://de.wikipedia.org/wiki/" + richTextBox1.SelectedText);
            }

            private void franceWikipediaSearchToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://fr.wikipedia.org/wiki/" + richTextBox1.SelectedText);
            }

            private void spanishWikipediaSearchToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://es.wikipedia.org/wiki/" + richTextBox1.SelectedText);
            }

            private void polishWikipediaSearchToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://pl.wikipedia.org/wiki/" + richTextBox1.SelectedText);
            }

            private void russianWikipediaSearchToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://ru.wikipedia.org/wiki/" + richTextBox1.SelectedText);
            }

            private void italianWikipediaSearchToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Process.Start("https://it.wikipedia.org/wiki/" + richTextBox1.SelectedText);
            }

        //WIKIPEDIA SEARCH.

        //EDITOR LANGUAGES
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            textToolStripMenuItem.Checked = true;
            richTextBox1.Language = FastColoredTextBoxNS.Language.Custom;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;

        }
        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hTMLToolStripMenuItem.Checked = true;
            richTextBox1.Language = FastColoredTextBoxNS.Language.HTML;

            textToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xMLToolStripMenuItem.Checked = true;
            richTextBox1.Language = FastColoredTextBoxNS.Language.XML;

            textToolStripMenuItem.Checked = false;
            hTMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;
        }

        //Javascript
        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jSToolStripMenuItem.Checked = true;
            richTextBox1.Language = FastColoredTextBoxNS.Language.JS;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            textToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pHPToolStripMenuItem.Checked = true;
            richTextBox1.Language = FastColoredTextBoxNS.Language.PHP;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            textToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;
        }

        

        //C#
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cToolStripMenuItem.Checked = true;
            cToolStripMenuItem1.Visible = true;
            richTextBox1.Language = FastColoredTextBoxNS.Language.CSharp;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            textToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
        }

        //VISUAL BASIC
        private void viToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viToolStripMenuItem.Checked = true;
            cToolStripMenuItem1.Visible = false;
            richTextBox1.Language = FastColoredTextBoxNS.Language.VB;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            textToolStripMenuItem.Checked = false;
        }
        //EDITOR LANGAUGES.




        //FONT DROPDOWN
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
                font_label.Text = "Font : " + richTextBox1.Font.Name;

            }
            if (comboBox1.SelectedIndex == 1)
            {

                richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
                font_label.Text = "Font : " + richTextBox1.Font.Name;

            }
            if (comboBox1.SelectedIndex == 2)
            {

                richTextBox1.Font = new Font(comboBox1.Text, richTextBox1.Font.Size);
                font_label.Text = "Font : " + richTextBox1.Font.Name;

            }
        }
        //FONT DROPDOWN.


        //EXPLORER
        private void explorer_toolBar_back_Click(object sender, EventArgs e)
        {
            explorer1.GoBack();
        }
        private void explorer_toolBar_forwards_Click(object sender, EventArgs e)
        {
            explorer1.GoForward();
        }
        private void explorer_toolBar_open_Click(object sender, EventArgs e)
        {
            explorer1.Navigate(textBox1.Text);
        }
        private void explorer_toolBar_openWindow_Click(object sender, EventArgs e)
        {
            Process.Start(explorer1.Url.ToString());
        }







        private void timer1_Tick(object sender, EventArgs e)
        {
           // --- THIS DOSENT WORK CURRENTLY --- //

           //line = 1 + richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine());
           // column = 1 + richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine();
           //lineAndColumn_label.Text = "Ln : " + line + " | Col : " + column;

        }

        private void compileApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cs_CopileWindow cscw = new Cs_CopileWindow();
            cscw.Show();
        }


    }
}
