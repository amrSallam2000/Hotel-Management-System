using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelManagement1.Classes;
namespace HotelManagement1.All_User_Control
{

    public partial class UC_CustomerRegistriation : UserControl
    {
        function fn = new function();
        String query;
    

        public UC_CustomerRegistriation()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void setComboBox(String query, ComboBox combo)
        {

            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for(int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();

        }

        private void textRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNO from rooms where bed = '" + txtBed.Text + "'and roomType='" + txtRoom.Text + "' and booked='NO'";
            setComboBox(query, txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo = '" + txtRoomNo.Text + "'";
            DataSet ds = fn.GetData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "" && txtContact.Text != "" && boxNationality.Text != "" && txtGender.Text != "" && txtDob.Text != "" && txtIdproof.Text != "" && txtAddress.Text != "" && txtCheckin.Text != "" && txtPrice.Text != "")
                {
                    String name = txtName.Text;
                    string mobile = txtContact.Text;
                    String national = boxNationality.Text;
                    String gender = txtGender.Text;
                    String dob = txtDob.Text;
                    String idproof = txtIdproof.Text;
                    String address = txtAddress.Text;
                    String chckin = txtCheckin.Text;
                    query = "insert into customer(cname,mobile,nationality,gender,dob,idproof,addres,checkin,roomid) values ('" + name + "'," + mobile + ",'" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + chckin + "'," + rid + ") update rooms set booked ='Yes' where roomNo= '" + txtRoomNo.Text + "'";
                    fn.setData(query, " Room No " + " [" + txtRoomNo.Text + "] " + "Allocation successful...");
                    clearAll();
                }
                else
                {
                    MessageBox.Show("All fields are madetory.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Focus();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
          
        }
        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtIdproof.Clear();
            txtAddress.Clear();
            txtPrice.Clear();
            
            txtDob.ResetText();
            txtCheckin.ResetText();

            txtBed.SelectedIndex=-1;
            txtRoom.SelectedIndex=-1;
            txtRoomNo.SelectedIndex=-1;
            txtGender.SelectedIndex = -1;
            boxNationality.SelectedIndex = -1;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_CustomerRegistriation_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
