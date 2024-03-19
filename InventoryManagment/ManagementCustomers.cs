
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment
{
    public partial class ManagementCustomers : Form
    {
        public ManagementCustomers()
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
                string MyQuery = "SELECT * FROM CustomerTbl";
                SQLiteDataAdapter data = new SQLiteDataAdapter(MyQuery, Con);
                DataSet ds = new DataSet();
                data.Fill(ds, "CustomerTbl");
                CustomersGV.DataSource = ds.Tables[0];

                CustomersGV.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                CustomersGV.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                // Đặt tên hiển thị cho các cột
                CustomersGV.Columns["CusId"].HeaderText = "Customer ID";
                CustomersGV.Columns["CusName"].HeaderText = "Customer Name";
                CustomersGV.Columns["CusPhone"].HeaderText = "Customer Phone";
                CustomersGV.Columns["CusId"].Width = 150;
                CustomersGV.Columns["CusName"].Width = 160;
                CustomersGV.Columns[CustomersGV.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            txtCId.Text = string.Empty;
            txtCName.Text = string.Empty;
            txtCPhone.Text = string.Empty;
        }
        private void DeleteCustomer()
        {
            if (txtCId.Text == "")
            {
                MessageBox.Show("Enter the Customer Id");
            }
            else
            {
                Con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM CustomerTbl WHERE CusId=@Id", Con))
                {
                    cmd.Parameters.AddWithValue("@Id", txtCId.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Successfully deleted customer.");
                Con.Close();
                populate();
            }
        }
        private void AddCustomer()
        {
            Con.Open();

            // Kiểm tra xem ID đã tồn tại chưa
            using (SQLiteCommand checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM CustomerTbl WHERE CusId = @Id", Con))
            {
                checkCmd.Parameters.AddWithValue("@Id", txtCId.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("ID already exists. Please choose a different ID.");
                    return; // Không thêm dữ liệu nếu ID đã tồn tại
                }
            }

            // Nếu ID không tồn tại, thực hiện thêm dữ liệu
            using (SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO CustomerTbl VALUES(@CusId, @CusName, @CusPhone)", Con))
            {
                insertCmd.Parameters.AddWithValue("@CusId", txtCId.Text);
                insertCmd.Parameters.AddWithValue("@CusName", txtCName.Text);
                insertCmd.Parameters.AddWithValue("@CusPhone", txtCPhone.Text);

                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Successfully added customer.");
            Con.Close();
            populate();
        }
        private void UpdateCustomer()
        {
            Con.Open();
            using (SQLiteCommand updateCmd = new SQLiteCommand("UPDATE CustomerTbl SET CusName=@CusName, CusPhone=@CusPhone WHERE CusId=@CusId", Con))
            {
                updateCmd.Parameters.AddWithValue("@CusId", txtCId.Text);
                updateCmd.Parameters.AddWithValue("@CusName", txtCName.Text);
                updateCmd.Parameters.AddWithValue("@CusPhone", txtCPhone.Text);

                updateCmd.ExecuteNonQuery();
            }
            MessageBox.Show("Successfully updated customer.");
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
                AddCustomer();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateCustomer();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteCustomer();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersGV.Rows.Count)
            {
                DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
                txtCId.Text = row.Cells["CusId"].Value?.ToString();
                txtCName.Text = row.Cells["CusName"].Value?.ToString();
                txtCPhone.Text = row.Cells["CusPhone"].Value?.ToString();

                Con.Open();

                // Sử dụng tham số để tránh SQL Injection
                string query = "SELECT COUNT(*) FROM OrderTbl WHERE CusId = @CusId";
                using (SQLiteCommand cmd = new SQLiteCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@CusId", txtCId.Text);

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        OrderLabel.Text = dt.Rows[0][0].ToString();
                    }
                }

                string querySum = "SELECT SUM(TotalAmt) FROM OrderTbl WHERE CusId = @CusId";
                using (SQLiteCommand cmd = new SQLiteCommand(querySum, Con))
                {
                    cmd.Parameters.AddWithValue("@CusId", txtCId.Text);

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        AmountLabel.Text = dt.Rows[0][0].ToString();
                    }
                }

                string queryDate = "SELECT Max(OrderDate) FROM OrderTbl WHERE CusId = @CusId";
                using (SQLiteCommand cmd = new SQLiteCommand(queryDate, Con))
                {
                    cmd.Parameters.AddWithValue("@CusId", txtCId.Text);

                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DateLabel.Text = dt.Rows[0][0].ToString();
                    }
                }

                Con.Close();
            }
        }
        private void CustomersGV_SelectionChanged_1(object sender, EventArgs e)
        {
            if (CustomersGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = CustomersGV.SelectedRows[0];
                txtCId.Text = row.Cells["CusId"].Value?.ToString();
                txtCName.Text = row.Cells["CusName"].Value?.ToString();
                txtCPhone.Text = row.Cells["CusPhone"].Value?.ToString();
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
