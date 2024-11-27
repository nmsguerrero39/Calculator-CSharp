using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0D;

        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = string.Empty;
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "7";
            this.txtResult.Text += input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "8";
            this.txtResult.Text += input;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "9";
            this.txtResult.Text += input;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "4";
            this.txtResult.Text += input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "5";
            this.txtResult.Text += input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "6";
            this.txtResult.Text += input;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "1";
            this.txtResult.Text += input;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "2";
            this.txtResult.Text += input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "3";
            this.txtResult.Text += input;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += "0";
            this.txtResult.Text += input;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
            input += ".";
            this.txtResult.Text += input;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            num1 = Convert.ToDouble(operand1);
            num2 = Convert.ToDouble(operand2);

            if (operation == '+')
            {
                result = num1 + num2;
                txtResult.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtResult.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtResult.Text = result.ToString();
            }
            else if (operation == '/')
            {
                result = num1 / num2;
                txtResult.Text = result.ToString();
            }
            if (num2 != 0)
            {
                result = num1 / num2;
                txtResult.Text = result.ToString();
            }
            else
            {
                txtResult.Text = "DIV/Zero!";
            }
        }
    }
}
