using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculadorApp
{
    public partial class Form1 : Form
    {
        string userInput = string.Empty;
        string operando1 = string.Empty;
        string operando2 = string.Empty;
        char operador = '\0';
        double resultado = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void clearText()
        {
            calculatorDisplay.Text = string.Empty;
        }

        private void num1Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "1";
            calculatorDisplay.Text += userInput;
        }

        private void num2Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "2";
            calculatorDisplay.Text += userInput;
        }

        private void num3Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "3";
            calculatorDisplay.Text += userInput;
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "4";
            calculatorDisplay.Text += userInput;
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "5";
            calculatorDisplay.Text += userInput;
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "6";
            calculatorDisplay.Text += userInput;
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "7";
            calculatorDisplay.Text += userInput;
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "8";
            calculatorDisplay.Text += userInput;
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "9";
            calculatorDisplay.Text += userInput;
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            clearText();
            userInput += "0";
            calculatorDisplay.Text += userInput;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            operando2 = userInput;
            double num1, num2;
            _ = double.TryParse(operando1, out num1);
            _ = double.TryParse(operando2, out num2);

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    calculatorDisplay.Text = resultado.ToString();
                    break;
                case '-':
                    resultado = num1 - num2;
                    calculatorDisplay.Text = resultado.ToString();
                    break;
                case '*':
                    resultado = num1 * num2;
                    calculatorDisplay.Text = resultado.ToString();
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        calculatorDisplay.Text = resultado.ToString();
                    }
                    else
                    {
                        calculatorDisplay.Text = "WTF br0?";
                    }
                    break;
                case 'm':
                    resultado = num1 % num2;
                    calculatorDisplay.Text = resultado.ToString();
                    break;
                case '%':
                    resultado = num1 * (num2 / 100);
                    calculatorDisplay.Text = resultado.ToString();
                    break;
                case '^':
                    resultado = Math.Pow(num1, num2);
                    calculatorDisplay.Text = resultado.ToString();
                    break;
                default:
                    break;
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            operador = '+';
            operando1 = userInput;
            userInput = string.Empty;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            operador = '-';
            operando1 = userInput;
            userInput = string.Empty;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operador = '*';
            operando1 = userInput;
            userInput = string.Empty;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operador = '/';
            operando1 = userInput;
            userInput = string.Empty;
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            operador = 'm';
            operando1 = userInput;
            userInput = string.Empty;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            userInput += ".";
            calculatorDisplay.Text += userInput;
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(userInput, out num1);
            calculatorDisplay.Text = Math.Log10(num1).ToString();

        }

        private void percentButton_Click(object sender, EventArgs e)
        {
            operador = '%';
            operando1 = userInput;
            userInput = string.Empty;
        }

        private void exponentButton_Click(object sender, EventArgs e)
        {
            operador = '^';
            operando1 = userInput;
            userInput = string.Empty;
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            double num1;
            double.TryParse(userInput, out num1);
            calculatorDisplay.Text = Math.Sqrt(num1).ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            operador = '\0';
            userInput = string.Empty;
            operando1 = string.Empty;
            operando2 = string.Empty;
            resultado = 0.0;
            calculatorDisplay.Text = "0";
        }
    }
}
