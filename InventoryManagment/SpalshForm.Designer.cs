namespace InventoryManagment
{
    partial class SpalshForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpalshForm));
            label2 = new Label();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(163, 9);
            label2.Name = "label2";
            label2.Size = new Size(475, 36);
            label2.TabIndex = 2;
            label2.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(278, 54);
            label1.Name = "label1";
            label1.Size = new Size(234, 24);
            label1.TabIndex = 3;
            label1.Text = "Developer by Furteen";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ButtonHighlight;
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.ForeColor = Color.Black;
            progressBar1.Location = new Point(0, 427);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 23);
            progressBar1.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // SpalshForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SpalshForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SpalshForm";
            Load += SpalshForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}