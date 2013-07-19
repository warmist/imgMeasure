using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace imgMeasures
{
    public partial class Form1 : Form
    {
        Bitmap layer1;
        Bitmap layer2;
        PointF l11, l12;
        PointF l21, l22;
        enum DrawMode
        {
            None, Area1, EraseArea1, Area2, EraseArea2, Line1, Line2
        };
        DrawMode currentMode=DrawMode.None;
        public Form1()
        {
            InitializeComponent();
        }
        private void clear()
        {
            l11.X = -1;
            l21.X = -1;
            layer1 = null;
            layer2 = null;
        }
        private void updateLineCalcs()
        {
            if (l11.X > 0)
            {
                double dx = l12.X - l11.X;
                double dy = l12.Y - l11.Y;
                double dist = System.Math.Sqrt(dx * dx + dy * dy);
                txtLine1.Text = dist.ToString("F2");
            }
            else
            {
                txtLine1.Text = "0";
            }
            if (l21.X > 0)
            {
                double dx = l22.X - l21.X;
                double dy = l22.Y - l21.Y;
                double dist = System.Math.Sqrt(dx * dx + dy * dy);
                txtLine2.Text = dist.ToString("F2");
            }
            else
            {
                txtLine2.Text = "0";
            }
            if (l21.X > 0 && l11.X > 0)
            {
                double dx1 = l12.X - l11.X;
                double dy1 = l12.Y - l11.Y;
                
                double dx2 = l22.X - l21.X;
                double dy2 = l22.Y - l21.Y;

                double dist1 = System.Math.Sqrt(dx1 * dx1 + dy1 * dy1);
                double dist2 = System.Math.Sqrt(dx2 * dx2 + dy2 * dy2);

                double cosTheta = (dx1 * dx2 + dy1 * dy2) / (dist1 * dist2);
                double angle = (System.Math.Acos(cosTheta)/System.Math.PI)*180;
                txtAngle.Text = angle.ToString("F2");
            }
        }
        private void updateAreas()
        {
            if (layer1 == null || layer2 == null)
            {
                txtArea1.Text = "0";
                txtArea2.Text = "0";
                return;
            }
            long l1 = 0, l2 = 0;
            
            LockBitmap lockBitmap1 = new LockBitmap(layer1);
            LockBitmap lockBitmap2 = new LockBitmap(layer2);
            lockBitmap1.LockBits(true);
            lockBitmap2.LockBits(true);

            Color compareClr1 = Color.FromArgb(160, 255, 0, 0);
            Color compareClr2 = Color.FromArgb(160, 0, 0, 255);
            for (int y = 0; y < lockBitmap1.Height; y++)
            {
                for (int x = 0; x < lockBitmap1.Width; x++)
                {
                    if (lockBitmap1.GetPixel(x, y) == compareClr1)
                    {
                        l1++;
                    }
                    if (lockBitmap2.GetPixel(x, y) == compareClr2)
                    {
                        l2++;
                    }
                }
            }
            lockBitmap1.UnlockBits();
            lockBitmap2.UnlockBits();
           
            txtArea1.Text = l1.ToString();
            txtArea2.Text = l2.ToString();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.Line1;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            clear();
                            Image newImg=Image.FromStream(myStream);
                            pictureBox1.Image = newImg;
                            layer1 = new Bitmap(newImg.Width, newImg.Height);
                            layer2 = new Bitmap(newImg.Width, newImg.Height);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (layer1 != null && layer2 != null)
            {
                e.Graphics.DrawImage(layer1, new Point(0, 0));
                e.Graphics.DrawImage(layer2, new Point(0, 0));
                SolidBrush whiteBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 0));
                if (l11.X > 0)
                    e.Graphics.DrawLine(new Pen(whiteBrush),l11, l12);
                if (l21.X > 0)
                    e.Graphics.DrawLine(new Pen(whiteBrush), l21, l22);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            const float size = 10;
            if (layer1 == null || layer2 == null)
                return;
            if (e.Button == MouseButtons.Left)
            {

                if (currentMode == DrawMode.Area1 || currentMode == DrawMode.EraseArea1)
                {
                    SolidBrush dBrush;
                    if (currentMode == DrawMode.Area1)
                        dBrush= new SolidBrush(Color.FromArgb(160, 255, 0, 0));
                    else
                        dBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
                    Graphics g = Graphics.FromImage(layer1);
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.FillEllipse(dBrush, e.X - size / 2, e.Y - size / 2, size, size);
                }
                if (currentMode == DrawMode.Area2 || currentMode == DrawMode.EraseArea2)
                {
                    SolidBrush dBrush;
                    if (currentMode == DrawMode.Area2)
                        dBrush = new SolidBrush(Color.FromArgb(160, 0, 0,255));
                    else
                        dBrush = new SolidBrush(Color.FromArgb(0, 0, 0, 0));
                    Graphics g = Graphics.FromImage(layer2);
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.FillEllipse(dBrush, e.X - size / 2, e.Y - size / 2, size, size);
                }
                if (currentMode == DrawMode.Line1)
                {
                    l12 = new PointF(e.X, e.Y);
                }
                if (currentMode == DrawMode.Line2)
                {
                    l22 = new PointF(e.X, e.Y);
                }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentMode == DrawMode.Line1)
            {
                l12 = new PointF(e.X, e.Y);
                updateLineCalcs();
            } else if (currentMode == DrawMode.Line2)
            {
                l22 = new PointF(e.X, e.Y);
                updateLineCalcs();
            }
            else
                updateAreas();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentMode == DrawMode.Line1)
            {
                l11 = new PointF(e.X, e.Y);
            }
            if (currentMode == DrawMode.Line2)
            {
                l21 = new PointF(e.X, e.Y);
            }
        }

        private void btnDraw1_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.Area1;
        }

        private void btnDraw2_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.Area2;
        }

        private void btnErase1_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.EraseArea1;
        }

        private void btnErase2_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.EraseArea2;
        }

        private void btnLine2_Click(object sender, EventArgs e)
        {
            currentMode = DrawMode.Line2;
        }
    }
}
