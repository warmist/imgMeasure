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
        public Form1()
        {
            InitializeComponent();
        }
        private void clear()
        {

        }
        private void updateAreas()
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                
                
                SolidBrush redBrush = new SolidBrush(Color.FromArgb(160, 255, 0, 0));
                Graphics g = Graphics.FromImage(layer1);
                g.CompositingMode = CompositingMode.SourceCopy;
                g.FillEllipse(redBrush, e.X - size / 2, e.Y - size / 2, size, size);
                updateAreas();
                pictureBox1.Invalidate();
            }
        }
    }
}
