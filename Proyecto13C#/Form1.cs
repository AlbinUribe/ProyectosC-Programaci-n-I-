namespace Proyecto13C_
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();

        int addNum1;
        int addNum2;

        int minusNum1;
        int minusNum2;

        int multiplyNum1;
        int multiplyNum2;

        int divideNum1;
        int divideNum2;
        int clock;

        public void StartQuiz()
        {

            addNum1 = randomizer.Next(51);
            addNum2 = randomizer.Next(51);
            plusLeftLabel.Text = addNum1.ToString();
            plusRigthLabel.Text = addNum2.ToString();

            adiccion.Value = 0;

            minusNum1 = randomizer.Next(1, 101);
            minusNum2 = randomizer.Next(1, minusNum1);
            minusLeftLabel.Text = minusNum1.ToString();
            minusRigthLabel.Text = minusNum2.ToString();
            difference.Value = 0;

            multiplyNum1 = randomizer.Next(2, 11);
            multiplyNum2 = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplyNum1.ToString();
            timesRigthLabel.Text = multiplyNum2.ToString();
            product.Value = 0;

            divideNum2 = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            divideNum1 = divideNum2 * temporaryQuotient;
            divideLeftLabel.Text = divideNum1.ToString();
            divideRigthLabel.Text = divideNum2.ToString();
            quotient.Value = 0;

            clock = 30;
            timeLabel.Text = "30 segundos";
            timer1.Start();




        }

        private bool CheckTheAnswer()
        {
            if ((addNum1 + addNum2 == adiccion.Value)
                && (minusNum1 - minusNum2 == difference.Value)
                && (multiplyNum1 * multiplyNum2 == product.Value)
                && (divideNum1 / divideNum2 == quotient.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock > 0)
            {

                clock = clock - 1;
                timeLabel.Text = clock + " segundos";

            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Se acabo el tiempo";
                MessageBox.Show("Se termino el tiempo");

                //Comprobar respuestas
                adiccion.Value = addNum1 + addNum2;
                difference.Value = minusNum1 - minusNum2;
                product.Value = multiplyNum1 * multiplyNum2;
                quotient.Value = divideNum1 / divideNum2;

            }
        }

        private void Answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        { 
           StartQuiz();
            startButton.Enabled = true;

        }
    }
}