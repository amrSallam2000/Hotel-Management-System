using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement1.Classes;
namespace HotelManagement1.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                int num = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToset.Text = (num + 1).ToString();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           try
            {
                if (txtID.Text != "")
                {
                    if (MessageBox.Show("Are You Sure", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        query = "Delete From employee where eid=" + txtID.Text + "";
                        fn.setData(query, "Record Delete...");
                        TabControl_SelectedIndexChanged(this, null);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try 
            {
                if (txtName.Text != "" && txtMobile.Text != "" && txtEmail.Text != "" && txtGender.Text != "" && txtUserName.Text != "" && txtPassword.Text != "")
                {
                    string name = txtName.Text;
                    string mobile = txtMobile.Text;
                    string email = txtEmail.Text;
                    string gender = txtGender.Text;
                    string userName = txtUserName.Text;
                    string password = txtPassword.Text;
                    query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + userName + "','" + password + "') ";
                    fn.setData(query, "Employee Registered");
                    cleaAll();
                    getMaxID();
                }
                else
                {
                    MessageBox.Show("Fill All Fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        public void cleaAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtGender.SelectedIndex = -1;
            txtUserName.Clear();
            txtPassword.Clear();
            txtName.Focus();
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select *from EmployeeView";
            DataSet ds = fn.GetData(query);
            dgv.DataSource = ds.Tables[0];
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(TabControl.SelectedIndex==1)
            {
                setEmployee(GraidViewEmp);
            }
            else if(TabControl.SelectedIndex==2)
            {
                setEmployee(DeleteView);
            }
        }
        int id;
        private void DeleteView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DeleteView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(DeleteView.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtID.Text = id.ToString();
            }

        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            cleaAll();
        }
    }
}
