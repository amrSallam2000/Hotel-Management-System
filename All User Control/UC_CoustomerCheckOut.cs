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
    public partial class UC_CoustomerCheckOut : UserControl
    {
        function fn = new function();
        string query;
        public UC_CoustomerCheckOut()
        {
            InitializeComponent();
        }

        private void UC_CoustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select *from CustomerView";
            DataSet ds=fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcname.Text != "")
                {
                    if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        string cdate = txtCheckOutDate.Text;
                        query = "Update customer set chekout ='Yes',checkout='" + cdate + "' where cid=" + id + "update rooms set booked ='NO' where roomNo='" + txtRoomNo.Text + "'";
                        fn.setData(query, "Check Out Successfully...");
                        UC_CoustomerCheckOut_Load(this, null);
                        clearAll();
                        txtName.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("No Coustomer Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Eroor",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();

            }

        }
        public void clearAll()
        {
            txtRoomNo.Clear();
            txtName.Clear();
            txtcname.Clear();
            txtCheckOutDate.ResetText();
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid,customer.cname,customer.mobile,customer.nationality,customer.gender,customer.dob,customer.idProof,customer.addres,customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from customer inner join rooms on customer.roomid=rooms.roomid where cname like '"+txtName.Text+"%' and chekout='NO'";
            DataSet ds=fn.GetData(query);
            guna2DataGridView1.DataSource=ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtcname.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoomNo.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            }
        }

        private void btnCheckOut_Leave(object sender, EventArgs e)
        {

        }

        private void UC_CoustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_CoustomerCheckOut_Enter(object sender, EventArgs e)
        {
            UC_CoustomerCheckOut_Load(this, null);
        }
    }
}
