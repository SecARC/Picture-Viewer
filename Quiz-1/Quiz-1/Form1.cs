using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Lime;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select an Image";
            ofd.Filter = "Gif Images|*.gif|JPEG Images|*.jpg";
            ofd.FilterIndex = 2;
            ofd.Multiselect = false;
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.Cancel)
                return;

            
            Image image = Image.FromFile(ofd.FileName);
            pictureBox1.Image = image;
            textBox1.Text = ofd.FileName;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure want to reset the form?",
                "Form is resetting...",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign
                );

            if (result == DialogResult.Yes)
            {
                textBox1.Text = @"C:\...";
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                

                Random random = new Random((int)DateTime.Now.Ticks);
                int x = random.Next(0, 320 + 1);
                int y = random.Next(0, 180 + 1);
                Graphics g = pictureBox1.CreateGraphics();

                if (x > y)
                {
                    g.DrawRectangle(Pens.Red, x, y, 80, 40);
                }
                else
                {
                    g.DrawRectangle(Pens.Red, y, x, 80, 40);
                }
                g.Clear(Color.White);
            }

        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnStretch_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnPicReset_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.Empty);
        }

        private void btnUIReset_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Random random = new Random();
            int x = random.Next(0, 320 + 1);
            int y = random.Next(0, 180 + 1);
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            var bm = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            pictureBox1.DrawToBitmap(bm, pictureBox1.ClientRectangle);
            g.DrawImage(bm, 0, 0);
            g.DrawRectangle(Pens.Red, x, y, 80, 40);
        }

        private void btnDrawBorder_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawRectangle(Pens.Red, 120, 70, 80, 40);
        }
    }
}
