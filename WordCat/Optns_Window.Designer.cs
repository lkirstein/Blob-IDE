namespace WordCat
{
    partial class Optns_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optns_Window));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_appearance = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox_appearance_save_icons = new System.Windows.Forms.GroupBox();
            this.radioButton_saveImg_HDD = new System.Windows.Forms.RadioButton();
            this.radioButton_saveImg_disks = new System.Windows.Forms.RadioButton();
            this.tab_lang = new System.Windows.Forms.TabPage();
            this.select_LANG_comboBox = new System.Windows.Forms.ComboBox();
            this.lbl_SelectLang = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.save_close_BTN = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_appearance.SuspendLayout();
            this.groupBox_appearance_save_icons.SuspendLayout();
            this.tab_lang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tab_appearance);
            this.tabControl1.Controls.Add(this.tab_lang);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tab_appearance
            // 
            resources.ApplyResources(this.tab_appearance, "tab_appearance");
            this.tab_appearance.Controls.Add(this.checkBox1);
            this.tab_appearance.Controls.Add(this.groupBox_appearance_save_icons);
            this.tab_appearance.Name = "tab_appearance";
            this.tab_appearance.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox_appearance_save_icons
            // 
            resources.ApplyResources(this.groupBox_appearance_save_icons, "groupBox_appearance_save_icons");
            this.groupBox_appearance_save_icons.Controls.Add(this.radioButton_saveImg_HDD);
            this.groupBox_appearance_save_icons.Controls.Add(this.radioButton_saveImg_disks);
            this.groupBox_appearance_save_icons.Name = "groupBox_appearance_save_icons";
            this.groupBox_appearance_save_icons.TabStop = false;
            // 
            // radioButton_saveImg_HDD
            // 
            resources.ApplyResources(this.radioButton_saveImg_HDD, "radioButton_saveImg_HDD");
            this.radioButton_saveImg_HDD.Name = "radioButton_saveImg_HDD";
            this.radioButton_saveImg_HDD.UseVisualStyleBackColor = true;
            // 
            // radioButton_saveImg_disks
            // 
            resources.ApplyResources(this.radioButton_saveImg_disks, "radioButton_saveImg_disks");
            this.radioButton_saveImg_disks.Checked = true;
            this.radioButton_saveImg_disks.Name = "radioButton_saveImg_disks";
            this.radioButton_saveImg_disks.TabStop = true;
            this.radioButton_saveImg_disks.UseVisualStyleBackColor = true;
            // 
            // tab_lang
            // 
            resources.ApplyResources(this.tab_lang, "tab_lang");
            this.tab_lang.Controls.Add(this.select_LANG_comboBox);
            this.tab_lang.Controls.Add(this.lbl_SelectLang);
            this.tab_lang.Name = "tab_lang";
            this.tab_lang.UseVisualStyleBackColor = true;
            // 
            // select_LANG_comboBox
            // 
            resources.ApplyResources(this.select_LANG_comboBox, "select_LANG_comboBox");
            this.select_LANG_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_LANG_comboBox.FormattingEnabled = true;
            this.select_LANG_comboBox.Items.AddRange(new object[] {
            resources.GetString("select_LANG_comboBox.Items"),
            resources.GetString("select_LANG_comboBox.Items1")});
            this.select_LANG_comboBox.Name = "select_LANG_comboBox";
            this.select_LANG_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_SelectLang
            // 
            resources.ApplyResources(this.lbl_SelectLang, "lbl_SelectLang");
            this.lbl_SelectLang.Name = "lbl_SelectLang";
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // save_close_BTN
            // 
            resources.ApplyResources(this.save_close_BTN, "save_close_BTN");
            this.save_close_BTN.Name = "save_close_BTN";
            this.save_close_BTN.UseVisualStyleBackColor = true;
            this.save_close_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Optns_Window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save_close_BTN);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Optns_Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Optns_Window_FormClosing);
            this.Load += new System.EventHandler(this.Optns_Window_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_appearance.ResumeLayout(false);
            this.tab_appearance.PerformLayout();
            this.groupBox_appearance_save_icons.ResumeLayout(false);
            this.groupBox_appearance_save_icons.PerformLayout();
            this.tab_lang.ResumeLayout(false);
            this.tab_lang.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_appearance;
        private System.Windows.Forms.GroupBox groupBox_appearance_save_icons;
        private System.Windows.Forms.RadioButton radioButton_saveImg_HDD;
        private System.Windows.Forms.RadioButton radioButton_saveImg_disks;
        private System.Windows.Forms.TabPage tab_lang;
        private System.Windows.Forms.ComboBox select_LANG_comboBox;
        private System.Windows.Forms.Label lbl_SelectLang;
        private System.Windows.Forms.Button save_close_BTN;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}