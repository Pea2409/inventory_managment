namespace InventoryManagment
{
    partial class ManagementProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementProducts));
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtPId = new TextBox();
            label7 = new Label();
            txtPPrice = new TextBox();
            txtPQuantity = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtPName = new TextBox();
            txtPDes = new TextBox();
            label6 = new Label();
            CateCmb = new ComboBox();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            ProductsGV = new DataGridView();
            label9 = new Label();
            SearchCmb = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 525);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 25);
            panel2.TabIndex = 41;
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
            panel1.TabIndex = 40;
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
            label1.Size = new Size(192, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Products";
            // 
            // txtPId
            // 
            txtPId.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPId.Location = new Point(189, 111);
            txtPId.Multiline = true;
            txtPId.Name = "txtPId";
            txtPId.Size = new Size(162, 31);
            txtPId.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 113);
            label7.Name = "label7";
            label7.Size = new Size(96, 21);
            label7.TabIndex = 49;
            label7.Text = "Product Id:";
            // 
            // txtPPrice
            // 
            txtPPrice.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPPrice.Location = new Point(189, 276);
            txtPPrice.Multiline = true;
            txtPPrice.Name = "txtPPrice";
            txtPPrice.Size = new Size(162, 31);
            txtPPrice.TabIndex = 46;
            // 
            // txtPQuantity
            // 
            txtPQuantity.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPQuantity.Location = new Point(189, 216);
            txtPQuantity.Multiline = true;
            txtPQuantity.Name = "txtPQuantity";
            txtPQuantity.Size = new Size(162, 31);
            txtPQuantity.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 278);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 48;
            label5.Text = "Product Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(37, 218);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 47;
            label4.Text = "Product Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(37, 167);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 45;
            label3.Text = "Product Name:";
            // 
            // txtPName
            // 
            txtPName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPName.Location = new Point(189, 157);
            txtPName.Multiline = true;
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(162, 31);
            txtPName.TabIndex = 43;
            // 
            // txtPDes
            // 
            txtPDes.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPDes.Location = new Point(189, 330);
            txtPDes.Multiline = true;
            txtPDes.Name = "txtPDes";
            txtPDes.Size = new Size(162, 31);
            txtPDes.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(37, 332);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 51;
            label6.Text = "Description:";
            // 
            // CateCmb
            // 
            CateCmb.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CateCmb.FormattingEnabled = true;
            CateCmb.ItemHeight = 20;
            CateCmb.Location = new Point(189, 382);
            CateCmb.Name = "CateCmb";
            CateCmb.Size = new Size(162, 28);
            CateCmb.TabIndex = 52;
            CateCmb.Text = "Product Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(37, 384);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 53;
            label8.Text = "Category:";
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(135, 487);
            button4.Name = "button4";
            button4.Size = new Size(97, 37);
            button4.TabIndex = 57;
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
            button3.Location = new Point(255, 424);
            button3.Name = "button3";
            button3.Size = new Size(75, 37);
            button3.TabIndex = 56;
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
            btnUpdate.Location = new Point(157, 425);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 37);
            btnUpdate.TabIndex = 55;
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
            btnAdd.Location = new Point(58, 424);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 37);
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // ProductsGV
            // 
            ProductsGV.AllowUserToAddRows = false;
            ProductsGV.AllowUserToDeleteRows = false;
            ProductsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsGV.Location = new Point(410, 216);
            ProductsGV.Name = "ProductsGV";
            ProductsGV.ReadOnly = true;
            ProductsGV.RowTemplate.Height = 25;
            ProductsGV.Size = new Size(529, 286);
            ProductsGV.TabIndex = 59;
            ProductsGV.CellContentClick += ProductsGV_CellContentClick;
            ProductsGV.SelectionChanged += ProductsGV_SelectionChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MidnightBlue;
            label9.Location = new Point(592, 111);
            label9.Name = "label9";
            label9.Size = new Size(160, 25);
            label9.TabIndex = 58;
            label9.Text = "PRODUCTS LIST";
            // 
            // SearchCmb
            // 
            SearchCmb.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchCmb.FormattingEnabled = true;
            SearchCmb.ItemHeight = 20;
            SearchCmb.Location = new Point(560, 165);
            SearchCmb.Name = "SearchCmb";
            SearchCmb.Size = new Size(162, 28);
            SearchCmb.TabIndex = 60;
            SearchCmb.Text = "Select Category";
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(753, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 62;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Goldenrod;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(845, 159);
            button2.Name = "button2";
            button2.Size = new Size(75, 37);
            button2.TabIndex = 63;
            button2.Text = "Refesh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ManagementProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 550);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(SearchCmb);
            Controls.Add(ProductsGV);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(CateCmb);
            Controls.Add(txtPDes);
            Controls.Add(label6);
            Controls.Add(txtPId);
            Controls.Add(label7);
            Controls.Add(txtPPrice);
            Controls.Add(txtPQuantity);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagementProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagementProducts";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtPId;
        private Label label7;
        private TextBox txtPPrice;
        private TextBox txtPQuantity;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPName;
        private TextBox txtPDes;
        private Label label6;
        private ComboBox CateCmb;
        private Label label8;
        private Button button4;
        private Button button3;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView ProductsGV;
        private Label label9;
        private ComboBox SearchCmb;
        private Button button1;
        private Button button2;
    }
}