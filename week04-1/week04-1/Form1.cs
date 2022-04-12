using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week04_1
{
    public partial class Form1 : Form
    {
        public bool isActive { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;

            DialogResult result = MessageBox.Show(
                "Are you sure want to close the form?",
                "Form closing...",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign
                );

            //if (result == DialogResult.Cancel)
            //    e.Cancel = true;

            e.Cancel = (result == DialogResult.Cancel);
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
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
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            //Graphics g = pictureBox1.CreateGraphics();
            //g.DrawImage(image, new PointF(0, 0));
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Select a File Location and Name";
            sfd.Filter = "Gif Images|*.gif|JPEG Images|*.jpg";
            sfd.FilterIndex = 2;
            DialogResult result = sfd.ShowDialog();

            if (result == DialogResult.Cancel)
                return;


            Image image = pictureBox1.Image;
            image.Save(sfd.FileName);

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            labelCoordinate.Text = string.Format("X: {0}\nY: {1}", e.X, e.Y);

            if (isActive)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawEllipse(Pens.DarkBlue, e.X, e.Y, 12, 12);
            }            
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();

            g.DrawRectangle(Pens.Maroon, e.X, e.Y, 32, 16);


            isActive = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isActive = true;
        }
    }
}
