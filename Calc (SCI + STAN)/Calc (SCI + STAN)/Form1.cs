using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        standard obj = new standard();
        double num = 0;
        int opt;
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opt = 1;
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opt = 2;
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opt = 3;
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opt = 4;
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        scien ooo = new scien();
        private void button7_Click_1(object sender, EventArgs e)
        {
            opt = 5;
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            opt = 6;
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            opt = 7;
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            opt = 8;
            num = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }
             

        private void button5_Click(object sender, EventArgs e)
        {
           
            switch (opt)
            {
                case 1:
                    double num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(obj.Add(num,num1));
                    break;
                case 2:
                    double num2 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(obj.Sub(num,num2));
                    break;
                case 3:
                    double num3 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(obj.Divide(num,num3));
                    break;
                case 4:
                    double num4 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(obj.Multi(num,num4));
                    break;
                case 5:
                    textBox1.Text = Convert.ToString(ooo.pi());
                    break;
                case 6:
                    double num6 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(ooo.po(num, num6));
                    break;
                case 7:
                    double num7 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(ooo.cos(num7));
                    break;
                case 8:
                    double num8 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(ooo.sin(num8));
                    break;
            }
        }

        
        
    }
}
