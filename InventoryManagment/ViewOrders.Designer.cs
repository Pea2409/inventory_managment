namespace InventoryManagment
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            panel1 = new Panel();
            label1 = new Label();
            OrdersGV = new DataGridView();
            btnView = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(307, 21);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 1;
            label1.Text = "View Orders";
            label1.Click += label1_Click;
            // 
            // OrdersGV
            // 
            OrdersGV.AllowUserToAddRows = false;
            OrdersGV.AllowUserToDeleteRows = false;
            OrdersGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGV.Location = new Point(109, 108);
            OrdersGV.Name = "OrdersGV";
            OrdersGV.ReadOnly = true;
            OrdersGV.RowTemplate.Height = 25;
            OrdersGV.Size = new Size(542, 297);
            OrdersGV.TabIndex = 94;
            OrdersGV.CellContentClick += OrdersGV_CellContentClick;
            // 
            // btnView
            // 
            btnView.BackColor = Color.SeaGreen;
            btnView.FlatAppearance.BorderSize = 0;
            btnView.FlatStyle = FlatStyle.Flat;
            btnView.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(307, 440);
            btnView.Name = "btnView";
            btnView.Size = new Size(136, 37);
            btnView.TabIndex = 99;
            btnView.Text = "Back";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(btnView);
            Controls.Add(OrdersGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView OrdersGV;
        private Button btnView;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}