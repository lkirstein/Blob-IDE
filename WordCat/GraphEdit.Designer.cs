namespace WordCat
{
    partial class GraphEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphEdit));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.placeholder1 = new System.Windows.Forms.ToolStripLabel();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removeImage_button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tools_brush = new System.Windows.Forms.ToolStripButton();
            this.tools_pen = new System.Windows.Forms.ToolStripButton();
            this.tools_pickColor = new System.Windows.Forms.ToolStripButton();
            this.tools_eraser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tools_line = new System.Windows.Forms.ToolStripButton();
            this.tools_circle = new System.Windows.Forms.ToolStripButton();
            this.tools_rectangle = new System.Windows.Forms.ToolStripButton();
            this.txt_bx_brushSize = new System.Windows.Forms.TextBox();
            this.lbl_BrushSize = new System.Windows.Forms.Label();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.slider_red = new System.Windows.Forms.TrackBar();
            this.slider_blue = new System.Windows.Forms.TrackBar();
            this.slider_green = new System.Windows.Forms.TrackBar();
            this.lbl_sliderRed = new System.Windows.Forms.Label();
            this.lbl_sliderGreen = new System.Windows.Forms.Label();
            this.lbl_sliderBlue = new System.Windows.Forms.Label();
            this.lbl_sliderRed_val = new System.Windows.Forms.Label();
            this.lbl_sliderGreen_val = new System.Windows.Forms.Label();
            this.lbl_sliderBlue_val = new System.Windows.Forms.Label();
            this.lbl_current_color = new System.Windows.Forms.Label();
            this.current_color_box = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.PictureBox();
            this.lbl_paper_bck_color = new System.Windows.Forms.Label();
            this.paper_color_box = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_color_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_color_box)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholder1,
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.removeImage_button});
            this.toolStrip1.Name = "toolStrip1";
            this.toolTip1.SetToolTip(this.toolStrip1, resources.GetString("toolStrip1.ToolTip"));
            // 
            // placeholder1
            // 
            resources.ApplyResources(this.placeholder1, "placeholder1");
            this.placeholder1.Name = "placeholder1";
            // 
            // newToolStripButton
            // 
            resources.ApplyResources(this.newToolStripButton, "newToolStripButton");
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            resources.ApplyResources(this.openToolStripButton, "openToolStripButton");
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            resources.ApplyResources(this.saveToolStripButton, "saveToolStripButton");
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // removeImage_button
            // 
            resources.ApplyResources(this.removeImage_button, "removeImage_button");
            this.removeImage_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeImage_button.Name = "removeImage_button";
            this.removeImage_button.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStrip2
            // 
            resources.ApplyResources(this.toolStrip2, "toolStrip2");
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tools_brush,
            this.tools_pen,
            this.tools_pickColor,
            this.tools_eraser,
            this.toolStripSeparator2,
            this.tools_line,
            this.tools_circle,
            this.tools_rectangle});
            this.toolStrip2.Name = "toolStrip2";
            this.toolTip1.SetToolTip(this.toolStrip2, resources.GetString("toolStrip2.ToolTip"));
            // 
            // tools_brush
            // 
            resources.ApplyResources(this.tools_brush, "tools_brush");
            this.tools_brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_brush.Name = "tools_brush";
            this.tools_brush.Click += new System.EventHandler(this.tools_brush_Click);
            // 
            // tools_pen
            // 
            resources.ApplyResources(this.tools_pen, "tools_pen");
            this.tools_pen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_pen.Name = "tools_pen";
            this.tools_pen.Click += new System.EventHandler(this.tools_pen_Click);
            // 
            // tools_pickColor
            // 
            resources.ApplyResources(this.tools_pickColor, "tools_pickColor");
            this.tools_pickColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_pickColor.Name = "tools_pickColor";
            this.tools_pickColor.Click += new System.EventHandler(this.tools_pickColor_Click);
            // 
            // tools_eraser
            // 
            resources.ApplyResources(this.tools_eraser, "tools_eraser");
            this.tools_eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_eraser.Name = "tools_eraser";
            this.tools_eraser.Click += new System.EventHandler(this.tools_eraser_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tools_line
            // 
            resources.ApplyResources(this.tools_line, "tools_line");
            this.tools_line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_line.Name = "tools_line";
            this.tools_line.Click += new System.EventHandler(this.tools_line_Click);
            // 
            // tools_circle
            // 
            resources.ApplyResources(this.tools_circle, "tools_circle");
            this.tools_circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_circle.Name = "tools_circle";
            this.tools_circle.Click += new System.EventHandler(this.tools_circle_Click);
            // 
            // tools_rectangle
            // 
            resources.ApplyResources(this.tools_rectangle, "tools_rectangle");
            this.tools_rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tools_rectangle.Name = "tools_rectangle";
            this.tools_rectangle.Click += new System.EventHandler(this.tools_rectangle_Click);
            // 
            // txt_bx_brushSize
            // 
            resources.ApplyResources(this.txt_bx_brushSize, "txt_bx_brushSize");
            this.txt_bx_brushSize.Name = "txt_bx_brushSize";
            this.toolTip1.SetToolTip(this.txt_bx_brushSize, resources.GetString("txt_bx_brushSize.ToolTip"));
            // 
            // lbl_BrushSize
            // 
            resources.ApplyResources(this.lbl_BrushSize, "lbl_BrushSize");
            this.lbl_BrushSize.Name = "lbl_BrushSize";
            this.toolTip1.SetToolTip(this.lbl_BrushSize, resources.GetString("lbl_BrushSize.ToolTip"));
            // 
            // colorPicker
            // 
            resources.ApplyResources(this.colorPicker, "colorPicker");
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.TabStop = false;
            this.toolTip1.SetToolTip(this.colorPicker, resources.GetString("colorPicker.ToolTip"));
            this.colorPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.colorPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.colorPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // slider_red
            // 
            resources.ApplyResources(this.slider_red, "slider_red");
            this.slider_red.Maximum = 255;
            this.slider_red.Name = "slider_red";
            this.toolTip1.SetToolTip(this.slider_red, resources.GetString("slider_red.ToolTip"));
            this.slider_red.Scroll += new System.EventHandler(this.slider_red_Scroll);
            // 
            // slider_blue
            // 
            resources.ApplyResources(this.slider_blue, "slider_blue");
            this.slider_blue.Maximum = 255;
            this.slider_blue.Name = "slider_blue";
            this.toolTip1.SetToolTip(this.slider_blue, resources.GetString("slider_blue.ToolTip"));
            this.slider_blue.Scroll += new System.EventHandler(this.slider_blue_Scroll);
            // 
            // slider_green
            // 
            resources.ApplyResources(this.slider_green, "slider_green");
            this.slider_green.Maximum = 255;
            this.slider_green.Name = "slider_green";
            this.toolTip1.SetToolTip(this.slider_green, resources.GetString("slider_green.ToolTip"));
            this.slider_green.Scroll += new System.EventHandler(this.slider_green_Scroll);
            // 
            // lbl_sliderRed
            // 
            resources.ApplyResources(this.lbl_sliderRed, "lbl_sliderRed");
            this.lbl_sliderRed.Name = "lbl_sliderRed";
            this.toolTip1.SetToolTip(this.lbl_sliderRed, resources.GetString("lbl_sliderRed.ToolTip"));
            // 
            // lbl_sliderGreen
            // 
            resources.ApplyResources(this.lbl_sliderGreen, "lbl_sliderGreen");
            this.lbl_sliderGreen.Name = "lbl_sliderGreen";
            this.toolTip1.SetToolTip(this.lbl_sliderGreen, resources.GetString("lbl_sliderGreen.ToolTip"));
            // 
            // lbl_sliderBlue
            // 
            resources.ApplyResources(this.lbl_sliderBlue, "lbl_sliderBlue");
            this.lbl_sliderBlue.Name = "lbl_sliderBlue";
            this.toolTip1.SetToolTip(this.lbl_sliderBlue, resources.GetString("lbl_sliderBlue.ToolTip"));
            // 
            // lbl_sliderRed_val
            // 
            resources.ApplyResources(this.lbl_sliderRed_val, "lbl_sliderRed_val");
            this.lbl_sliderRed_val.Name = "lbl_sliderRed_val";
            this.toolTip1.SetToolTip(this.lbl_sliderRed_val, resources.GetString("lbl_sliderRed_val.ToolTip"));
            // 
            // lbl_sliderGreen_val
            // 
            resources.ApplyResources(this.lbl_sliderGreen_val, "lbl_sliderGreen_val");
            this.lbl_sliderGreen_val.Name = "lbl_sliderGreen_val";
            this.toolTip1.SetToolTip(this.lbl_sliderGreen_val, resources.GetString("lbl_sliderGreen_val.ToolTip"));
            // 
            // lbl_sliderBlue_val
            // 
            resources.ApplyResources(this.lbl_sliderBlue_val, "lbl_sliderBlue_val");
            this.lbl_sliderBlue_val.Name = "lbl_sliderBlue_val";
            this.toolTip1.SetToolTip(this.lbl_sliderBlue_val, resources.GetString("lbl_sliderBlue_val.ToolTip"));
            // 
            // lbl_current_color
            // 
            resources.ApplyResources(this.lbl_current_color, "lbl_current_color");
            this.lbl_current_color.Name = "lbl_current_color";
            this.toolTip1.SetToolTip(this.lbl_current_color, resources.GetString("lbl_current_color.ToolTip"));
            // 
            // current_color_box
            // 
            resources.ApplyResources(this.current_color_box, "current_color_box");
            this.current_color_box.BackColor = System.Drawing.Color.Black;
            this.current_color_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.current_color_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.current_color_box.Name = "current_color_box";
            this.current_color_box.TabStop = false;
            this.toolTip1.SetToolTip(this.current_color_box, resources.GetString("current_color_box.ToolTip"));
            this.current_color_box.Click += new System.EventHandler(this.current_color_box_Click);
            // 
            // paper
            // 
            resources.ApplyResources(this.paper, "paper");
            this.paper.BackColor = System.Drawing.Color.White;
            this.paper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paper.Name = "paper";
            this.paper.TabStop = false;
            this.toolTip1.SetToolTip(this.paper, resources.GetString("paper.ToolTip"));
            this.paper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paper_MouseClick);
            this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paper_MouseDown);
            this.paper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paper_MouseMove);
            this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paper_MouseUp);
            // 
            // lbl_paper_bck_color
            // 
            resources.ApplyResources(this.lbl_paper_bck_color, "lbl_paper_bck_color");
            this.lbl_paper_bck_color.Name = "lbl_paper_bck_color";
            this.toolTip1.SetToolTip(this.lbl_paper_bck_color, resources.GetString("lbl_paper_bck_color.ToolTip"));
            // 
            // paper_color_box
            // 
            resources.ApplyResources(this.paper_color_box, "paper_color_box");
            this.paper_color_box.BackColor = System.Drawing.Color.White;
            this.paper_color_box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paper_color_box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paper_color_box.Name = "paper_color_box";
            this.paper_color_box.TabStop = false;
            this.toolTip1.SetToolTip(this.paper_color_box, resources.GetString("paper_color_box.ToolTip"));
            this.paper_color_box.Click += new System.EventHandler(this.paper_color_box_Click);
            // 
            // GraphEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.paper_color_box);
            this.Controls.Add(this.lbl_paper_bck_color);
            this.Controls.Add(this.lbl_BrushSize);
            this.Controls.Add(this.txt_bx_brushSize);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.current_color_box);
            this.Controls.Add(this.lbl_current_color);
            this.Controls.Add(this.lbl_sliderBlue_val);
            this.Controls.Add(this.lbl_sliderGreen_val);
            this.Controls.Add(this.lbl_sliderRed_val);
            this.Controls.Add(this.lbl_sliderBlue);
            this.Controls.Add(this.lbl_sliderGreen);
            this.Controls.Add(this.lbl_sliderRed);
            this.Controls.Add(this.slider_green);
            this.Controls.Add(this.slider_blue);
            this.Controls.Add(this.slider_red);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GraphEdit";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.GraphEdit_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.current_color_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_color_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tools_pen;
        private System.Windows.Forms.ToolStripLabel placeholder1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton tools_brush;
        private System.Windows.Forms.ToolStripButton tools_pickColor;
        private System.Windows.Forms.ToolStripButton tools_eraser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tools_line;
        private System.Windows.Forms.ToolStripButton tools_circle;
        private System.Windows.Forms.ToolStripButton tools_rectangle;
        private System.Windows.Forms.TextBox txt_bx_brushSize;
        private System.Windows.Forms.Label lbl_BrushSize;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.TrackBar slider_red;
        private System.Windows.Forms.TrackBar slider_blue;
        private System.Windows.Forms.TrackBar slider_green;
        private System.Windows.Forms.Label lbl_sliderRed;
        private System.Windows.Forms.Label lbl_sliderGreen;
        private System.Windows.Forms.Label lbl_sliderBlue;
        private System.Windows.Forms.Label lbl_sliderRed_val;
        private System.Windows.Forms.Label lbl_sliderGreen_val;
        private System.Windows.Forms.Label lbl_sliderBlue_val;
        private System.Windows.Forms.Label lbl_current_color;
        private System.Windows.Forms.PictureBox current_color_box;
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.Label lbl_paper_bck_color;
        private System.Windows.Forms.PictureBox paper_color_box;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton removeImage_button;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}