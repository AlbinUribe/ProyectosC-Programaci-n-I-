namespace Proyecto9C_
{
    public partial class Form1 : Form
    {
        double resultado = 0;
        string operadorClick = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void Click_Button(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (ResultadosBox.Text == "0")
            {
                ResultadosBox.Clear();
            }
            if (boton.Text == ".")
            {
                if (!ResultadosBox.Text.Contains("."))
                {
                    ResultadosBox.Text += boton.Text;
                }
            }
            else
            {
                ResultadosBox.Text += boton.Text;
            }
        }
        private void Operator_Click(object sender, EventArgs e)
        {

            Button boton = (Button)sender;

            if (resultado != 0)
            {
                btnIgual.PerformClick();
                operadorClick = boton.Text;
            }
            else
            {
                operadorClick = boton.Text;
                resultado = double.Parse(ResultadosBox.Text);
            }

            // Limpiar la pantalla para escribir el siguiente número
            ResultadosBox.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resultado = 0;
            ResultadosBox.Text = "0";

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operadorClick)
            {
                case "+":
                    ResultadosBox.Text = (resultado + double.Parse(ResultadosBox.Text)).ToString();
                    break;
                case "-":
                    ResultadosBox.Text = (resultado - double.Parse(ResultadosBox.Text)).ToString();
                    break;
                case "x":
                    ResultadosBox.Text = (resultado * double.Parse(ResultadosBox.Text)).ToString();
                    break;
                case "/":
                    ResultadosBox.Text = (resultado / double.Parse(ResultadosBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
