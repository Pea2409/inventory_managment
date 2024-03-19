namespace InventoryManagment
{
    partial class ManagementUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementUsers));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            txtUuser = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            button3 = new Button();
            button4 = new Button();
            UsersGV = new DataGridView();
            panel2 = new Panel();
            txtUFullName = new TextBox();
            txtUPassword = new TextBox();
            txtUPhone = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UsersGV).BeginInit();
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
            panel1.TabIndex = 0;
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
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Manage Users";
            // 
            // txtUuser
            // 
            txtUuser.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUuser.Location = new Point(140, 164);
            txtUuser.Multiline = true;
            txtUuser.Name = "txtUuser";
            txtUuser.Size = new Size(162, 31);
            txtUuser.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 166);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 225);
            label4.Name = "label4";
            label4.Size = new Size(90, 21);
            label4.TabIndex = 4;
            label4.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 285);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 6;
            label5.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 343);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 8;
            label6.Text = "Phone:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(30, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 37);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(129, 399);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 37);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(227, 398);
            button3.Name = "button3";
            button3.Size = new Size(75, 37);
            button3.TabIndex = 7;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnDelete_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(107, 461);
            button4.Name = "button4";
            button4.Size = new Size(97, 37);
            button4.TabIndex = 12;
            button4.Text = "HOME";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UsersGV
            // 
            UsersGV.AllowUserToAddRows = false;
            UsersGV.AllowUserToDeleteRows = false;
            UsersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGV.Location = new Point(392, 166);
            UsersGV.Name = "UsersGV";
            UsersGV.ReadOnly = true;
            UsersGV.RowTemplate.Height = 25;
            UsersGV.Size = new Size(543, 286);
            UsersGV.TabIndex = 13;
            UsersGV.CellContentClick += UsersGV_CellContentClick;
            UsersGV.SelectionChanged += UsersGV_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 525);
            panel2.Name = "panel2";
            panel2.Size = new Size(980, 25);
            panel2.TabIndex = 14;
            // 
            // txtUFullName
            // 
            txtUFullName.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUFullName.Location = new Point(140, 225);
            txtUFullName.Multiline = true;
            txtUFullName.Name = "txtUFullName";
            txtUFullName.Size = new Size(162, 31);
            txtUFullName.TabIndex = 2;
            // 
            // txtUPassword
            // 
            txtUPassword.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUPassword.Location = new Point(140, 285);
            txtUPassword.Multiline = true;
            txtUPassword.Name = "txtUPassword";
            txtUPassword.Size = new Size(162, 31);
            txtUPassword.TabIndex = 3;
            // 
            // txtUPhone
            // 
            txtUPhone.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUPhone.Location = new Point(140, 340);
            txtUPhone.Multiline = true;
            txtUPhone.Name = "txtUPhone";
            txtUPhone.Size = new Size(162, 31);
            txtUPhone.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(140, 117);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(162, 31);
            txtID.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(42, 120);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 18;
            label7.Text = "Id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MidnightBlue;
            label8.Location = new Point(624, 120);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 3;
            label8.Text = "USERS LIST";
            // 
            // ManagementUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 550);
            Controls.Add(label8);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(txtUPhone);
            Controls.Add(txtUPassword);
            Controls.Add(txtUFullName);
            Controls.Add(UsersGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUuser);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManagementUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManagementUsers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UsersGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUuser;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private Button button3;
        private Button button4;
        private DataGridView UsersGV;
        private Panel panel2;
        private TextBox txtUFullName;
        private TextBox txtUPassword;
        private TextBox txtUPhone;
        private TextBox txtID;
        private Label label7;
        private Label label8;
    }
}