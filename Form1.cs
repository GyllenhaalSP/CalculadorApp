using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadorApp
{
    public partial class Form1 : Form
    {
        string userInput = "";
        string operando1 = "";
        string operando2 = "";
        char operador;
        double resultado = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void num1Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "1";
        }

        private void num2Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "2";
        }

        private void num3Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "3";
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "4";
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "5";
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "6";
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "7";
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "8";
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "9";
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "0";
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            operador = '=';
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            operador = '+';
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            operador = '-';
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operador = '*';
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operador = '/';
        }

        private void modButton_Click(object sender, EventArgs e)
        {

        }

        private void decimalButton_Click(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {

        }

        private void percentButton_Click(object sender, EventArgs e)
        {

        }

        private void exponentButton_Click(object sender, EventArgs e)
        {

        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            operador = 'c';
        }
    }
}
