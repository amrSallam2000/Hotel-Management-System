using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement1.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
     



        private void btnCoustomerregistration_Click_1(object sender, EventArgs e)
        {
            Movingpanel.Left = btnCoustomerregistration.Left + 25;
            uC_AddRoom1.Hide();
            uC_CustomerRegistriation1_Load(this,null);
            uC_CustomerRegistriation1.Visible = true;
            uC_CustomerRegistriation1.BringToFront();

        }

        private void btnCheckout_Click_1(object sender, EventArgs e)
        {
            Movingpanel.Left = btnCheckout.Left;

            uC_AddRoom1.Hide();
            uC_CustomerDetails1.Hide();
            uC_CustomerRegistriation1.Hide();
            
            uC_CoustomerCheckOut1.Visible = true;
            uC_CoustomerCheckOut1.BringToFront();
        }

        private void btnCustomerDetails_Click_1(object sender, EventArgs e)
        {
            Movingpanel.Left = btnCustomerDetails.Left;

            uC_AddRoom1.Hide();
            uC_CustomerRegistriation1.Hide();
            uC_CoustomerCheckOut1.Hide();

            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void btnEmployee_Click_1(object sender, EventArgs e)
        {

            uC_AddRoom1.Hide();
            uC_CustomerRegistriation1.Hide();
            uC_CoustomerCheckOut1.Hide();
            uC_CustomerDetails1.Hide();
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();

            Movingpanel.Left = btnEmployee.Left;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_CustomerDetails1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistriation1.Visible = false;
            btnAddroom.PerformClick();
        }

        private void btnAddroom_Click_1(object sender, EventArgs e)
        {
            
            Movingpanel.Left = btnAddroom.Left;


            uC_CoustomerCheckOut1.Hide();
            uC_CoustomerCheckOut1.Hide();
            uC_CustomerRegistriation1.Hide();
            
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        private void uC_CustomerRegistriation1_Load(object sender, EventArgs e)
        {

        }

        private void uC_CustomerRegistriation1_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_CustomerRegistriation1_Load_2(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }
}
