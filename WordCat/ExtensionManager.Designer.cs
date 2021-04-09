
namespace WordCat
{
    partial class ExtensionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtensionManager));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.place_holder_1 = new System.Windows.Forms.ToolStripLabel();
            this.open_EXT = new System.Windows.Forms.ToolStripButton();
            this.remove_EXT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.neew_EXT = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(250, 409);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(268, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 409);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Extension :";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(6, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Extension Information";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Item Selected !";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.xml";
            this.openFileDialog1.Filter = "XML-File (*.xml)|*.xml";
            this.openFileDialog1.Title = "Open XML File";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.place_holder_1,
            this.open_EXT,
            this.remove_EXT,
            this.toolStripSeparator1,
            this.neew_EXT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(530, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // place_holder_1
            // 
            this.place_holder_1.Name = "place_holder_1";
            this.place_holder_1.Size = new System.Drawing.Size(10, 22);
            this.place_holder_1.Text = " ";
            // 
            // open_EXT
            // 
            this.open_EXT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.open_EXT.Image = ((System.Drawing.Image)(resources.GetObject("open_EXT.Image")));
            this.open_EXT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open_EXT.Name = "open_EXT";
            this.open_EXT.Size = new System.Drawing.Size(23, 22);
            this.open_EXT.Text = "Browse Extension";
            this.open_EXT.Click += new System.EventHandler(this.button1_Click);
            // 
            // remove_EXT
            // 
            this.remove_EXT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.remove_EXT.Image = ((System.Drawing.Image)(resources.GetObject("remove_EXT.Image")));
            this.remove_EXT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.remove_EXT.Name = "remove_EXT";
            this.remove_EXT.Size = new System.Drawing.Size(23, 22);
            this.remove_EXT.Text = "Remove Extension";
            this.remove_EXT.Click += new System.EventHandler(this.remove_EXT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // neew_EXT
            // 
            this.neew_EXT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.neew_EXT.Image = ((System.Drawing.Image)(resources.GetObject("neew_EXT.Image")));
            this.neew_EXT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.neew_EXT.Name = "neew_EXT";
            this.neew_EXT.Size = new System.Drawing.Size(23, 22);
            this.neew_EXT.Text = "Open Extension Folder";
            this.neew_EXT.Click += new System.EventHandler(this.neew_EXT_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ExtensionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtensionManager";
            this.ShowInTaskbar = false;
            this.Text = "Extensions";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExtensionManager_FormClosing);
            this.Load += new System.EventHandler(this.ExtensionManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel place_holder_1;
        private System.Windows.Forms.ToolStripButton open_EXT;
        private System.Windows.Forms.ToolStripButton remove_EXT;
        private System.Windows.Forms.ToolStripButton neew_EXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}