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
    public partial class Lab3b : Form
    {
        public Lab3b()
        {
            InitializeComponent();
        }

        private void Lab3b_Load(object sender, EventArgs e)
        {

        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            double rate = (Convert.ToDouble(txtRate.Text) + 1);
            double total = amount;
            for(int i = 0; i < 10; i++)
            {
                total = total * rate;
            }
            total = amount * Math.Pow(1.05, 10);
            lblValue2.Text = total.ToString();

            total = amount;

            int years = 0;
            while (total < 1000000)
            {
                total *= rate;
                years++;
            }
            lblMillion2.Text = years.ToString();
        }

        private void lblValue_Click(object sender, EventArgs e)
        {

        }

        private void lblValue2_Click(object sender, EventArgs e)
        {

        }

        private void lblMillion_Click(object sender, EventArgs e)
        {

        }

        private void lblMillion2_Click(object sender, EventArgs e)
        {

        }
    }
}
