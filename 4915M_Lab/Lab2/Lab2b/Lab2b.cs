using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _4915M_Lab
{
    public partial class Lab2b : Form
    {
        public Lab2b()
        {
            InitializeComponent();
        }

        private void Lab2b_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSuny.Visible = true;
            lblMessage.Text = "It’s going to be a cloudy day today, " + txtName.Text + ".";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = true;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSuny.Visible = false;
            lblMessage.Text = "It’s going to be a cloudy day today, " +txtName.Text + ".";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = true;
            picSnowy.Visible = false;
            picSuny.Visible = false;
            lblMessage.Text = "It’s going to be a cloudy day today, " + txtName.Text + ".";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = true;
            picSuny.Visible = false;
            lblMessage.Text = "It’s going to be a cloudy day today, " + txtName.Text + ".";
        }
    }
}
