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
using System.Threading;
using System.CodeDom.Compiler;

namespace WordCat
{
    public partial class Form1 : Form
    {


        string program_name = "Blob IDE";

        public Form1()
        {
            InitializeComponent();

        }



        //Strings
        string version = "v3";
        string Path = "";

        string debug_Path = "C:\\";



        //Saving
        bool saved = false;



        //Checkbox Bool

        string acc_tab = "true";
        string read_only = "false";
        string word_wrap = "false";


        //TEXT TO SPEECH
        SpeechSynthesizer sp = new SpeechSynthesizer();


 


        //EDITOR ACTIONS

        private void cutToolStripButton_contextMenu_Click(object sender, EventArgs e)
        {
            codeBox1.Cut();
            richTextBox1.AppendText("Cut text\n");
        }

        private void copyToolStripButton_contextMenu_Click(object sender, EventArgs e)
        {
            codeBox1.Copy();
            richTextBox1.AppendText("Copied text to clipboard.\n");
        }

        private void pasteToolStripButton_contextMenu_Click(object sender, EventArgs e)
        {
            codeBox1.Paste();
            richTextBox1.AppendText("Pasted text.\n");
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBox1.Undo();
            richTextBox1.AppendText("Undo operation.\n");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBox1.Redo();
            richTextBox1.AppendText("Redo operation.\n");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBox1.Cut();
            richTextBox1.AppendText("Cut text\n");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBox1.Copy();
            richTextBox1.AppendText("Copied text to clipboard.\n");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBox1.Paste();
            richTextBox1.AppendText("Pasted text.\n");
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBox1.SelectAll();
            richTextBox1.AppendText("Select all...\n");
        }
        //EDITOR ACTIONS.


        //FORM1
        private void Form1_Load(object sender, EventArgs e)
        {

            codeBox1.BookmarkColor = Color.OrangeRed;


            if (File.Exists(Application.StartupPath + "\\BlobIDE_ColorPicker.exe") == true)
            {

                colorpickerToolStripMenuItem.Visible = true;

            }

            explorer1.Navigate("C:\\Users \\" + Environment.UserName);

            this.Icon = Properties.Resources.BLOB;

            sp.SelectVoiceByHints(VoiceGender.Male);

            timer1.Start();

            this.Text = program_name + " " + version;

            font_label.Text = "Font : " + codeBox1.Font.Name;

            StreamReader srColor = new StreamReader("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\colors.txt");
            string fontColor = srColor.ReadLine();
            string currLineColor = srColor.ReadLine();
            string lineNumColor= srColor.ReadLine();
            string lineNumBckColor = srColor.ReadLine();
            string selColor = srColor.ReadLine();
            string bookMarkColor = srColor.ReadLine();
            srColor.Close();

            codeBox1.ForeColor = Color.FromArgb(int.Parse(fontColor));
            colorPicker_Font.BackColor = Color.FromArgb(int.Parse(fontColor));

            codeBox1.CurrentLineColor = Color.FromArgb(int.Parse(currLineColor));
            colorPicker_CurrLine.BackColor = Color.FromArgb(int.Parse(currLineColor));

            codeBox1.LineNumberColor = Color.FromArgb(int.Parse(lineNumColor));
            colorPicker_LineNum.BackColor = Color.FromArgb(int.Parse(lineNumColor));

            codeBox1.IndentBackColor = Color.FromArgb(int.Parse(lineNumBckColor));
            colorPicker_LineNumBckgr.BackColor = Color.FromArgb(int.Parse(lineNumBckColor));

            codeBox1.SelectionColor = Color.FromArgb(int.Parse(selColor));
            colorPicker_SelCol.BackColor = Color.FromArgb(int.Parse(selColor));

            codeBox1.BookmarkColor = Color.FromArgb(int.Parse(bookMarkColor));
            colorPicker_BookMark.BackColor = Color.FromArgb(int.Parse(bookMarkColor));






            //Read Checkboxes
            StreamReader sr = new StreamReader("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\checkboxes.txt");
            acc_tab = sr.ReadLine();
            read_only = sr.ReadLine();
            word_wrap = sr.ReadLine();
            sr.Close();

            if (acc_tab == "True")
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
                codeBox1.AcceptsTab = false;

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

            StreamReader sr1 = new StreamReader("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\language.txt");
            lang_select = sr1.ReadLine();
            if (lang_select == "TEXT")
            {
                textToolStripMenuItem.Checked = true;
                codeBox1.Language = FastColoredTextBoxNS.Language.Custom;

                hTMLToolStripMenuItem.Checked = false;
                xMLToolStripMenuItem.Checked = false;
                toolStripMenuItem1.Visible = false;
                jSToolStripMenuItem.Checked = false;
                visualBasicToolStripMenuItem.Visible = false;
                pHPToolStripMenuItem.Checked = false;
                cToolStripMenuItem.Checked = false;
                viToolStripMenuItem.Checked = false;
                cToolStripMenuItem1.Visible = false;
            }
            else if (lang_select == "HTML")
            {
                hTMLToolStripMenuItem.Checked = true;
                codeBox1.Language = FastColoredTextBoxNS.Language.HTML;

                textToolStripMenuItem.Checked = false;
                xMLToolStripMenuItem.Checked = false;
                jSToolStripMenuItem.Checked = false;
                toolStripMenuItem1.Visible = true;
                pHPToolStripMenuItem.Checked = false;
                cToolStripMenuItem.Checked = false;
                visualBasicToolStripMenuItem.Visible = false;
                viToolStripMenuItem.Checked = false;
                cToolStripMenuItem1.Visible = false;
            }
            else if (lang_select == "XML")
            {
                xMLToolStripMenuItem.Checked = true;
                codeBox1.Language = FastColoredTextBoxNS.Language.XML;

                textToolStripMenuItem.Checked = false;
                hTMLToolStripMenuItem.Checked = false;
                toolStripMenuItem1.Visible = false;
                jSToolStripMenuItem.Checked = false;
                visualBasicToolStripMenuItem.Visible = false;
                pHPToolStripMenuItem.Checked = false;
                cToolStripMenuItem.Checked = false;
                viToolStripMenuItem.Checked = false;
                cToolStripMenuItem1.Visible = false;
            }
            else if (lang_select == "JS")
            {
                jSToolStripMenuItem.Checked = true;
                codeBox1.Language = FastColoredTextBoxNS.Language.JS;

                hTMLToolStripMenuItem.Checked = false;
                xMLToolStripMenuItem.Checked = false;
                textToolStripMenuItem.Checked = false;
                toolStripMenuItem1.Visible = false;
                visualBasicToolStripMenuItem.Visible = false;
                pHPToolStripMenuItem.Checked = false;
                cToolStripMenuItem.Checked = false;
                viToolStripMenuItem.Checked = false;
                cToolStripMenuItem1.Visible = false;
            }
            else if (lang_select == "PHP")
            {
                pHPToolStripMenuItem.Checked = true;
                codeBox1.Language = FastColoredTextBoxNS.Language.PHP;

                hTMLToolStripMenuItem.Checked = false;
                xMLToolStripMenuItem.Checked = false;
                jSToolStripMenuItem.Checked = false;
                visualBasicToolStripMenuItem.Visible = false;
                textToolStripMenuItem.Checked = false;
                cToolStripMenuItem.Checked = false;
                toolStripMenuItem1.Visible = false;
                viToolStripMenuItem.Checked = false;
                cToolStripMenuItem1.Visible = false;
            }
            else if (lang_select == "CSharp")
            {
                cToolStripMenuItem.Checked = true;
                cToolStripMenuItem1.Visible = true;
                codeBox1.Language = FastColoredTextBoxNS.Language.CSharp;

                hTMLToolStripMenuItem.Checked = false;
                xMLToolStripMenuItem.Checked = false;
                toolStripMenuItem1.Visible = false;
                jSToolStripMenuItem.Checked = false;
                pHPToolStripMenuItem.Checked = false;
                visualBasicToolStripMenuItem.Visible = false;
                textToolStripMenuItem.Checked = false;
                viToolStripMenuItem.Checked = false;
            }
            else if (lang_select == "VB")
            {
                viToolStripMenuItem.Checked = true;
                cToolStripMenuItem1.Visible = false;
                codeBox1.Language = FastColoredTextBoxNS.Language.VB;

                hTMLToolStripMenuItem.Checked = false;
                xMLToolStripMenuItem.Checked = false;
                jSToolStripMenuItem.Checked = false;
                visualBasicToolStripMenuItem.Visible = true;
                toolStripMenuItem1.Visible = false;
                pHPToolStripMenuItem.Checked = false;
                cToolStripMenuItem.Checked = false;
                textToolStripMenuItem.Checked = false;
            }
            sr1.Close();


            StreamReader sr2 = new StreamReader("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\options\\save_img.txt");
            string read_save_imgs = "disks";
            read_save_imgs = sr2.ReadLine();
            sr2.Close();

            if (read_save_imgs == "disks")
            {
                saveAsToolStripMenuItem.Image = Properties.Resources.disks_icon;
                saveToolStripMenuItem.Image = Properties.Resources.disk_icon;
                saveAsToolStripButton.Image = Properties.Resources.disks_icon;
                saveToolStripButton.Image = Properties.Resources.disk_icon;
            }
            else if (read_save_imgs == "hdd")
            {
                saveAsToolStripMenuItem.Image = Properties.Resources.drive_plus_icon;
                saveToolStripMenuItem.Image = Properties.Resources.drive_icon;
                saveAsToolStripButton.Image = Properties.Resources.drive_plus_icon;
                saveToolStripButton.Image = Properties.Resources.drive_icon;
            }




        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\checkboxes.txt");
            sw.WriteLine(checkBox_acc_tab.Checked);
            sw.WriteLine(checkBox_readOnly.Checked);
            sw.WriteLine(checkBox_wordWrap.Checked);
            sw.Close();


            StreamWriter sw1 = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\colors.txt");
            sw1.WriteLine(colorPicker_Font.BackColor.ToArgb().ToString());
            sw1.WriteLine(colorPicker_CurrLine.BackColor.ToArgb().ToString());
            sw1.WriteLine(colorPicker_LineNum.BackColor.ToArgb().ToString());
            sw1.WriteLine(colorPicker_LineNumBckgr.BackColor.ToArgb().ToString());
            sw1.WriteLine(colorPicker_SelCol.BackColor.ToArgb().ToString());
            sw1.WriteLine(colorPicker_BookMark.BackColor.ToArgb().ToString());
            sw1.Close();


            StreamWriter sw3 = new StreamWriter("C:\\Users\\" + Environment.UserName + "\\Appdata\\roaming\\Blob-IDE\\Data\\config\\language.txt");
            if (textToolStripMenuItem.Checked)
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



            if (saved == true)
            {
                Application.ExitThread();
            }
            if (saved == false)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "en-US")
                {
                    if (MessageBox.Show("Unsaved changes! Do you really want to exit?", program_name + " " + version, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Application.ExitThread();
                    }
                    else
                    {
                        e.Cancel = true;
                        richTextBox1.AppendText("Tried to close.");
                    }
                }
                if (Thread.CurrentThread.CurrentCulture.Name == "de-DE")
                {
                    if (MessageBox.Show("Ungespeicherte Änderungen! Wollen sie wirklich beenden?", program_name + " " + version, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Application.ExitThread();
                    }
                    else
                    {
                        e.Cancel = true;
                        richTextBox1.AppendText("Versuchte zu schliessen.");
                    }
                }
            }

        }

        //FORM1.

        //LINK ITEMS / LABELS
        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FreshPlayer/Blob-IDE/");
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://freshplayer.github.io/Blob-IDE/");
        }

        private void helpToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://github.com/FreshPlayer/Blob-IDE/wiki");
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
            if (this.WindowState == FormWindowState.Maximized)
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


            if (codeBox1.Text == "29.01.2021")
            {

                sp.SpeakAsync("Hello! We have the 29th of january 2021 7:29:55 PM and Im sitting in my room. I have my window open. IT IS COLD!");

            }

            else if (codeBox1.Text != "")
            {

                sp.Dispose();
                sp = new SpeechSynthesizer();
                sp.SpeakAsync(codeBox1.SelectedText);

            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Window abw = new About_Window();
            abw.Show();
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
            codeBox1.AppendText(dt.ToString("h:mm:ss tt"));

        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DateTime dt = DateTime.Now;
            codeBox1.AppendText(dt.ToString("d"));

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
                sw.Write(codeBox1.Text);
                sw.Close();

            }
        }

        //MENU STRIP.



        //CHECKBOXES
        private void checkBox_acc_tab_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_acc_tab.Checked == true)
            {

                codeBox1.AcceptsTab = true;

            }
            if (checkBox_acc_tab.Checked == false)
            {

                codeBox1.AcceptsTab = false;

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

                codeBox1.ReadOnly = true;

            }
            if (checkBox_readOnly.Checked == false)
            {

                codeBox1.ReadOnly = false;

            }
        }

        private void checkBox_wordWrap_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_wordWrap.Checked == true)
            {

                codeBox1.WordWrap = true;

            }
            if (checkBox_wordWrap.Checked == false)
            {

                codeBox1.WordWrap = false;

            }
        }
        //CHECKBOXES.






        //EDITOR ZOOM

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize;
            currentSize = codeBox1.Font.Size;
            currentSize += 2.0F;
            codeBox1.Font = new Font(codeBox1.Font.Name, currentSize, codeBox1.Font.Style, codeBox1.Font.Unit);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float currentSize = 1.0f;
            currentSize = codeBox1.Font.Size;
            currentSize -= 2.0F;
            if (currentSize >= 1.0)
            {
                codeBox1.Font = new Font(codeBox1.Font.Name, currentSize, codeBox1.Font.Style, codeBox1.Font.Unit);
            }
            else if (currentSize <= 1.0)
            {
                if (Thread.CurrentThread.CurrentCulture.Name == "en-US")
                {
                    MessageBox.Show("Reached Minimum Size!", program_name + " " + version, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox1.AppendText( DateTime.Now + "  -  Reached Minimum Size! (Editor Zoom)\n");
                }
                if (Thread.CurrentThread.CurrentCulture.Name == "de-DE")
                {
                    MessageBox.Show("Minimale Grösse erreicht!", program_name + " " + version, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    richTextBox1.AppendText(DateTime.Now + "  -  Minimale Grösse erreicht! (Editor Zoom)\n");
                }

            }
        }


        //EDITOR ZOOM.

        //DIALOG


        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                codeBox1.Font = fontDialog1.Font;

                font_label.Text = "Font : " + codeBox1.Font.Name;


            }


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?\nAll unsaved changes will be lost!", program_name + " " + version, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Text = program_name + " " + version + " - New File (Unsaved File)";
                codeBox1.Clear();

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
                codeBox1.Text = file_content;

                Path = openFileDialog1.FileName;
                this.Text = program_name + " " + version + " - " + Path;

                saved = true;

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
            e.Graphics.DrawString(codeBox1.Text, new Font(codeBox1.Font.Name, codeBox1.Font.Size, codeBox1.Font.Style), Brushes.Black, new Point(10, 10));
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
                        SaveStremWriter.Write(codeBox1.Text);
                        SaveStremWriter.Close();

                        this.Text = program_name + " " + version + " - " + Path;

                        saved = true;

                    }
                    catch (IOException ioe)
                    {

                        MessageBox.Show("Error Saving File : " + ioe.Message, program_name, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
            else
            {

                try
                {

                    StreamWriter SaveStreamWriter = new StreamWriter(Path);
                    SaveStreamWriter.Write(codeBox1.Text);
                    SaveStreamWriter.Close();

                    this.Text = program_name + " " + version + " - " + Path;

                    saved = true;



                }
                catch (IOException ioe)
                {

                    MessageBox.Show("Error Saving File : " + ioe.Message, program_name, MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    SaveStremWriter.Write(codeBox1.Text);
                    SaveStremWriter.Close();

                    this.Text = program_name + " " + version + " - " + Path;

                    saved = true;

                }
                catch (IOException ioe)
                {


                    MessageBox.Show("Error Saving File : " + ioe.Message, program_name + " " + version, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }


        //SAVING.

        //SOME METHODS


        public string bookmark(int lineNum)
        {

            codeBox1.BookmarkLine(lineNum);

            return null;

        }


        public string get_code()
        {

            return codeBox1.Text;

        }


        public int replace(string replace_content)
        {

            codeBox1.SelectedText = replace_content;

            return 0;

        }




        public bool search_and_select(string search_content, bool backwards)
        {

            return (codeBox1.SelectNext(search_content, backwards));

        }

        public bool systemTrayIcon(bool openWithIcon)
        {

            if (openWithIcon == true)
            {

                notifyIcon1.Visible = true;

            }
            return openWithIcon;

        }

        //SOME METHODS.


        //EDITOR LANGUAGES
        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textToolStripMenuItem.Checked = true;
            codeBox1.Language = FastColoredTextBoxNS.Language.Custom;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            visualBasicToolStripMenuItem.Visible = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;
            toolStripMenuItem1.Visible = false;

        }
        private void hTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Visible = true;
            hTMLToolStripMenuItem.Checked = true;
            codeBox1.Language = FastColoredTextBoxNS.Language.HTML;

            textToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            visualBasicToolStripMenuItem.Visible = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xMLToolStripMenuItem.Checked = true;
            codeBox1.Language = FastColoredTextBoxNS.Language.XML;

            textToolStripMenuItem.Checked = false;
            visualBasicToolStripMenuItem.Visible = false;
            hTMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;
            toolStripMenuItem1.Visible = false;
        }

        //Javascript
        private void jSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jSToolStripMenuItem.Checked = true;
            codeBox1.Language = FastColoredTextBoxNS.Language.JS;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            textToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            visualBasicToolStripMenuItem.Visible = false;
            cToolStripMenuItem1.Visible = false;
            toolStripMenuItem1.Visible = false;
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pHPToolStripMenuItem.Checked = true;
            codeBox1.Language = FastColoredTextBoxNS.Language.PHP;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            textToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            cToolStripMenuItem1.Visible = false;
            toolStripMenuItem1.Visible = false;
            visualBasicToolStripMenuItem.Visible = false;
        }



        //C#
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cToolStripMenuItem.Checked = true;
            cToolStripMenuItem1.Visible = true;
            codeBox1.Language = FastColoredTextBoxNS.Language.CSharp;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            visualBasicToolStripMenuItem.Visible = false;
            textToolStripMenuItem.Checked = false;
            viToolStripMenuItem.Checked = false;
            toolStripMenuItem1.Visible = false;
        }

        //VISUAL BASIC
        private void viToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viToolStripMenuItem.Checked = true;
            cToolStripMenuItem1.Visible = false;
            visualBasicToolStripMenuItem.Visible = true;
            codeBox1.Language = FastColoredTextBoxNS.Language.VB;

            hTMLToolStripMenuItem.Checked = false;
            xMLToolStripMenuItem.Checked = false;
            jSToolStripMenuItem.Checked = false;
            pHPToolStripMenuItem.Checked = false;
            cToolStripMenuItem.Checked = false;
            textToolStripMenuItem.Checked = false;
            toolStripMenuItem1.Visible = false;
        }
        //EDITOR LANGAUGES.




        //FONT DROPDOWN
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                codeBox1.Font = new Font(comboBox1.Text, codeBox1.Font.Size);
                font_label.Text = "Font : " + codeBox1.Font.Name;

            }
            if (comboBox1.SelectedIndex == 1)
            {

                codeBox1.Font = new Font(comboBox1.Text, codeBox1.Font.Size);
                font_label.Text = "Font : " + codeBox1.Font.Name;

            }
            if (comboBox1.SelectedIndex == 2)
            {

                codeBox1.Font = new Font(comboBox1.Text, codeBox1.Font.Size);
                font_label.Text = "Font : " + codeBox1.Font.Name;

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
        private void explorer_toolBar_addFolder_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(explorer1.Url.ToString() + "\\New Folder");
        }



        //EXPLORER.


        //EDITOR TEXTBOX

        private void richTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            if(saved)
            {

                this.Text = program_name + " " + version + " - " + Path + "*" ;
                saved = false;

            }

            if(hTMLToolStripMenuItem.Checked == true)
            {

                HTML_Browser browse = new HTML_Browser(Path);
                browse.refresh();

            }
        }

        //EDITOR TEXTBOX.


        //EDITOR COLOR
        private void colorPicker_LineNum_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {

                codeBox1.LineNumberColor = cd.Color;
                colorPicker_LineNum.BackColor = cd.Color;

            }
        }

        private void colorPicker_LineNumBckgr_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {

                codeBox1.IndentBackColor = cd.Color;
                colorPicker_LineNumBckgr.BackColor = cd.Color;

            }
        }

        private void colorPicker_Font_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {

                codeBox1.ForeColor = cd.Color;
                colorPicker_Font.BackColor = cd.Color;

            }
        }

        private void colorPicker_SelCol_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {

                codeBox1.SelectionColor = cd.Color;
                colorPicker_SelCol.BackColor = cd.Color;

            }
        }

        private void colorPicker_BookMark_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {

                codeBox1.BookmarkColor = cd.Color;
                colorPicker_BookMark.BackColor = cd.Color;

            }
        }

        private void colorPicker_CurrLine_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
            {

                codeBox1.CurrentLineColor = cd.Color;
                colorPicker_CurrLine.BackColor = cd.Color;

            }
        }
        //EDITOR COLOR.




        private void timer1_Tick(object sender, EventArgs e)
        {
            // --- THIS DOSENT WORK CURRENTLY --- //

            //line = 1 + richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine());
            // column = 1 + richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine();
            //lineAndColumn_label.Text = "Ln : " + line + " | Col : " + column;

        }

        private void compileApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cs_CompileWindow cscw = new Cs_CompileWindow();
            cscw.Show();
        }

        private void graphicsEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GraphEdit ge = new GraphEdit();
            ge.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Optns_Window optwin = new Optns_Window();
            optwin.Show();
        }

        private void newConsoleApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeBox1.Text = "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Text;\n\nnamespace newConsoleApp\n{     \n    class Program\n   {\n\n       static void Main(string[] args)\n       {\n\n       }\n\n   }\n\n}";
        }

        private void blobIDEColorpickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\BlobIDE_ColorPicker.exe");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            BookMark bmWin = new BookMark(this);
            bmWin.Show();
        }

        private void previewBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path == string.Empty)
            {

                MessageBox.Show("You need to save the file before you can use this feature!", program_name + " " + version, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                HTML_Browser browse = new HTML_Browser(Path);
                browse.Show();
            }
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VB_CompileWindow vbcw = new VB_CompileWindow();
            vbcw.Show();
        }


    }
}
