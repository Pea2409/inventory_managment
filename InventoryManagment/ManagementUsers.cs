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
using System.Data.SQLite;

namespace InventoryManagment
{
    public partial class ManagementUsers : Form
    {
        public ManagementUsers()
        {
            InitializeComponent();
            populate();
        }
        SQLiteConnection Con = new SQLiteConnection("Data Source=Inventory.db;Version=3;");
        private void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM UserTbl";
                SQLiteDataAdapter data = new SQLiteDataAdapter(MyQuery, Con);
                DataSet ds = new DataSet();
                data.Fill(ds, "UserTbl");
                UsersGV.DataSource = ds.Tables[0];

                // Đặt tên hiển thị cho các cột
                UsersGV.Columns["Id"].HeaderText = "User ID";
                UsersGV.Columns["Uuser"].HeaderText = "Username";
                UsersGV.Columns["UFullName"].HeaderText = "Full Name";
                UsersGV.Columns["UPassword"].HeaderText = "Password";
                UsersGV.Columns["UPhone"].HeaderText = "Phone";


                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void DeleteUser()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Enter the User Id");
            }
            else
            {
                Con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM UserTbl WHERE Id=@Id", Con))
                {
                    cmd.Parameters.AddWithValue("@Id", txtID.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Successfully deleted user.");
                Con.Close();
                populate();
            }
        }
        private void AddUser()
        {
            Con.Open();

            // Kiểm tra xem ID đã tồn tại chưa
            using (SQLiteCommand checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM UserTbl WHERE Id = @Id", Con))
            {
                checkCmd.Parameters.AddWithValue("@Id", txtID.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("ID already exists. Please choose a different ID.");
                    return; // Không thêm dữ liệu nếu ID đã tồn tại
                }
            }

            // Nếu ID không tồn tại, thực hiện thêm dữ liệu
            using (SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO UserTbl VALUES(@Id, @Uuser, @UFullName, @UPassword, @UPhone)", Con))
            {
                insertCmd.Parameters.AddWithValue("@Id", txtID.Text);
                insertCmd.Parameters.AddWithValue("@Uuser", txtUuser.Text);
                insertCmd.Parameters.AddWithValue("@UFullName", txtUFullName.Text);
                insertCmd.Parameters.AddWithValue("@UPassword", txtUPassword.Text);
                insertCmd.Parameters.AddWithValue("@UPhone", txtUPhone.Text);

                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Successfully added user.");
            Con.Close();
            populate();
        }
        private void updateUser()
        {
            Con.Open();
            using (SQLiteCommand updateCmd = new SQLiteCommand("UPDATE UserTbl SET Uuser=@Uuser, UFullName=@UFullName, UPassword=@UPassword, UPhone=@UPhone WHERE Id=@Id", Con))
            {
                updateCmd.Parameters.AddWithValue("@Id", txtID.Text);
                updateCmd.Parameters.AddWithValue("@Uuser", txtUuser.Text);
                updateCmd.Parameters.AddWithValue("@UFullName", txtUFullName.Text);
                updateCmd.Parameters.AddWithValue("@UPassword", txtUPassword.Text);
                updateCmd.Parameters.AddWithValue("@UPhone", txtUPhone.Text);

                updateCmd.ExecuteNonQuery();
            }
            MessageBox.Show("Successfully updated user.");
            Con.Close();
            populate();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < UsersGV.Rows.Count)
            {
                DataGridViewRow row = UsersGV.Rows[e.RowIndex];
                txtID.Text = row.Cells["Id"].Value?.ToString();
                txtUuser.Text = row.Cells["Uuser"].Value?.ToString();
                txtUFullName.Text = row.Cells["UFullName"].Value?.ToString();
                txtUPassword.Text = row.Cells["UPassword"].Value?.ToString();
                txtUPhone.Text = row.Cells["UPhone"].Value?.ToString();
            }
        }

        private void UsersGV_SelectionChanged(object sender, EventArgs e)
        {
            if (UsersGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = UsersGV.SelectedRows[0];
                txtID.Text = (row.Cells["Id"].Value != DBNull.Value) ? row.Cells["Id"].Value.ToString() : string.Empty;
                txtUuser.Text = row.Cells["Uuser"].Value?.ToString();
                txtUFullName.Text = row.Cells["UFullName"].Value?.ToString();
                txtUPassword.Text = row.Cells["UPassword"].Value?.ToString();
                txtUPhone.Text = (row.Cells["UPhone"].Value != DBNull.Value) ? row.Cells["UPhone"].Value.ToString() : string.Empty;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                updateUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
