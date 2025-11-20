using System.Windows.Forms;

namespace Proyecto6C_
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        bool dibujar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dibujar)
                dibujar = false;
            else
                dibujar = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujar)
            {

                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y, 5, 5);
                pictureBox1.Image = bmp;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Rojo
            p.Color = Color.Crimson;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Azul
            p.Color = Color.MediumBlue;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Verde
            p.Color = Color.Green;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Morado
            p.Color = Color.DarkMagenta;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //Amarillo
            p.Color = Color.Gold;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            //Negro
            p.Color = Color.Black;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            //Blanco
            p.Color = Color.White;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile())
                {
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                    }
                }
            }

        }
    }
}
