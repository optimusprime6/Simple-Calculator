using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public decimal var1;
        public decimal var2;
        public int i = 0;

        public string operators;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            //textBox1.Text = "+";
            operators = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            //textBox1.Text = "-";
            operators = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            //textBox1.Text = "*";
            operators = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = null;
            //textBox1.Text = "/";
            operators = "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(operators == "+")
            {
                var2 = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString(var1 + var2);
            }

            else if (operators == "-")
            {
                var2 = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString(var1 - var2);
            }

            else if (operators == "*")
            {
                var2 = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString(var1 * var2);
            }

            else if (operators == "/")
            {
                var2 = Convert.ToDecimal(textBox1.Text);
                textBox1.Text = Convert.ToString(var1 / var2);
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            /* int n = textBox1.Text.Length;
             n = n - 1;
             textBox1.Text = null; */
            int n = textBox1.Text.Length - 1;
            textBox1.Text = textBox1.Text.Remove(n);
        }
    }
}
