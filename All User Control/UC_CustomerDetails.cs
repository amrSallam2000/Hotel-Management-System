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
    public partial class UC_CustomerDetails : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchBy.SelectedIndex == 0)
                {
                    query = "select *from CustomerDetails";
                    getRecord(query);
                }
                else if (txtSearchBy.SelectedIndex == 1)
                {
                    query = "select *from CustomerInHotel";
                    getRecord(query);
                }
                else if (txtSearchBy.SelectedIndex == 2)
                {
                    query = "select *from CustomerCheckOut";
                    getRecord(query);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
        public void getRecord(string query)
        {
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UC_CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
