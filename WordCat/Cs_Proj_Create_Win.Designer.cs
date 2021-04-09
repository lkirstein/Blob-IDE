
namespace WordCat
{
    partial class Cs_Proj_Create_Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cs_Proj_Create_Win));
            this.project_Name_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.path_Text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.creator_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.program_Name_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // project_Name_Text
            // 
            this.project_Name_Text.Location = new System.Drawing.Point(95, 6);
            this.project_Name_Text.Name = "project_Name_Text";
            this.project_Name_Text.Size = new System.Drawing.Size(308, 20);
            this.project_Name_Text.TabIndex = 0;
            this.project_Name_Text.Text = "New Project #...";
            this.project_Name_Text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path   :";
            // 
            // path_Text
            // 
            this.path_Text.Location = new System.Drawing.Point(95, 79);
            this.path_Text.Name = "path_Text";
            this.path_Text.Size = new System.Drawing.Size(276, 20);
            this.path_Text.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // creator_Text
            // 
            this.creator_Text.Location = new System.Drawing.Point(95, 53);
            this.creator_Text.Name = "creator_Text";
            this.creator_Text.Size = new System.Drawing.Size(308, 20);
            this.creator_Text.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Creator :";
            // 
            // program_Name_Text
            // 
            this.program_Name_Text.Location = new System.Drawing.Point(95, 30);
            this.program_Name_Text.Name = "program_Name_Text";
            this.program_Name_Text.Size = new System.Drawing.Size(308, 20);
            this.program_Name_Text.TabIndex = 9;
            this.program_Name_Text.Text = "New Application";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Program Name :";
            // 
            // Cs_Proj_Create_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 162);
            this.Controls.Add(this.program_Name_Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creator_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.path_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.project_Name_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cs_Proj_Create_Win";
            this.Text = "New C# Project";
            this.Load += new System.EventHandler(this.Cs_Proj_Create_Win_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox project_Name_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path_Text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox creator_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox program_Name_Text;
        private System.Windows.Forms.Label label4;
    }
}