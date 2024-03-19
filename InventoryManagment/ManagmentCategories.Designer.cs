namespace InventoryManagment
{
    partial class ManagmentCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagmentCategories));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtCateId = new TextBox();
            label7 = new Label();
            label3 = new Label();
            txtCateName = new TextBox();
            CategoriesGV = new DataGridView();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategoriesGV).BeginInit();
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
            panel1.TabIndex = 2;
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
            label1.Size = new Size(215, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Categories";
            // 
            // txtCateId
            // 
            txtCateId.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCateId.Location = new Point(176, 176);
            txtCateId.Multiline = true;
            txtCateId.Name = "txtCateId";
            txtCateId.Size = new Size(162, 31);
            txtCateId.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(23, 178);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 28;
            label7.Text = "Category Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 229);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 27;
            label3.Text = "Category Name:";
            // 
            // txtCateName
            // 
            txtCateName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCateName.Location = new Point(176, 228);
            txtCateName.Multiline = true;
            txtCateName.Name = "txtCateName";
            txtCateName.Size = new Size(162, 31);
            txtCateName.TabIndex = 26;
            // 
            // CategoriesGV
            // 
            CategoriesGV.AllowUserToAddRows = false;
            CategoriesGV.AllowUserToDeleteRows = false;
            CategoriesGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriesGV.Location = new Point(424, 173);
            CategoriesGV.Name = "CategoriesGV";
            CategoriesGV.ReadOnly = true;
            CategoriesGV.RowTemplate.Height = 25;
            CategoriesGV.Size = new Size(529, 286);
            CategoriesGV.TabIndex = 34;
            CategoriesGV.CellContentClick += CategoriesGV_CellContentClick;
            CategoriesGV.SelectionChanged += CategoriesGV_SelectionChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(599, 132);
            label8.Name = "label8";
            label8.Size = new Size(181, 25);
            label8.TabIndex = 33;
            label8.Text = "CATEGORIES LIST";
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(134, 404);
            button4.Name = "button4";
            button4.Size = new Size(97, 37);
            button4.TabIndex = 38;
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
            button3.Location = new Point(254, 341);
            button3.Name = "button3";
            button3.Size = new Size(75, 37);
            button3.TabIndex = 37;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(156, 342);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 37);
            btnUpdate.TabIndex = 36;
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
            btnAdd.Location = new Point(57, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 37);
            btnAdd.TabIndex = 35;
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
            panel2.TabIndex = 39;
            // 
            // ManagmentCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 550);
            Controls.Add(panel2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(CategoriesGV);
            Controls.Add(label8);
            Controls.Add(txtCateId);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(txtCateName);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagmentCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagmentCategories";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategoriesGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox txtCateId;
        private Label label7;
        private Label label3;
        private TextBox txtCateName;
        private DataGridView CategoriesGV;
        private Label label8;
        private Button button4;
        private Button button3;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel panel2;
    }
}