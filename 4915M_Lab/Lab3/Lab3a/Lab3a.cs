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
    public partial class Lab3a : Form
    {
        public Lab3a()
        {
            InitializeComponent();
        }

        private void cboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCast_Click(object sender, EventArgs e)
        {

        }

        private void btnCast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You voted for: \n" + cboMovie.SelectedItem.ToString());
        }
    }
}
