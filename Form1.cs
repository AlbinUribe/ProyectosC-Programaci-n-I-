namespace Proyecto7C_
{
    public partial class currencyConvert : Form
    {
        public currencyConvert()
        {
            InitializeComponent();
        }

        private void Converter_Click(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.foreignexchangeresource.com/currency-converter.php?c=CAD&a=USD&amt=1&panel=1&button=2");

        }
    }
}
