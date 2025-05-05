using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button6 = (Button)sender;
            textBox1.Text += button6.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button3 = (Button)sender;
            textBox1.Text += button3.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button7 = (Button)sender;
            textBox1.Text += button7.Text;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                
                string expression = textBox1.Text.Replace("−", "-");

                
                var result = new DataTable().Compute(expression, null);
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
            }
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Button buttonDivide = (Button)sender;
            textBox1.Text += buttonDivide.Text;
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text.StartsWith("-"))
            {
                textBox1.Text = textBox1.Text.Substring(0);
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            
            string[] operators = { "+", "-", "*", "/" };
            bool endsWithOperator = operators.Any(op => textBox1.Text.EndsWith(op));

            
            bool containsDecimal = textBox1.Text.Contains(".");

            
            if (textBox1.Text == "" || endsWithOperator)
            {
                
                textBox1.Text += "0.";
            }
            else if (!containsDecimal)
            {
                
                textBox1.Text += button.Text;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Button button3 = (Button)sender;
            textBox1.Text += button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button2 = (Button)sender;
            textBox1.Text += button2.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button button1 = (Button)sender;
            textBox1.Text += button1.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button button0 = (Button)sender;
            textBox1.Text += button0.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button5 = (Button)sender;
            textBox1.Text += button5.Text;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Button button6 = (Button)sender;
            textBox1.Text += button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button9 = (Button)sender;
            textBox1.Text += button9.Text;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Button buttonMultiply = (Button)sender;
            textBox1.Text += buttonMultiply.Text;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button buttonAdd = (Button)sender;
            textBox1.Text += buttonAdd.Text;
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Button buttonSubtract = (Button)sender;
            textBox1.Text += buttonSubtract.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button4 = (Button)sender;
            textBox1.Text += button4.Text;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void buttonPercent_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;


                expression = expression.Replace("−", "-");

                var result = new DataTable().Compute(expression, null);

                
                double value = Convert.ToDouble(result) / 100;


                textBox1.Text = value.ToString("P");
            }
            catch (Exception ex)
            {

                textBox1.Text = "Error";
            }
        }
    }
}
