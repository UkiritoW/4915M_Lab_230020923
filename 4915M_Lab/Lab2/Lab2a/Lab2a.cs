using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M_Lab
{
    public partial class Lab2a : Form
    {
        private int price;
        private string payment;
        public Lab2a()
        {
            InitializeComponent();
        }

        private void Lab2a_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(textBox1.Text);
            int total = quantity * price;
            textBox2.Text = "Total: $" + total.ToString() + " Payment: " + payment;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
