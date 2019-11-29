using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long fact = 1;
        public double a;
        public double b;
        public char c;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 9;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + 3;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ",";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);
                c = '-';
                textBox2.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);
                c = '+';
                textBox2.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox2.Text);
            textBox2.Text = "";
            switch(c)
            {
                case '+':
                    textBox2.Text = Convert.ToString(a + b);
                    break;

                case '-':
                    textBox2.Text = Convert.ToString(a - b);
                    break;

                case '*':
                    textBox2.Text = Convert.ToString(a * b);
                    break;

                case '/':
                    textBox2.Text = Convert.ToString(a / b);
                    break;

                case '^':
                    textBox2.Text = Convert.ToString(Math.Pow(a, b));
                    break;

                case 'l':
                    textBox2.Text = Convert.ToString(Math.Log(a) / Math.Log(b));
                    break;

                case 's':
                    textBox2.Text = Convert.ToString(Math.Pow(a, 1 / b));
                    break;
                    
            }

        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + ";";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);
                c = '*';
                textBox2.Text = "";
            }
            catch(Exception)
            { 
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox2.Text);
                c = '/';
                textBox2.Text = "";
            }
            catch (Exception)
            {
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Pow(a, 2));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            textBox2.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            c = 's';
            textBox2.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            c = '^';
            textBox2.Text = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            c = 'l';
            textBox2.Text = "";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox2.Text);
            for(long i = 2; i <= a; i++)
            {
                fact *= i;
            }
            

            textBox2.Text = fact.ToString();
        }
    }
}
