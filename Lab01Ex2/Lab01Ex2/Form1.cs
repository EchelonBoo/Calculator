using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declare variable to hold first num
        decimal num1 = 0;
        decimal num2 = 0;


        //Conditional statements for = button
        bool ClickPlus = false;
        bool ClickMinus = false;
        bool ClickMult = false;
        bool ClickDivide = false;


        private void button0_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text += button10.Text;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            TextBox1.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            /*  num1 += decimal.Parse(TextBox1.Text);
              TextBox1.Clear();*/


            num1 += decimal.Parse(TextBox1.Text);
            TextBox1.Clear();

            ClickPlus = true;
            ClickMinus = false;
            ClickMult = false;
            ClickDivide = false;


        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            num1 += decimal.Parse(TextBox1.Text);
            TextBox1.Clear();

            ClickPlus = false;
            ClickMinus = true;
            ClickMult = false;
            ClickDivide = false;

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            num1 += decimal.Parse(TextBox1.Text);
            TextBox1.Clear();

            ClickPlus = false;
            ClickMinus = false;
            ClickMult = true;
            ClickDivide = false;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            num1 += decimal.Parse(TextBox1.Text);
            TextBox1.Clear();

            ClickPlus = false;
            ClickMinus = false;
            ClickMult = false;
            ClickDivide = true;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            /* num2 = num1 + decimal.Parse(TextBox1.Text);
             TextBox1.Text = num2.ToString();
             num1 = 0;*/ // sets the first variable back to 0 to allow multiple numbers to be added together

            if(ClickPlus == true)
            {
                num2 = num1 + decimal.Parse(TextBox1.Text);
                TextBox1.Text = num2.ToString();
                num1 = 0;  // sets the first variable back to 0 to allow multiple numbers to be added together
            }
            else if (ClickMinus == true)
            {
                num2 = num1 - decimal.Parse(TextBox1.Text);
                TextBox1.Text = num2.ToString();
                num1 = 0;
            }
            else if (ClickMult == true)
            {
                num2 = num1 * decimal.Parse(TextBox1.Text);
                TextBox1.Text = num2.ToString();
                num1 = 0;
            }
            else if (ClickDivide == true)
            {
                num2 = num1 / decimal.Parse(TextBox1.Text);
                TextBox1.Text = num2.ToString();
                num1 = 0;
            }
        }

    }
}
