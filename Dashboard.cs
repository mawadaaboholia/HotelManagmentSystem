using ReaLTaiizor.Controls;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            maintenance1.Visible =false;
            uC_Gym1.Visible = false;
            uC_Dashboard1.Visible = true;
           
            uC_CustomerRegistraion1.Visible = false;
            uC_CustomerCheckOut1.Visible = false;
            customerDetails1.Visible = false;
            uC_Employee1.Visible = false;
            uC_Financials1.Visible = false;
           // btnAddRoom.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ActivateButton(object sender)
        {
            Color selectedColor = Color.White;
            Color defaultColor = Color.FromArgb(62, 120, 138);

            object target = sender;
            if (sender is PictureBox pb) target = pb.Parent;

            var myButtons = new[] { btnLogout, btnCustomerRegistration, btnCheckout, btnCustomerDetails, btnEmployee ,btnFinancials,btnGym,btnMaintenance,btnDashboard };
            

            for (int i = 0; i < myButtons.Length; i++)
            {
                if (myButtons[i] == target)
                {
                    myButtons[i].ColorBackground = selectedColor;
                    myButtons[i].ForeColor = defaultColor;
                    
                }
                else
                {
                    myButtons[i].ColorBackground = defaultColor;
                    myButtons[i].ForeColor = selectedColor;
                   
                }
                myButtons[i].Refresh();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            MovingPanel.Top = btnLogout.Top + 65;
            ActivateButton(sender);
        }

 
        private void btnCustomerRegistration_Click_1(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            MovingPanel.Top = btnCustomerRegistration.Top + 65;
            uC_CustomerRegistraion1.Visible= true;
            uC_CustomerRegistraion1.BringToFront();
            ActivateButton(sender);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
            MovingPanel.Top = btnCheckout.Top+65;
            ActivateButton(sender);
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();
            MovingPanel.Top = btnCustomerDetails.Top + 65;
            ActivateButton(sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_Employee1.Visible = true;
                uC_Employee1.BringToFront();
            MovingPanel.Top = btnEmployee.Top + 65;
            ActivateButton(sender);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_CustomerCheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void btnFinancials_Click(object sender, EventArgs e)
        {
            uC_Financials1.BringToFront();
            uC_Financials1.Visible = true;
            uC_Dashboard1.Visible = false;
            MovingPanel.Top = btnFinancials.Top + 65;
            ActivateButton(sender);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            maintenance1.Visible = true;
            maintenance1.BringToFront();    
            uC_Dashboard1.Visible = false;
            MovingPanel.Top = btnMaintenance.Top + 65;
            ActivateButton(sender);
        }

        private void btnGym_Click(object sender, EventArgs e)
        {
            uC_Gym1.Visible = true;
            uC_Gym1.BringToFront();
            uC_Dashboard1.Visible = false;
            MovingPanel.Top = btnGym.Top + 65;
            ActivateButton(sender);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible= true;
            uC_Dashboard1.BringToFront();
            MovingPanel.Top = btnDashboard.Top + 65;
            ActivateButton(sender);
        }
    }
}

