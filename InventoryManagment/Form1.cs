using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace InventoryManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection Con = new SQLiteConnection("Data Source=Inventory.db;Version=3;");


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();

            // Sử dụng tham số để tránh SQL Injection
            string query = "SELECT COUNT(*) FROM UserTbl WHERE Uuser = @Username AND UPassword = @Password";

            using (SQLiteCommand cmd = new SQLiteCommand(query, Con))
            {
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }

            Con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}