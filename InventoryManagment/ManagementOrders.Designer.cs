using System.Data;

namespace InventoryManagment
{
    partial class ManagementOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementOrders));
            txtCName = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            txtQuantity = new TextBox();
            panel2 = new Panel();
            SearchCmb = new ComboBox();
            ProductsGV = new DataGridView();
            label4 = new Label();
            orderDTP = new DateTimePicker();
            txtCusId = new TextBox();
            label3 = new Label();
            txtOderId = new TextBox();
            label7 = new Label();
            CustomersGV = new DataGridView();
            label8 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            OrdersGV = new DataGridView();
            label6 = new Label();
            label9 = new Label();
            TotAmount = new Label();
            btnInsert = new Button();
            btnView = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).BeginInit();
            SuspendLayout();
            // 
            // txtCName
            // 
            txtCName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCName.Location = new Point(169, 411);
            txtCName.Multiline = true;
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(162, 31);
            txtCName.TabIndex = 91;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(17, 413);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 92;
            label5.Text = "Customer Name:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(767, 290);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 37);
            btnAdd.TabIndex = 90;
            btnAdd.Text = "Add To Order";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(571, 290);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(162, 31);
            txtQuantity.TabIndex = 89;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 525);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 25);
            panel2.TabIndex = 88;
            // 
            // SearchCmb
            // 
            SearchCmb.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchCmb.FormattingEnabled = true;
            SearchCmb.ItemHeight = 20;
            SearchCmb.Location = new Point(639, 111);
            SearchCmb.Name = "SearchCmb";
            SearchCmb.Size = new Size(162, 28);
            SearchCmb.TabIndex = 87;
            SearchCmb.Text = "Select Category";
            SearchCmb.SelectionChangeCommitted += SearchCmb_SelectionChangeCommitted;
            // 
            // ProductsGV
            // 
            ProductsGV.AllowUserToAddRows = false;
            ProductsGV.AllowUserToDeleteRows = false;
            ProductsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGV.Location = new Point(430, 145);
            ProductsGV.Name = "ProductsGV";
            ProductsGV.ReadOnly = true;
            ProductsGV.RowTemplate.Height = 25;
            ProductsGV.Size = new Size(538, 139);
            ProductsGV.TabIndex = 86;
            ProductsGV.CellContentClick += ProductsGV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 461);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 85;
            label4.Text = "Order Date:";
            // 
            // orderDTP
            // 
            orderDTP.Location = new Point(169, 461);
            orderDTP.Name = "orderDTP";
            orderDTP.Size = new Size(200, 23);
            orderDTP.TabIndex = 84;
            // 
            // txtCusId
            // 
            txtCusId.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCusId.Location = new Point(169, 362);
            txtCusId.Multiline = true;
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(162, 31);
            txtCusId.TabIndex = 82;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 364);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 83;
            label3.Text = "Customer Id:";
            // 
            // txtOderId
            // 
            txtOderId.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtOderId.Location = new Point(169, 307);
            txtOderId.Multiline = true;
            txtOderId.Name = "txtOderId";
            txtOderId.Size = new Size(162, 31);
            txtOderId.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(17, 309);
            label7.Name = "label7";
            label7.Size = new Size(79, 21);
            label7.TabIndex = 81;
            label7.Text = "Order Id:";
            // 
            // CustomersGV
            // 
            CustomersGV.AllowUserToAddRows = false;
            CustomersGV.AllowUserToDeleteRows = false;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGV.Location = new Point(30, 145);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.ReadOnly = true;
            CustomersGV.RowTemplate.Height = 25;
            CustomersGV.Size = new Size(339, 139);
            CustomersGV.TabIndex = 79;
            CustomersGV.CellContentClick += CustomersGV_CellContentClick;
            CustomersGV.SelectionChanged += CustomersGV_SelectionChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(126, 114);
            label8.Name = "label8";
            label8.Size = new Size(174, 25);
            label8.TabIndex = 78;
            label8.Text = "CUSTOMERS LIST";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(980, 100);
            panel1.TabIndex = 77;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(921, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 55);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(278, 10);
            label2.Name = "label2";
            label2.Size = new Size(475, 36);
            label2.TabIndex = 1;
            label2.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(383, 58);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Orders";
            // 
            // OrdersGV
            // 
            OrdersGV.AllowUserToAddRows = false;
            OrdersGV.AllowUserToDeleteRows = false;
            OrdersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGV.Location = new Point(430, 344);
            OrdersGV.Name = "OrdersGV";
            OrdersGV.ReadOnly = true;
            OrdersGV.RowTemplate.Height = 25;
            OrdersGV.Size = new Size(538, 133);
            OrdersGV.TabIndex = 93;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(453, 298);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 94;
            label6.Text = "Quantity:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(453, 486);
            label9.Name = "label9";
            label9.Size = new Size(147, 24);
            label9.TabIndex = 95;
            label9.Text = "Total Amount";
            // 
            // TotAmount
            // 
            TotAmount.AutoSize = true;
            TotAmount.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TotAmount.Location = new Point(619, 485);
            TotAmount.Name = "TotAmount";
            TotAmount.Size = new Size(33, 25);
            TotAmount.TabIndex = 96;
            TotAmount.Text = "Rs";
            TotAmount.Click += TotAmount_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.SeaGreen;
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(30, 490);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(136, 37);
            btnInsert.TabIndex = 97;
            btnInsert.Text = "Insert Order";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnView
            // 
            btnView.BackColor = Color.SeaGreen;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(233, 490);
            btnView.Name = "btnView";
            btnView.Size = new Size(136, 37);
            btnView.TabIndex = 98;
            btnView.Text = "View Order";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(862, 482);
            button4.Name = "button4";
            button4.Size = new Size(97, 37);
            button4.TabIndex = 99;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ManagementOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 550);
            Controls.Add(button4);
            Controls.Add(btnView);
            Controls.Add(btnInsert);
            Controls.Add(TotAmount);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(OrdersGV);
            Controls.Add(txtCName);
            Controls.Add(label5);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(panel2);
            Controls.Add(SearchCmb);
            Controls.Add(ProductsGV);
            Controls.Add(label4);
            Controls.Add(orderDTP);
            Controls.Add(txtCusId);
            Controls.Add(label3);
            Controls.Add(txtOderId);
            Controls.Add(label7);
            Controls.Add(CustomersGV);
            Controls.Add(label8);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagementOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagementOrder";
            ((System.ComponentModel.ISupportInitialize)ProductsGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCName;
        private Label label5;
        private Button btnAdd;
        private TextBox txtQuantity;
        private Panel panel2;
        private ComboBox SearchCmb;
        private DataGridView ProductsGV;
        private Label label4;
        private DateTimePicker orderDTP;
        private TextBox txtCusId;
        private Label label3;
        private TextBox txtOderId;
        private Label label7;
        private DataGridView CustomersGV;
        private Label label8;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView OrdersGV;
        private Label label6;
        private Label label9;
        private Label TotAmount;
        private Button btnInsert;
        private Button btnView;
        private Button button4;
    }
}