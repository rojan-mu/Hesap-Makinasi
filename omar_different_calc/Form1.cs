using System;
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
        int gec1;
        int gec2;
        int sonuc;

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
        }
        // + button
        private void button11_Click(object sender, EventArgs e)
        {
            gec1 = Convert.ToInt32(textBox1.Text);
            gec2 = Convert.ToInt32(textBox2.Text);
            sonuc= gec1 + gec2;
        }
        // 2 button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
          

        }
        // 3 button
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
            
        }
        // 4 button
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
          
        }
        // 5 button
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
           
        }
        // 6 button
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
          
        }
        // 7 button
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
           
        }
        // 8 button
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
            
        }
        // 9 button
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
           
        }
        // 0 button
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            
        }
        // * button
        private void button14_Click(object sender, EventArgs e)
        {
            gec1 = Convert.ToInt32(textBox1.Text);
            gec2 = Convert.ToInt32(textBox2.Text);
            sonuc = gec1 * gec2;


        }
        // / button
        private void button13_Click(object sender, EventArgs e)
        {
            gec1 = Convert.ToInt32(textBox1.Text);
            gec2 = Convert.ToInt32(textBox2.Text);
            sonuc = gec1 / gec2;

            
        }
        // = button
        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Text = sonuc.ToString();
            
        }
        // Reset button
        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        // - button
        private void button12_Click(object sender, EventArgs e)
        {
            gec1 = Convert.ToInt32(textBox1.Text);
            gec2 = Convert.ToInt32(textBox2.Text);
            sonuc = gec1 - gec2;
        }
    }
}
