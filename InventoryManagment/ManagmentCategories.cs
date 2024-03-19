using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment
{
    public partial class ManagmentCategories : Form
    {
        public ManagmentCategories()
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
                string MyQuery = "SELECT * FROM CategoryTbl";
                SQLiteDataAdapter data = new SQLiteDataAdapter(MyQuery, Con);
                DataSet ds = new DataSet();
                data.Fill(ds, "CategoryTbl");
                CategoriesGV.DataSource = ds.Tables[0];

                // Đặt tên hiển thị cho các cột
                CategoriesGV.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                CategoriesGV.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                CategoriesGV.Columns["CateId"].HeaderText = "Category ID";
                CategoriesGV.Columns["CateId"].Width = 200;
                CategoriesGV.Columns["CateName"].HeaderText = "Category Name";
                CategoriesGV.Columns[CategoriesGV.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            txtCateId.Text = string.Empty;
            txtCateName.Text = string.Empty;
        }
        private void DeleteCategory()
        {
            if (txtCateId.Text == "")
            {
                MessageBox.Show("Enter the Category Id");
            }
            else
            {
                Con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM CategoryTbl WHERE CateId=@Id", Con))
                {
                    cmd.Parameters.AddWithValue("@Id", txtCateId.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Successfully deleted category.");
                Con.Close();
                populate();
            }
        }
        private void AddCategory()
        {
            Con.Open();

            // Kiểm tra xem ID đã tồn tại chưa
            using (SQLiteCommand checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM CategoryTbl WHERE CateId = @Id", Con))
            {
                checkCmd.Parameters.AddWithValue("@Id", txtCateId.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("ID already exists. Please choose a different ID.");
                    return; // Không thêm dữ liệu nếu ID đã tồn tại
                }
            }

            // Nếu ID không tồn tại, thực hiện thêm dữ liệu
            using (SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO CategoryTbl VALUES(@CateId, @CateName)", Con))
            {
                insertCmd.Parameters.AddWithValue("@CateId", txtCateId.Text);
                insertCmd.Parameters.AddWithValue("@CateName", txtCateName.Text);

                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Successfully added Category.");
            Con.Close();
            populate();
        }
        private void UpdateCategory()
        {
            Con.Open();
            using (SQLiteCommand updateCmd = new SQLiteCommand("UPDATE CategoryTbl SET CateName=@CateName WHERE CateId=@Id", Con))
            {
                updateCmd.Parameters.AddWithValue("@Id", txtCateId.Text);
                updateCmd.Parameters.AddWithValue("@CateName", txtCateName.Text);

                updateCmd.ExecuteNonQuery();
            }
            MessageBox.Show("Successfully updated category.");
            Con.Close();
            populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddCategory();
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
                UpdateCategory();
                ClearTextBoxes();
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
                DeleteCategory();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CategoriesGV.Rows.Count)
            {
                DataGridViewRow row = CategoriesGV.Rows[e.RowIndex];
                txtCateId.Text = row.Cells["CateId"].Value?.ToString();
                txtCateName.Text = row.Cells["CateName"].Value?.ToString();
            }

        }

        private void CategoriesGV_SelectionChanged(object sender, EventArgs e)
        {
            if (CategoriesGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = CategoriesGV.SelectedRows[0];
                txtCateId.Text = row.Cells["CateId"].Value?.ToString();
                txtCateName.Text = row.Cells["CateName"].Value?.ToString();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
