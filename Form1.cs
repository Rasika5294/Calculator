using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WForms
{
    public partial class Form1 : Form
    {
        double result_value;
        string operationPerform = "";
        bool isOperationPerformed = false;             
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Results.Text == "0") || (isOperationPerformed))
                textBox_Results.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Results.Text.Contains("."))
                    textBox_Results.Text = textBox_Results.Text + button.Text;
            }
            else
            {
                textBox_Results.Text = textBox_Results.Text + button.Text;
            }
            
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            operationPerform = button.Text;
            result_value = double.Parse(textBox_Results.Text);
            lblCurrentOperator.Text = result_value + " " + operationPerform;
            isOperationPerformed = true;
            

        }

        private void BtnClearTxtBox_Click(object sender, EventArgs e)
        {
            textBox_Results.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            textBox_Results.Text = "0";
            result_value = 0;
        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            switch(operationPerform)
            {
                case "+":
                    textBox_Results.Text = (result_value + double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "-":
                    textBox_Results.Text = (result_value - double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "*":
                    textBox_Results.Text = (result_value * double.Parse(textBox_Results.Text)).ToString();
                    break;
                case "/":
                    textBox_Results.Text = (result_value / double.Parse(textBox_Results.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void lblCurrentOperator_Click(object sender, EventArgs e)
        {

        }
    }
}
