namespace Proyecto4C_
{
    public partial class Form1 : Form
    {
 

        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void FinishLabel_MouseEnter(object sender, EventArgs e)
        {
   
            MessageBox.Show("¡Felicidades! Has llegado al final del laberinto.");
            Close();
        }
        private void MoveToStart()
        {

            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void Colision(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
