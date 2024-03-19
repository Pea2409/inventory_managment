namespace InventoryManagment
{
    partial class ManagementCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementCustomers));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtCId = new TextBox();
            label7 = new Label();
            txtCPhone = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtCName = new TextBox();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            CustomersGV = new DataGridView();
            panel3 = new Panel();
            OrderLabel = new Label();
            label5 = new Label();
            panel4 = new Panel();
            AmountLabel = new Label();
            label10 = new Label();
            panel5 = new Panel();
            DateLabel = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
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
            panel1.TabIndex = 1;
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
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Customers";
            // 
            // txtCId
            // 
            txtCId.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCId.Location = new Point(189, 143);
            txtCId.Multiline = true;
            txtCId.Name = "txtCId";
            txtCId.Size = new Size(162, 31);
            txtCId.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(36, 145);
            label7.Name = "label7";
            label7.Size = new Size(110, 21);
            label7.TabIndex = 24;
            label7.Text = "Customer Id:";
            // 
            // txtCPhone
            // 
            txtCPhone.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPhone.Location = new Point(189, 248);
            txtCPhone.Multiline = true;
            txtCPhone.Name = "txtCPhone";
            txtCPhone.Size = new Size(162, 31);
            txtCPhone.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 250);
            label4.Name = "label4";
            label4.Size = new Size(139, 21);
            label4.TabIndex = 23;
            label4.Text = "Customer Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 196);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 22;
            label3.Text = "Customer Name:";
            // 
            // txtCName
            // 
            txtCName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCName.Location = new Point(189, 195);
            txtCName.Multiline = true;
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(162, 31);
            txtCName.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(586, 121);
            label8.Name = "label8";
            label8.Size = new Size(174, 25);
            label8.TabIndex = 25;
            label8.Text = "CUSTOMERS LIST";
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(148, 411);
            button4.Name = "button4";
            button4.Size = new Size(97, 37);
            button4.TabIndex = 30;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(268, 348);
            button3.Name = "button3";
            button3.Size = new Size(75, 37);
            button3.TabIndex = 29;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(170, 349);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 37);
            btnUpdate.TabIndex = 28;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(71, 348);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 37);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 525);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 25);
            panel2.TabIndex = 31;
            // 
            // CustomersGV
            // 
            CustomersGV.AllowUserToAddRows = false;
            CustomersGV.AllowUserToDeleteRows = false;
            CustomersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGV.Location = new Point(411, 162);
            CustomersGV.Name = "CustomersGV";
            CustomersGV.ReadOnly = true;
            CustomersGV.RowTemplate.Height = 25;
            CustomersGV.Size = new Size(529, 224);
            CustomersGV.TabIndex = 32;
            CustomersGV.CellContentClick += CustomersGV_CellContentClick;
            CustomersGV.SelectionChanged += CustomersGV_SelectionChanged_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Purple;
            panel3.Controls.Add(OrderLabel);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(357, 411);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 33;
            // 
            // OrderLabel
            // 
            OrderLabel.AutoSize = true;
            OrderLabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            OrderLabel.ForeColor = Color.Transparent;
            OrderLabel.Location = new Point(45, 40);
            OrderLabel.Name = "OrderLabel";
            OrderLabel.Size = new Size(114, 36);
            OrderLabel.TabIndex = 35;
            OrderLabel.Text = "ORDER";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 34;
            label5.Text = "Oders Count";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Purple;
            panel4.Controls.Add(AmountLabel);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(563, 411);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 36;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLabel.ForeColor = Color.Transparent;
            AmountLabel.Location = new Point(45, 40);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(144, 36);
            AmountLabel.TabIndex = 35;
            AmountLabel.Text = "AMOUNT";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Transparent;
            label10.Location = new Point(3, 3);
            label10.Name = "label10";
            label10.Size = new Size(125, 21);
            label10.TabIndex = 34;
            label10.Text = "Oders Amount";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Purple;
            panel5.Controls.Add(DateLabel);
            panel5.Controls.Add(label12);
            panel5.Location = new Point(768, 411);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 37;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.ForeColor = Color.Transparent;
            DateLabel.Location = new Point(45, 40);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(87, 36);
            DateLabel.TabIndex = 35;
            DateLabel.Text = "DATE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Transparent;
            label12.Location = new Point(3, 3);
            label12.Name = "label12";
            label12.Size = new Size(134, 21);
            label12.TabIndex = 34;
            label12.Text = "Last Order Date";
            // 
            // ManagementCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 550);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(CustomersGV);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(txtCId);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(txtCPhone);
            Controls.Add(txtCName);
            Controls.Add(label4);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagementCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagementCustomers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CustomersGV).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtCId;
        private Label label7;
        private TextBox txtCPhone;
        private Label label4;
        private Label label3;
        private TextBox txtCName;
        private Label label8;
        private Button button4;
        private Button button3;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel panel2;
        private DataGridView CustomersGV;
        private Panel panel3;
        private Label OrderLabel;
        private Label label5;
        private Panel panel4;
        private Label AmountLabel;
        private Label label10;
        private Panel panel5;
        private Label DateLabel;
        private Label label12;
    }
}