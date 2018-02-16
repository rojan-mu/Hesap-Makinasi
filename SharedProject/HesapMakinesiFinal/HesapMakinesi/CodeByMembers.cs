﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
       int girdi1 = 0;
        int girdi2 = 0;
        string textgirdi2 = "";
        string textgirdi1 = "";
        int islem = 0;// 1 for + , 2 for - , 3 for * , 4 for /
        int isaret = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        // 1 button
        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "1";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "1";
            

        }
        // + button
        private void button11_Click(object sender, EventArgs e)
        {

             girdi1 = Convert.ToInt32(textBox1.Text.ToString());
            textBox1.Text = textBox1.Text + "+";
            islem = 1;
            isaret = 1;
        }
        // 2 button
        private void button2_Click(object sender, EventArgs e)
        {
                textBox1.Text = textBox1.Text + "2";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "2";
        }
        // 3 button
        private void button3_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + "3";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "3";
        }
        // 4 button
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "4";
        }
        // 5 button
        private void button5_Click(object sender, EventArgs e)
        {
        textBox1.Text = textBox1.Text + "5";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "5";
        }
        // 6 button
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "6";
        }
        // 7 button
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "7";
        }
        // 8 button
        private void button8_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + "8";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "8";
        }
        // 9 button
        private void button7_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + "9";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "9";
        }
        // 0 button
        private void button10_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text + "0";
            if (islem == 1)
                textgirdi2 = textgirdi2 + "0";
        }
        // * button
        private void button14_Click(object sender, EventArgs e)
        {
            girdi1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = textBox1.Text + "*";
            islem = 1;
            isaret = 3;

        }
        // / button
        private void button13_Click(object sender, EventArgs e)
        {
            girdi1 = Convert.ToInt32(textBox1.Text);

            textBox1.Text = textBox1.Text + "/";
            islem = 1;
            isaret = 4;
        }
        // = button
        private void button15_Click(object sender, EventArgs e)
        {
           if (isaret == 1)
                textBox1.Text = (girdi1 + Convert.ToInt32(textgirdi2)).ToString();
            if (isaret == 2)
                textBox1.Text = (girdi1 - Convert.ToInt32(textgirdi2)).ToString();
            if (isaret == 3)
                textBox1.Text = (girdi1 * Convert.ToInt32(textgirdi2)).ToString();
            if (isaret == 4)
            {

               //by omar
                if (Convert.ToInt32(textgirdi2) == 0)
                    MessageBox.Show("Divided by zero error");
                else
                    textBox1.Text = (girdi1 / Convert.ToInt32(textgirdi2)).ToString();
               

            }

        }
        // Reset button
        private void button16_Click(object sender, EventArgs e)
        {
             textBox1.Text = "";
            textgirdi1 = "";
            textgirdi2 = "";
            girdi1 = 0;
            girdi2 = 0;
            isaret = 0;
            islem = 0;
        }
        // - button
        private void button12_Click(object sender, EventArgs e)
        {
            girdi1 = Convert.ToInt32(textBox1.Text);

            textBox1.Text = textBox1.Text + "-";
            islem = 1;
            isaret = 2;
        }
    }
}
