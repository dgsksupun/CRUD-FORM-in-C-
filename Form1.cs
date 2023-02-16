using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Form1 : Form
    {
        int teaval = 1, coffeval = 1, milkval = 1;
        int teaprice =0,milkprice = 0, coffeprice = 0;
        int price = 0, totprice = 0, discount = 0,discprice=0;
        
        
        public Form1()
        {
            
            InitializeComponent();
            textBox1.Text = Convert.ToString(teaval);
            textBox2.Text = Convert.ToString(milkval);
            textBox3.Text = Convert.ToString(coffeval);
            textBox4.Text = Convert.ToString(discount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teaval = teaval + 1;
            textBox1.Text = Convert.ToString(teaval);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            milkval = milkval + 1;
            textBox2.Text = Convert.ToString(milkval);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coffeval = coffeval + 1;
            textBox3.Text = Convert.ToString(coffeval);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (teaval > 0)
            {
                teaval = teaval - 1;
                textBox1.Text = Convert.ToString(teaval);
            }
            else 
            {
                MessageBox.Show("Please Enter Correct Value");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (milkval > 0)
            {
                milkval = milkval - 1;
                textBox2.Text = Convert.ToString(milkval);
            }
            else
            {
                MessageBox.Show("Please Enter Correct Value");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            teaprice = teaval * 50;
            milkprice = milkval * 150;
            coffeprice = coffeval * 100;
            price = teaprice + milkprice + coffeprice;
            
            discount = Convert.ToInt32(textBox4.Text);
            if (discount >= 0 && discount<=100) 
            {
                discprice = (price * discount) / 100;
            }
            else 
            {
                MessageBox.Show("The discount is in out of range");
            }
           
            totprice = price - discprice;

            textBox5.Text = Convert.ToString(discprice) + " Rs";
            textBox6.Text = Convert.ToString(totprice) + " Rs";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (coffeval > 0)
            {
                coffeval = coffeval - 1;
                textBox3.Text = Convert.ToString(coffeval);
            }
            else
            {
                MessageBox.Show("Please Enter Correct Value");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
