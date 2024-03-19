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
    public partial class ManagementProducts : Form
    {
        public ManagementProducts()
        {
            InitializeComponent();
            fillCategory();
            populate();
        }
        SQLiteConnection Con = new SQLiteConnection("Data Source=Inventory.db;Version=3;");
        void fillCategory()
        {
            String Query = "SELECT * FROM CategoryTbl";
            SQLiteCommand cmd = new SQLiteCommand(Query, Con);
            SQLiteDataReader rd;

            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CateName", typeof(string));

                rd = cmd.ExecuteReader();
                dt.Load(rd);

                CateCmb.DisplayMember = "CateName";
                CateCmb.DataSource = dt;

                SearchCmb.DisplayMember = "CateName";
                SearchCmb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM ProductTbl";
                SQLiteDataAdapter data = new SQLiteDataAdapter(MyQuery, Con);
                DataSet ds = new DataSet();
                data.Fill(ds, "ProductTbl");
                ProductsGV.DataSource = ds.Tables[0];

                ProductsGV.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
                ProductsGV.RowsDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                // Đặt tên hiển thị cho các cột
                ProductsGV.Columns["PId"].HeaderText = "ID";
                ProductsGV.Columns["PId"].Width = 50;
                ProductsGV.Columns["PName"].HeaderText = "Name";
                ProductsGV.Columns["PName"].Width = 150;
                ProductsGV.Columns["PQuantity"].HeaderText = "Quantity";
                ProductsGV.Columns["PPrice"].HeaderText = "Price";
                ProductsGV.Columns["PDes"].HeaderText = "Description";
                ProductsGV.Columns["PCate"].HeaderText = "Category";

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void filterByCategory()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM ProductTbl WHERE PCate=@Category";

                using (SQLiteCommand command = new SQLiteCommand(MyQuery, Con))
                {
                    command.Parameters.AddWithValue("@Category", SearchCmb.Text);

                    SQLiteDataAdapter data = new SQLiteDataAdapter(command);
                    DataSet ds = new DataSet();
                    data.Fill(ds, "ProductTbl");
                    ProductsGV.DataSource = ds.Tables[0];
                }

                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ClearTextBoxes()
        {
            txtPId.Text = string.Empty;
            txtPName.Text = string.Empty;
            txtPQuantity.Text = string.Empty;
            txtPPrice.Text = string.Empty;
            txtPDes.Text = string.Empty;
            CateCmb.Text = string.Empty;
        }
        private void DeleteProduct()
        {
            if (txtPId.Text == "")
            {
                MessageBox.Show("Enter the Product Id");
            }
            else
            {
                Con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM ProductTbl WHERE PId=@Id", Con))
                {
                    cmd.Parameters.AddWithValue("@Id", txtPId.Text);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Successfully deleted product.");
                Con.Close();
                populate();
            }
        }
        private void AddProduct()
        {
            Con.Open();

            // Kiểm tra xem ID đã tồn tại chưa
            using (SQLiteCommand checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM ProductTbl WHERE PId = @Id", Con))
            {
                checkCmd.Parameters.AddWithValue("@Id", txtPId.Text);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("ID already exists. Please choose a different ID.");
                    return; // Không thêm dữ liệu nếu ID đã tồn tại
                }
            }

            // Nếu ID không tồn tại, thực hiện thêm dữ liệu
            using (SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO ProductTbl VALUES(@Id, @Name, @Quantity, @Price, @Des, @Category)", Con))
            {
                insertCmd.Parameters.AddWithValue("@Id", txtPId.Text);
                insertCmd.Parameters.AddWithValue("@Name", txtPName.Text);
                insertCmd.Parameters.AddWithValue("@Quantity", txtPQuantity.Text);
                insertCmd.Parameters.AddWithValue("@Price", txtPPrice.Text);
                insertCmd.Parameters.AddWithValue("@Des", txtPDes.Text);
                insertCmd.Parameters.AddWithValue("@Category", CateCmb.Text);
                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Successfully added product.");
            Con.Close();
            populate();
        }
        private void UpdateProduct()
        {
            Con.Open();
            using (SQLiteCommand updateCmd = new SQLiteCommand("UPDATE ProductTbl SET PName=@Name, PQuantity=@Quantity, PPrice=@Price, PDes=@Des, PCate=@Category WHERE PId=@Id", Con))
            {
                updateCmd.Parameters.AddWithValue("@Id", txtPId.Text);
                updateCmd.Parameters.AddWithValue("@Name", txtPName.Text);
                updateCmd.Parameters.AddWithValue("@Quantity", txtPQuantity.Text);
                updateCmd.Parameters.AddWithValue("@Price", txtPPrice.Text);
                updateCmd.Parameters.AddWithValue("@Des", txtPDes.Text);
                updateCmd.Parameters.AddWithValue("@Category", CateCmb.Text);


                updateCmd.ExecuteNonQuery();
            }
            MessageBox.Show("Successfully updated product.");
            Con.Close();
            populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddProduct();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateProduct();
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
                DeleteProduct();
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsGV.Rows.Count)
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                txtPId.Text = row.Cells["PId"].Value?.ToString();
                txtPName.Text = row.Cells["PName"].Value?.ToString();
                txtPQuantity.Text = row.Cells["PQuantity"].Value?.ToString();
                txtPPrice.Text = row.Cells["PPrice"].Value?.ToString();
                txtPDes.Text = row.Cells["PDes"].Value?.ToString();
                CateCmb.Text = row.Cells["PCate"].Value?.ToString();
            }
        }

        private void ProductsGV_SelectionChanged(object sender, EventArgs e)
        {
            if (ProductsGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ProductsGV.SelectedRows[0];
                txtPId.Text = row.Cells["PId"].Value?.ToString();
                txtPName.Text = row.Cells["PName"].Value?.ToString();
                txtPQuantity.Text = row.Cells["PQuantity"].Value?.ToString();
                txtPPrice.Text = row.Cells["PPrice"].Value?.ToString();
                txtPDes.Text = row.Cells["PDes"].Value?.ToString();
                CateCmb.Text = row.Cells["PCate"].Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
