using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

namespace WordCat
{
    public partial class GraphEdit : Form
    {

        Color paint_color;
        bool choose = false;
        bool draw = false;
        int x, y, lx ,ly = 0;
        Item currentItem;

        public GraphEdit()
        {
            InitializeComponent();
        }

        public enum Item
        {

            Rectangle, Ellipse, Line, Brush, Pencil, Eraser, ColorPicker, NONE

        }

        //COLOR PICKER (ELEMENT)
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            choose = false;
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (choose = true)
            {

                Bitmap bmp = (Bitmap)colorPicker.Image.Clone();
                paint_color = bmp.GetPixel(e.X, e.Y);
                slider_red.Value = paint_color.R;
                slider_green.Value = paint_color.G;
                slider_green.Value = paint_color.B;
                lbl_sliderRed_val.Text = paint_color.R.ToString();
                lbl_sliderGreen_val.Text = paint_color.G.ToString();
                lbl_sliderBlue_val.Text = paint_color.B.ToString();
                current_color_box.BackColor = paint_color;
            }

        }

        private void slider_red_Scroll(object sender, EventArgs e)
        {
            paint_color = Color.FromArgb(255, slider_red.Value, slider_green.Value, slider_blue.Value);
            current_color_box.BackColor = paint_color;
            lbl_sliderRed_val.Text = paint_color.R.ToString();
        }

        private void slider_green_Scroll(object sender, EventArgs e)
        {
            paint_color = Color.FromArgb(255, slider_red.Value, slider_green.Value, slider_blue.Value);
            current_color_box.BackColor = paint_color;
            lbl_sliderGreen_val.Text = paint_color.G.ToString();
        }

        private void slider_blue_Scroll(object sender, EventArgs e)
        {
            paint_color = Color.FromArgb(255, slider_red.Value, slider_green.Value, slider_blue.Value);
            current_color_box.BackColor = paint_color;
            lbl_sliderBlue_val.Text = paint_color.B.ToString();
        }


        private void current_color_box_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {

                paint_color = cd.Color;

                current_color_box.BackColor = cd.Color;
                slider_red.Value = cd.Color.R;
                slider_red.Value = cd.Color.G;
                slider_red.Value = cd.Color.B;
                lbl_sliderRed_val.Text = cd.Color.R.ToString();
                lbl_sliderGreen_val.Text = cd.Color.G.ToString();
                lbl_sliderBlue_val.Text = cd.Color.B.ToString();


            }
        }

        private void paper_color_box_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                paper.BackColor = cd.Color;

                paper_color_box.BackColor = cd.Color;

            }
        }
        //COLOR PICKER (ELEMENT).



        //FORM
        private void GraphEdit_Load(object sender, EventArgs e)
        {
            currentItem = Item.NONE;
        }



        //FORM.

        //DRAWING
        private void paper_MouseClick(object sender, MouseEventArgs e)
        {

            if(currentItem == Item.ColorPicker)
            {

                Bitmap bmp = new Bitmap(paper.Width, paper.Height);
                Graphics g = Graphics.FromImage(bmp);
                Rectangle rect = paper.RectangleToScreen(paper.ClientRectangle);
                g.CopyFromScreen(rect.Location, Point.Empty, paper.Size);
                g.Dispose();
                paint_color = bmp.GetPixel(e.X, e.Y);
                current_color_box.BackColor = paint_color;
                slider_red.Value = paint_color.R;
                slider_red.Value = paint_color.G;
                slider_red.Value = paint_color.B;
                lbl_sliderRed.Text = paint_color.R.ToString();
                lbl_sliderGreen.Text = paint_color.G.ToString();
                lbl_sliderBlue.Text = paint_color.B.ToString();
                bmp.Dispose();

            }

        }



        private void paper_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
        }



        private void paper_MouseMove(object sender, MouseEventArgs e)
        {
            if(draw)
            {

                Graphics g = paper.CreateGraphics();
                switch(currentItem)
                {

                    case Item.Rectangle:
                        g.FillRectangle(new SolidBrush(paint_color), x, y, e.X - x, e.Y - y);

                        break;
                    case Item.Ellipse:
                        g.FillEllipse(new SolidBrush(paint_color), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Brush:
                        g.FillEllipse(new SolidBrush(paint_color), e.X - x + x, e.Y - y + y, Convert.ToInt32(txt_bx_brushSize.Text), Convert.ToInt32(txt_bx_brushSize.Text));
                        break;
                    case Item.Pencil:
                        g.FillEllipse(new SolidBrush(paint_color), e.X - x + x, e.Y - y + y, 9, 9);
                        break;
                    case Item.Eraser:
                        g.FillEllipse(new SolidBrush(paper.BackColor), e.X - x + x, e.Y - y + y, Convert.ToInt32(txt_bx_brushSize.Text), Convert.ToInt32(txt_bx_brushSize.Text));
                        break;

                }
                g.Dispose();
                

            }
        }



        private void paper_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            lx = e.X;
            ly = e.Y;
            if(currentItem == Item.Line)
            {

                Graphics g = paper.CreateGraphics();
                g.DrawLine(new Pen(new SolidBrush(paint_color)), new Point(x, y), new Point(lx, ly));
                g.Dispose();

            }
        }



        //DRAWING




        //TOOLS SELECT

        private void tools_line_Click(object sender, EventArgs e)
        {
            currentItem = Item.Line;
        }

        private void tools_pen_Click(object sender, EventArgs e)
        {
            currentItem = Item.Pencil;
        }

        private void tools_pickColor_Click(object sender, EventArgs e)
        {
            currentItem = Item.ColorPicker;
        }

        private void tools_eraser_Click(object sender, EventArgs e)
        {
            currentItem = Item.Eraser;
        }



        private void tools_rectangle_Click(object sender, EventArgs e)
        {
            currentItem = Item.Rectangle;
        }



        private void tools_circle_Click(object sender, EventArgs e)
        {
            currentItem = Item.Ellipse;
        }


        private void tools_brush_Click(object sender, EventArgs e)
        {
            currentItem = Item.Brush;
        }



        //TOOLS SELECT.

        //Menu Strip
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            paper.Refresh();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "PNG-Files|*.png|JPEG-Files|*.jpg|Bitmap|*.bmp";
            o.Title = "Open File";

            if(o.ShowDialog() == DialogResult.OK)
            {

                paper.Image = (Image)Image.FromFile(o.FileName).Clone();

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(paper.Width, paper.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = paper.RectangleToScreen(paper.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, paper.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "PNG-Files|*.png|JPEG-Files|*.jpg|Bitmap|*.bmp";
            s.Title = "Open File";

            if (s.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(s.FileName))
                {

                    File.Delete(s.FileName);

                }

                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }

            }


        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            paper.Image = null;
        }
    }
}
