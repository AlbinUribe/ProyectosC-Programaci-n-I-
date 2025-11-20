namespace Proyecto2C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Play
            Player.Ctlcontrols.play();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Buscar
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Pause
            Player.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
