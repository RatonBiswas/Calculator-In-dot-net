using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace Cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Decimal firstNumber = 0.0m;
        private Decimal secondNumber = 0.0m;
        private Decimal Result = 0.0m;
        private string operatorString = "+";
      
        private void deleteZero(int number)
        {
            if(textBox1.Text== "0")
            {
                textBox1.Text = number.ToString();
            }
            else
            {
                textBox1.Text += number.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            deleteZero(1);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            deleteZero(2);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            deleteZero(3);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            deleteZero(4);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            deleteZero(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deleteZero(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteZero(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteZero(8);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteZero(9);
        }
        private void button15_Click(object sender, EventArgs e)
        {
            deleteZero(0);
        }
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }
        private void supplieroperator(string _operator)
        {
            operatorString = _operator;
            firstNumber = decimal.Parse(textBox1.Text);
            textBox1.Text = "";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            supplieroperator("+");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            supplieroperator("*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            supplieroperator("-");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            supplieroperator("/");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            secondNumber = decimal.Parse(textBox1.Text);
            switch (operatorString)
            {
                case "+":
                    Result = firstNumber + secondNumber;
                    break;
                case "-":
                    Result = firstNumber - secondNumber;
                    break;
                case "*":
                    Result = firstNumber * secondNumber;
                    break;
                case "/":
                    try
                    {
                        Result = firstNumber / secondNumber;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "mod":
                    Result = (firstNumber % secondNumber);
                    break;
                case "%":
                    try
                    {
                        Result = firstNumber - ((firstNumber * secondNumber) / 100);
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
            textBox1.Text = Result.ToString();
            textBox2.Text = firstNumber + " " + operatorString + " " + secondNumber + " = " + textBox1.Text;
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try {
                textBox1.Text = (Math.Cos(double.Parse(textBox1.Text))).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (Math.Sin(double.Parse(textBox1.Text))).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (Math.Tan(double.Parse(textBox1.Text))).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (Math.Log(double.Parse(textBox1.Text))).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                long f = 1;
                for (long i = 1; i <= long.Parse(textBox1.Text); i++) { f = f * i; }
                textBox1.Text = f.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            
            string s = "0";
            if (textBox1.Text.Length > 1)
            {
                s = textBox1.Text;
                s = s.Substring(0, s.Length - 1);
            }
            textBox1.Text = s;
            textBox2.Text = s;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            supplieroperator("mod");
        }
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            supplieroperator("%");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
