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
    public partial class frmStudents : Form
    {

        public frmStudents()
        {
            InitializeComponent();
            this.lstStudents.DoubleClick += new System.EventHandler(this.lstStudent_DoubleClick);
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Alex Leung");

        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
                lblMessage.Text = $"The following item is selected: {lstStudents.SelectedItem.ToString()}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                lstStudents.Items.Add(txtName.Text);
                lblMessage.Text = $"The following item is added: {txtName.Text}";
                txtName.Clear();
            }
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {

        }

        private void lstStudent_DoubleClick(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                lblMessage.Text = $"The following item is deleted: {lstStudents.SelectedItem.ToString()}";
                lstStudents.Items.Remove(lstStudents.SelectedItem);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
