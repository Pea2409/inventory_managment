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
using static System.Windows.Forms.LinkLabel;

namespace InventoryManagment
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
            populateOrders();
        }
        SQLiteConnection Con = new SQLiteConnection("Data Source=Inventory.db;Version=3;");
        private void populateOrders()
        {

            Con.Open();
            string MyQuery = "SELECT * FROM OrderTbl";
            SQLiteDataAdapter data = new SQLiteDataAdapter(MyQuery, Con);
            DataSet ds = new DataSet();
            data.Fill(ds, "ProductTbl");
            OrdersGV.DataSource = ds.Tables[0];

            Con.Close();

        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Sử dụng e.Graphics để vẽ
            Graphics g = e.Graphics;
            string textToDraw = "Order Summary";
            Font titleFont = new Font("Century", 25, FontStyle.Bold);
            Brush titleBrush = Brushes.Red;
            g.DrawString(textToDraw, titleFont, titleBrush, new Point(230, 10));

            // Kiểm tra xem có dòng nào đang được chọn
            if (OrdersGV.CurrentRow != null)
            {
                // Lấy giá trị của cột "CusId" từ dòng hiện tại
                string cusId = OrdersGV.CurrentRow.Cells["CusId"].Value.ToString();
                string OrderId = OrdersGV.CurrentRow.Cells["OrderId"].Value.ToString();
                string CusName = OrdersGV.CurrentRow.Cells["CusName"].Value.ToString();
                string OrderDate = OrdersGV.CurrentRow.Cells["OrderDate"].Value.ToString();
                string Total = OrdersGV.CurrentRow.Cells["TotalAmt"].Value.ToString();

                // Vẽ dòng chứa giá trị của cột "CusId"
                Font normalFont = new Font("Regular ", 30); // Font văn bản thông thường
                Brush normalBrush = Brushes.Black; // Màu chữ đen
                g.DrawString($"Customer Id: {cusId}", normalFont, normalBrush, new Point(80, 100));
                g.DrawString($"Order Id: {OrderId}", normalFont, normalBrush, new Point(80, 150));
                g.DrawString($"Customer Name: {CusName}", normalFont, normalBrush, new Point(80, 200));
                g.DrawString($"Order Date: {OrderDate}", normalFont, normalBrush, new Point(80, 250));
                g.DrawString($"Total: {Total}", normalFont, normalBrush, new Point(80, 300));
            }
            else
            {
                // Xử lý khi không có hàng nào được chọn
                g.DrawString("No row selected", titleFont, titleBrush, new Point(10, 50));
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
