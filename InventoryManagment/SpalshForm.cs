using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment
{
    public partial class SpalshForm : Form
    {
        public SpalshForm()
        {
            InitializeComponent();
            timer1.Start();
            progressBar1.ForeColor = Color.Blue;
        }
        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            progressBar1.Value = start;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Form1 login = new Form1();
                this.Hide();
                login.Show();
            }
        }

        private void SpalshForm_Load(object sender, EventArgs e)
        {

        }
    }
}
