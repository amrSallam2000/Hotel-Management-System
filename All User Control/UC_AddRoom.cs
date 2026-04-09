using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement1
{
    public partial class UC_AddRoom : UserControl
    {
        Classes.function fn = new Classes.function();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNumber.Text != "" && txtRoomType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
                {
                    string roomno = txtRoomNumber.Text;
                    string Type = txtRoomType.Text;
                    string bed = txtBed.Text;
                    int price = int.Parse(txtPrice.Text);

                    query = "insert into rooms(roomNo,roomType,bed,price) values ('" + roomno + "','" + Type + "','" + bed + "'," + price + " )";
                    fn.setData(query, "Room Added.");


                    UC_AddRoom_Load(this, null);
                    clear_All();
                    txtRoomNumber.Focus();
                }
                else
                {
                    MessageBox.Show("Fill All Filds.", "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtRoomNumber.Focus();
                    txtRoomNumber.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRoomNumber.Focus();
                txtRoomNumber.SelectAll();
            }
        }
        public void clear_All()
        {
            txtRoomNumber.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
            txtRoomNumber.Focus();
        }


        private void Graidviw1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from ViewRoom";
            DataSet ds = fn.GetData(query);
            Graidviw1.DataSource = ds.Tables[0];
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clear_All();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
