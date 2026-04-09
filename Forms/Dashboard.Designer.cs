namespace HotelManagement1.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Movingpanel = new System.Windows.Forms.Panel();
            this.btnCoustomerregistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddroom = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Employee1 = new HotelManagement1.All_User_Control.UC_Employee();
            this.uC_AddRoom1 = new HotelManagement1.UC_AddRoom();
            this.uC_CustomerDetails1 = new HotelManagement1.All_User_Control.UC_CustomerDetails();
            this.uC_CoustomerCheckOut1 = new HotelManagement1.All_User_Control.UC_CoustomerCheckOut();
            this.uC_CustomerRegistriation1 = new HotelManagement1.All_User_Control.UC_CustomerRegistriation();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnNormalSize = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnMini = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Movingpanel);
            this.panel1.Controls.Add(this.btnCoustomerregistration);
            this.panel1.Controls.Add(this.btnAddroom);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Location = new System.Drawing.Point(39, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 141);
            this.panel1.TabIndex = 1;
            // 
            // Movingpanel
            // 
            this.Movingpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Movingpanel.Location = new System.Drawing.Point(3, 111);
            this.Movingpanel.Name = "Movingpanel";
            this.Movingpanel.Size = new System.Drawing.Size(215, 5);
            this.Movingpanel.TabIndex = 0;
            // 
            // btnCoustomerregistration
            // 
            this.btnCoustomerregistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCoustomerregistration.BorderRadius = 26;
            this.btnCoustomerregistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCoustomerregistration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCoustomerregistration.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCoustomerregistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCoustomerregistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCoustomerregistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCoustomerregistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCoustomerregistration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCoustomerregistration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCoustomerregistration.ForeColor = System.Drawing.Color.White;
            this.btnCoustomerregistration.Image = global::HotelManagement1.Properties.Resources.customer_registration;
            this.btnCoustomerregistration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCoustomerregistration.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCoustomerregistration.Location = new System.Drawing.Point(224, 20);
            this.btnCoustomerregistration.Name = "btnCoustomerregistration";
            this.btnCoustomerregistration.Size = new System.Drawing.Size(289, 85);
            this.btnCoustomerregistration.TabIndex = 3;
            this.btnCoustomerregistration.Text = "Customer Registration";
            this.btnCoustomerregistration.Click += new System.EventHandler(this.btnCoustomerregistration_Click_1);
            // 
            // btnAddroom
            // 
            this.btnAddroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAddroom.BorderRadius = 26;
            this.btnAddroom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddroom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddroom.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAddroom.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddroom.ForeColor = System.Drawing.Color.White;
            this.btnAddroom.Image = global::HotelManagement1.Properties.Resources.add_room;
            this.btnAddroom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddroom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddroom.Location = new System.Drawing.Point(3, 20);
            this.btnAddroom.Name = "btnAddroom";
            this.btnAddroom.Size = new System.Drawing.Size(215, 85);
            this.btnAddroom.TabIndex = 8;
            this.btnAddroom.Text = "Add Room";
            this.btnAddroom.Click += new System.EventHandler(this.btnAddroom_Click_1);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::HotelManagement1.Properties.Resources.Employee;
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageSize = new System.Drawing.Size(50, 50);
            this.btnEmployee.Location = new System.Drawing.Point(1013, 20);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(215, 85);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click_1);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustomerDetails.BorderRadius = 26;
            this.btnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetails.Image = global::HotelManagement1.Properties.Resources.customer_Details;
            this.btnCustomerDetails.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerDetails.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerDetails.Location = new System.Drawing.Point(761, 20);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(234, 85);
            this.btnCustomerDetails.TabIndex = 6;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click_1);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCheckout.BorderRadius = 26;
            this.btnCheckout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckout.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckout.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Image = global::HotelManagement1.Properties.Resources.check_out;
            this.btnCheckout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckout.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCheckout.Location = new System.Drawing.Point(531, 20);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(215, 85);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Controls.Add(this.uC_CustomerDetails1);
            this.panel2.Controls.Add(this.uC_CoustomerCheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRegistriation1);
            this.panel2.Location = new System.Drawing.Point(3, 167);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1295, 713);
            this.panel2.TabIndex = 1;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Location = new System.Drawing.Point(3, 3);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1295, 713);
            this.uC_Employee1.TabIndex = 4;
            this.uC_Employee1.Visible = false;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 3);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.Size = new System.Drawing.Size(1295, 713);
            this.uC_AddRoom1.TabIndex = 3;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetails1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_CustomerDetails1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(0, -3);
            this.uC_CustomerDetails1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1295, 713);
            this.uC_CustomerDetails1.TabIndex = 2;
            this.uC_CustomerDetails1.Visible = false;
            // 
            // uC_CoustomerCheckOut1
            // 
            this.uC_CoustomerCheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CoustomerCheckOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_CoustomerCheckOut1.Location = new System.Drawing.Point(0, -3);
            this.uC_CoustomerCheckOut1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uC_CoustomerCheckOut1.Name = "uC_CoustomerCheckOut1";
            this.uC_CoustomerCheckOut1.Size = new System.Drawing.Size(1295, 713);
            this.uC_CoustomerCheckOut1.TabIndex = 1;
            this.uC_CoustomerCheckOut1.Visible = false;
            // 
            // uC_CustomerRegistriation1
            // 
            this.uC_CustomerRegistriation1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegistriation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_CustomerRegistriation1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uC_CustomerRegistriation1.Location = new System.Drawing.Point(0, 6);
            this.uC_CustomerRegistriation1.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.uC_CustomerRegistriation1.Name = "uC_CustomerRegistriation1";
            this.uC_CustomerRegistriation1.Size = new System.Drawing.Size(1295, 814);
            this.uC_CustomerRegistriation1.TabIndex = 0;
            this.uC_CustomerRegistriation1.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // btnNormalSize
            // 
            this.btnNormalSize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNormalSize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNormalSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNormalSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNormalSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnNormalSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNormalSize.ForeColor = System.Drawing.Color.White;
            this.btnNormalSize.Image = global::HotelManagement1.Properties.Resources.pict__restore_window_button_hover_window_elements_vector_stencils_library;
            this.btnNormalSize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNormalSize.Location = new System.Drawing.Point(3, 76);
            this.btnNormalSize.Name = "btnNormalSize";
            this.btnNormalSize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnNormalSize.Size = new System.Drawing.Size(30, 30);
            this.btnNormalSize.TabIndex = 5;
            this.btnNormalSize.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnMini
            // 
            this.btnMini.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMini.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMini.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMini.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMini.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnMini.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMini.ForeColor = System.Drawing.Color.White;
            this.btnMini.Image = global::HotelManagement1.Properties.Resources.minimize_window_25pxdf;
            this.btnMini.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMini.Location = new System.Drawing.Point(3, 40);
            this.btnMini.Name = "btnMini";
            this.btnMini.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMini.Size = new System.Drawing.Size(30, 30);
            this.btnMini.TabIndex = 4;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1300, 883);
            this.Controls.Add(this.btnNormalSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Movingpanel;
        private Guna.UI2.WinForms.Guna2Button btnCoustomerregistration;
        private Guna.UI2.WinForms.Guna2Button btnAddroom;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2CircleButton btnMini;
        private Guna.UI2.WinForms.Guna2CircleButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton btnNormalSize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private UC_AddRoom uC_AddRoom1;
        private All_User_Control.UC_CustomerDetails uC_CustomerDetails1;
        private All_User_Control.UC_CoustomerCheckOut uC_CoustomerCheckOut1;
        private All_User_Control.UC_CustomerRegistriation uC_CustomerRegistriation1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private All_User_Control.UC_Employee uC_Employee1;
    }
}