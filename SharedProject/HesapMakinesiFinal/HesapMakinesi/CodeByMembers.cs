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


        }
        // 2 button
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        // 3 button
        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        // 4 button
        private void button6_Click(object sender, EventArgs e)
        {
            
        }
        // 5 button
        private void button5_Click(object sender, EventArgs e)
        {
       
        }
        // 6 button
        private void button4_Click(object sender, EventArgs e)
        {
           
        }
        // 7 button
        private void button9_Click(object sender, EventArgs e)
        {
           
        }
        // 8 button
        private void button8_Click(object sender, EventArgs e)
        {
           
        }
        // 9 button
        private void button7_Click(object sender, EventArgs e)
        {
           
        }
        // 0 button
        private void button10_Click(object sender, EventArgs e)
        {
           
        }
        // * button
        private void button14_Click(object sender, EventArgs e)
        {


        }
        // / button
        private void button13_Click(object sender, EventArgs e)
        {
           
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
           
        }
    }
}
