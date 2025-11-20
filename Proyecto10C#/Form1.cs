namespace Proyecto10C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hourMinuteLabel.Text = DateTime.Now.ToString("HH:mm");
            SecondsLabel.Text = DateTime.Now.ToString("ss");
            DateLabel.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
            WeekLabel.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
