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
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistraion1.Visible = false;
            uC_CustomerCheckOut1.Visible = false;
            customerDetails1.Visible = false;
            uC_Employee1.Visible = false;
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

            var myButtons = new[] { btnAddRoom, btnCustomerRegistration, btnCheckout, btnCustomerDetails, btnEmployee };
            

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

        private void btnAddRoom_Click(object sender, EventArgs e)
        {   uC_AddRoom1.Visible= true;
            uC_AddRoom1.BringToFront();
            MovingPanel.Top = btnAddRoom.Top + 45;
            ActivateButton(sender);
        }

 
        private void btnCustomerRegistration_Click_1(object sender, EventArgs e)
        {

            MovingPanel.Top = btnCustomerRegistration.Top + 45;
            uC_CustomerRegistraion1.Visible= true;
            uC_CustomerRegistraion1.BringToFront();
            ActivateButton(sender);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
            MovingPanel.Top = btnCheckout.Top+45;
            ActivateButton(sender);
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();
            MovingPanel.Top = btnCustomerDetails.Top + 45;
            ActivateButton(sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

            uC_Employee1.Visible = true;
                uC_Employee1.BringToFront();
            MovingPanel.Top = btnEmployee.Top + 45;
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
    }
}

