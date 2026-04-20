using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagmentSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {


            cmbUsername.Items.Add("Mawada");
            cmbUsername.Items.Add("Rayan");
            cmbUsername.Items.Add("Amna");

            txtPassword.Text = "";
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtPassword.Text = "";
            txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (cmbUsername.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Please Choose a User!");
            //    cmbUsername.Focus();
            //    txtPassword.Text = "";
            //    return;
            //}
            //if (txtPassword.Text == "")
            //{
            //    MessageBox.Show("Please enter Password!");
            //    txtPassword.Focus();
            //    return;
            //}
            //if (cmbUsername.SelectedIndex == 0)
            //{
            //    if (txtPassword.Text != "111")
            //    {
            //        MessageBox.Show("Wrong password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtPassword.Focus();
            //        txtPassword.Text = "";
            //        return;
            //    }
            //}
            //if (cmbUsername.SelectedIndex == 1)
            //{
            //    if (txtPassword.Text != "222")
            //    {
            //        MessageBox.Show("Wrong password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtPassword.Focus();
            //        txtPassword.Text = "";
            //        return;
            //    }
            //}
            //if (cmbUsername.SelectedIndex == 2)
            //{
            //    if (txtPassword.Text != "333")
            //    {
            //        MessageBox.Show("Wrong password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtPassword.Focus();
            //        txtPassword.Text = "";
            //        return;
            //    }
            //}




            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
