namespace InventoryManagment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(227, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 376);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.Red;
            checkBox1.Location = new Point(164, 331);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 20);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(64, 332);
            label5.Name = "label5";
            label5.Size = new Size(43, 16);
            label5.TabIndex = 7;
            label5.Text = "Clear";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 209);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 163);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 5;
            label3.Text = "Username: ";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(95, 261);
            button1.Name = "button1";
            button1.Size = new Size(133, 40);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new Size(173, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(116, 160);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter username";
            txtUsername.Size = new Size(173, 23);
            txtUsername.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(137, 22);
            label2.Name = "label2";
            label2.Size = new Size(534, 38);
            label2.TabIndex = 2;
            label2.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(741, -8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 55);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 484);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label4;
        private Label label3;
        private CheckBox checkBox1;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button1;
        private PictureBox pictureBox2;
    }
}