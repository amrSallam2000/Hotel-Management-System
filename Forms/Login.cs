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
namespace HotelManagement1.Forms
{
    public partial class Login : Form
    {
        function fn = new function();
        string query;
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtusername.Focus();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           try
            {
                query = "select username,pass from employee where username='" + txtusername.Text + "'and pass='" + txtpassowrd.Text + "'";
                DataSet ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    Dashboard HomePage = new Dashboard();
                    this.Hide();
                    HomePage.Show();
                }
                else
                {
                    labelError.Visible = true;
                    txtpassowrd.Clear();
                    txtpassowrd.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
