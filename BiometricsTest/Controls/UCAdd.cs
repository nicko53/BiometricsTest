using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BiometricsTest.Controls
{
    public partial class UCAdd : UserControl
    {
        //Database connection
        string connectionString = @"Server=localhost;Database=testdb;Uid=root;Pwd=ezra53";
        int idNumber;

        public UCAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //To add data on the Database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("user_infoAddorEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_IDNumber", idNumber);
                cmd.Parameters.AddWithValue("_first_name", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("_middle_name", txtMiddleName.Text.Trim());
                cmd.Parameters.AddWithValue("_last_name", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("_position", txtPosition.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Summitted Successfully");
                clear();
                GridFill();
            }
        }

        void GridFill()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("user_infoViewAll", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvUserInfo.DataSource = dt;
                dgvUserInfo.Columns[0].Visible = false;
            }
        }

        private void UCAdd_load(object sender, EventArgs e)
        {
            clear();
            GridFill();
        }

        void clear()
        {
            txtFirstName.Text = txtMiddleName.Text = txtLastName.Text = txtPosition.Text = txtSearch.Text = "";
            idNumber = 0;
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        //Update on the DATA once double clicked and the button changes from SAVE to UPDATE
        private void dgvUserInfo_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUserInfo.CurrentRow.Index != -1)
            {
                txtFirstName.Text = dgvUserInfo.CurrentRow.Cells[1].Value.ToString();
                txtMiddleName.Text = dgvUserInfo.CurrentRow.Cells[2].Value.ToString();
                txtLastName.Text = dgvUserInfo.CurrentRow.Cells[3].Value.ToString();
                txtPosition.Text = dgvUserInfo.CurrentRow.Cells[4].Value.ToString();
                idNumber = (int)Convert.ToUInt32(dgvUserInfo.CurrentRow.Cells[0].Value.ToString());
                btnSave.Text = "Update";
                btnDelete.Enabled = Enabled;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("user_infoSearchByValue", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvUserInfo.DataSource = dt;
                dgvUserInfo.Columns[0].Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("user_infoDeleteByID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_IDNumber", idNumber);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been deleted!");
                clear();
                GridFill();
            }
        }
    }
}
