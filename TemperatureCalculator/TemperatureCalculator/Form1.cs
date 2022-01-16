namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string strUserInputC = textBoxC.Text;
            double dUserInputC = 0.0;

            double.TryParse(strUserInputC, out dUserInputC);
            double f = dUserInputC * 1.8 + 32;

            textBoxF.Text = f.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strUserInputF = textBoxF.Text;
            double dUserInputF = 0.0;

            double.TryParse(strUserInputF, out dUserInputF);
            double c = (dUserInputF - 32)/1.8 ;

            textBoxC.Text = c.ToString();
        }
    }
}