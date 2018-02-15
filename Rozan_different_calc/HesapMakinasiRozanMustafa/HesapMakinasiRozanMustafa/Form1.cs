using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasiRozanMustafa
{
    public partial class Form1 : Form
    {
        string textbox = "";
        int first;
        int second;
        char operation = ' ';
        bool ope_pressed = false;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button15_Click(object sender, EventArgs e)
        {
            second = Convert.ToInt32(textbox);
            switch (operation)
            {
                case '+':
                    textBox1.Text = (first + second).ToString();
                    break;
                case '-':
                    textBox1.Text = (first - second).ToString();
                    break;
                case '*':
                    textBox1.Text = (first * second).ToString();
                    break;
                case '/':
                    if (second != 0)
                    {
                        textBox1.Text = (first / second).ToString();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("dividing by zero error");
                        break;
                    }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
            if (ope_pressed)
                textbox = textbox + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '5';
            if (ope_pressed)
                textbox = textbox + "5";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
            if (ope_pressed)
                textbox = textbox + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '3';
            if (ope_pressed)
                textbox = textbox + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '4';
            if (ope_pressed)
                textbox = textbox + "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '6';
            if (ope_pressed)
                textbox = textbox + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '7';
            if (ope_pressed)
                textbox = textbox + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '8';
            if (ope_pressed)
                textbox = textbox + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '9';
            if (ope_pressed)
                textbox = textbox + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '0';
            if (ope_pressed)
                textbox = textbox + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            first = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + '+';
            ope_pressed = true;
            operation = '+';
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + '-';
            ope_pressed = true;
            operation = '-';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + '*';
            ope_pressed = true;
            operation = '*';
        }

        private void button14_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + '/';
            ope_pressed = true;
            operation = '/';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textbox = "";
            first=0;
            second=0;
            operation = ' ';
            ope_pressed = false;


        }

       
    }
}
