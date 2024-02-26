using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4915M_Lab
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab1 Lab1 = new Lab1();
            Lab1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab2a lab2a = new Lab2a();
            lab2a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab2b lab2b = new Lab2b();
            lab2b.ShowDialog();
        }
    }
}
