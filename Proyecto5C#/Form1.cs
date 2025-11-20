namespace Proyecto5C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cerrar
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Fondo
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Quitar foto
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Mostrar foto
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { 
            
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;   
        }
    }
}
