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
    public partial class ManagementOrders : Form
    {
        public ManagementOrders()
        {
            InitializeComponent();
            populate();
            populateProduct();
            fillCategory();
            InitializeTable();
        }
        int flag = 0;
        int num = 0;
        string product;
        int uprice, totprice, qty;
        int sum = 0;
        int stock;
        private DataTable table;
        SQLiteConnection Con = new SQLiteConnection("Data Source=Inventory.db;Version=3;");

        private void InitializeTable()
        {
            // Define columns for the DataTable
            table = new DataTable();
            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("TotalPrice", typeof(int));

            // Set the DataSource for the OrdersGV DataGridView
            OrdersGV.DataSource = table;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtQuantity.Text == "")
                MessageBox.Show("Enter the quantity of products");
            else if (flag == 0)
                MessageBox.Show("Select the product");
            else if (Convert.ToInt32(txtQuantity.Text) > stock)
                MessageBox.Show("No enough stock avalible");
            else
            {
                num++;
                qty = Convert.ToInt32(txtQuantity.Text);
                totprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrdersGV.DataSource = table;
                flag = 0;
            }
            sum += totprice;
            TotAmount.Text = "Rs" + sum.ToString();
            updateProduct();


        }

        void updateProduct()
        {
            Con.Open();

            // Check if there are any selected rows
            if (ProductsGV.SelectedRows.Count > 0)
            {
                int Id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells["PId"].Value.ToString());
                int newQty = stock - Convert.ToInt32(txtQuantity.Text);

                string Query = "UPDATE ProductTbl SET PQuantity = @newQty WHERE PId = @Id";

                using (SQLiteCommand cmd = new SQLiteCommand(Query, Con))
                {
                    cmd.Parameters.AddWithValue("@newQty", newQty);
                    cmd.Parameters.AddWithValue("@Id", Id);

                    cmd.ExecuteNonQuery();
                }
            }

            ProductsGV.Refresh();
            Con.Close();
        }


        private void populate()
        {

            Con.Open();
            string MyQuery = "SELECT * FROM CustomerTbl";
            SQLiteDataAdapter data = new SQLiteDataAdapter(MyQuery, Con);
            DataSet ds = new DataSet();
            data.Fill(ds, "CustomerTbl");
            CustomersGV.DataSource = ds.Tables[0];

            Con.Close();

        }
        private void populateProduct()
        {

            Con.Open();
            string MyQuery = "SELECT * FROM ProductTbl";
            SQLiteDataAdapter data = new SQLiteDataAdapter(MyQuery, Con);
            DataSet ds = new DataSet();
            data.Fill(ds, "ProductTbl");
            ProductsGV.DataSource = ds.Tables[0];

            Con.Close();

        }
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

                SearchCmb.DisplayMember = "CateName";
                SearchCmb.ValueMember = "CateName";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            object selectedValue = SearchCmb.SelectedValue;
            if (selectedValue != null)
            {
                try
                {

                    Con.Open();
                    string MyQuery = "SELECT * FROM ProductTbl WHERE PCate=@Category";

                    using (SQLiteCommand command = new SQLiteCommand(MyQuery, Con))
                    {
                        command.Parameters.AddWithValue("@Category", selectedValue.ToString());

                        SQLiteDataAdapter data = new SQLiteDataAdapter(command);
                        DataSet ds = new DataSet();
                        data.Fill(ds, "ProductTbl");
                        ProductsGV.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a valid category.");
            }
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ProductsGV.Rows.Count)
            {
                DataGridViewRow row = ProductsGV.Rows[e.RowIndex];
                product = row.Cells["PName"].Value?.ToString();
                // qty = Convert.ToInt32(txtQuantity.Text);
                stock = Convert.ToInt32(row.Cells["PQuantity"].Value?.ToString());
                uprice = Convert.ToInt32(row.Cells["PPrice"].Value?.ToString());
                //totprice = qty * uprice;
                flag = 1;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtOderId.Text == "" || txtCusId.Text == "" || txtCName.Text == "" || TotAmount.Text == "")
            {
                MessageBox.Show("Fill the data correctly");
            }
            else
            {
                AddProduct();
            }
        }
        private void AddProduct()
        {
            Con.Open();
            using (SQLiteCommand insertCmd = new SQLiteCommand("INSERT INTO OrderTbl VALUES(@OId, @CId, @CName, @Date, @Total)", Con))
            {
                insertCmd.Parameters.AddWithValue("@OId", txtOderId.Text);
                insertCmd.Parameters.AddWithValue("@CId", txtCusId.Text);
                insertCmd.Parameters.AddWithValue("@CName", txtCName.Text);
                insertCmd.Parameters.AddWithValue("@Date", orderDTP.Text);
                // Trích xuất giá trị số từ chuỗi TotAmount.Text
                string totalText = TotAmount.Text.Replace("Rs", "").Trim();
                // Chuyển đổi chuỗi thành giá trị số
                if (decimal.TryParse(totalText, out decimal totalValue))
                {
                    // Sử dụng giá trị số để thiết lập tham số @Total
                    insertCmd.Parameters.AddWithValue("@Total", totalValue);
                }
                insertCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Successfully added order.");
            Con.Close();
            populate();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < CustomersGV.Rows.Count)
            {
                DataGridViewRow row = CustomersGV.Rows[e.RowIndex];
                txtCusId.Text = row.Cells["CusId"].Value?.ToString();
                txtCName.Text = row.Cells["CusName"].Value?.ToString();
            }
        }

        private void CustomersGV_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomersGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = CustomersGV.SelectedRows[0];
                txtCusId.Text = row.Cells["CusId"].Value?.ToString();
                txtCName.Text = row.Cells["CusName"].Value?.ToString();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void TotAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
