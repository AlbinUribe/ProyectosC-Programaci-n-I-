using System.Net.Sockets;

namespace Proyecto17C_
{
    public partial class GameForm : Form
    {
        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;
        public GameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            Raquet.Top = PlayGround.Bottom - (PlayGround.Bottom / 10);

            GameOver_Lbl.Left = (PlayGround.Width / 2) - (GameOver_Lbl.Width / 2);
            GameOver_Lbl.Top = (PlayGround.Height / 2) - (GameOver_Lbl.Height / 2);
            GameOver_Lbl.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Raquet.Left = Cursor.Position.X - (Raquet.Width / 2);
            Ball.Left += speed_left;
            Ball.Top += speed_top;

            if (Ball.Bottom >= Raquet.Top && Ball.Bottom <= Raquet.Bottom && Ball.Left >= Raquet.Left && Ball.Right <= Raquet.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                Points_Lbl.Text = points.ToString();

                Random r = new Random();
                PlayGround.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }
            if (Ball.Left <= PlayGround.Left)
            {
                speed_left = -speed_left;
            }
            if (Ball.Right >= PlayGround.Right)
            {
                speed_left = -speed_left;
            }
            if (Ball.Top <= PlayGround.Top)
            {
                speed_top = -speed_top;
            }
            if (Ball.Bottom >= PlayGround.Bottom)
            {

                timer1.Enabled = false;
                GameOver_Lbl.Visible = true;
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                Ball.Top = 50;
                Ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                Points_Lbl.Text = "0";
                timer1.Enabled = true;
                GameOver_Lbl.Visible = true;
                PlayGround.BackColor = Color.White;
            }
        }
    }
}