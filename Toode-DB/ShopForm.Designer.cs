namespace WinFormsApp1
{
    partial class ShopForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewProducts = new DataGridView();
            pictureBoxProduct = new PictureBox();
            listBoxCart = new ListBox();
            numericUpDownQty = new NumericUpDown();
            btnAddToCart = new Button();
            btnPurchase = new Button();
            btnClearCart = new Button();
            btnBackToWarehouse = new Button();
            btnBackToMenu = new Button();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panelHeader = new Panel();
            panelMain = new Panel();
            panelCart = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelCart.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.BackgroundColor = Color.FromArgb(45, 45, 45);
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.GridColor = Color.FromArgb(80, 80, 80);
            dataGridViewProducts.Location = new Point(12, 15);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersVisible = false;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(480, 244);
            dataGridViewProducts.TabIndex = 0;
            dataGridViewProducts.CellClick += dataGridViewProducts_CellClick;
            // 
            // pictureBoxProduct
            // 
            pictureBoxProduct.BackColor = Color.FromArgb(60, 60, 60);
            pictureBoxProduct.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxProduct.Location = new Point(508, 15);
            pictureBoxProduct.Name = "pictureBoxProduct";
            pictureBoxProduct.Size = new Size(212, 200);
            pictureBoxProduct.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxProduct.TabIndex = 1;
            pictureBoxProduct.TabStop = false;
            // 
            // listBoxCart
            // 
            listBoxCart.BackColor = Color.FromArgb(45, 45, 45);
            listBoxCart.BorderStyle = BorderStyle.FixedSingle;
            listBoxCart.Font = new Font("Segoe UI", 10F);
            listBoxCart.ForeColor = Color.White;
            listBoxCart.FormattingEnabled = true;
            listBoxCart.ItemHeight = 17;
            listBoxCart.Location = new Point(20, 15);
            listBoxCart.Name = "listBoxCart";
            listBoxCart.Size = new Size(260, 291);
            listBoxCart.TabIndex = 2;
            // 
            // numericUpDownQty
            // 
            numericUpDownQty.BackColor = Color.FromArgb(60, 60, 60);
            numericUpDownQty.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownQty.Font = new Font("Segoe UI", 11F);
            numericUpDownQty.ForeColor = Color.White;
            numericUpDownQty.Location = new Point(507, 232);
            numericUpDownQty.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQty.Name = "numericUpDownQty";
            numericUpDownQty.Size = new Size(80, 27);
            numericUpDownQty.TabIndex = 3;
            numericUpDownQty.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(80, 80, 80);
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            btnAddToCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 186);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(593, 231);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(125, 28);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "Lisa ostukorvisse";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.FromArgb(86, 156, 214);
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 136, 194);
            btnPurchase.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 176, 234);
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Location = new Point(20, 340);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(120, 40);
            btnPurchase.TabIndex = 5;
            btnPurchase.Text = "Osta";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(192, 80, 77);
            btnClearCart.FlatAppearance.BorderSize = 0;
            btnClearCart.FlatAppearance.MouseDownBackColor = Color.FromArgb(172, 60, 57);
            btnClearCart.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 100, 97);
            btnClearCart.FlatStyle = FlatStyle.Flat;
            btnClearCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(160, 340);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(120, 40);
            btnClearCart.TabIndex = 6;
            btnClearCart.Text = "Tühjenda";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnBackToWarehouse
            // 
            btnBackToWarehouse.BackColor = Color.FromArgb(80, 80, 80);
            btnBackToWarehouse.FlatAppearance.BorderSize = 0;
            btnBackToWarehouse.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            btnBackToWarehouse.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            btnBackToWarehouse.FlatStyle = FlatStyle.Flat;
            btnBackToWarehouse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBackToWarehouse.ForeColor = Color.White;
            btnBackToWarehouse.Location = new Point(507, 281);
            btnBackToWarehouse.Name = "btnBackToWarehouse";
            btnBackToWarehouse.Size = new Size(211, 99);
            btnBackToWarehouse.TabIndex = 7;
            btnBackToWarehouse.Text = "Kataloog";
            btnBackToWarehouse.UseVisualStyleBackColor = false;
            btnBackToWarehouse.Click += btnBackToWarehouse_Click;
            // 
            // btnBackToMenu
            // 
            btnBackToMenu.BackColor = Color.FromArgb(80, 80, 80);
            btnBackToMenu.FlatAppearance.BorderSize = 0;
            btnBackToMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            btnBackToMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            btnBackToMenu.FlatStyle = FlatStyle.Flat;
            btnBackToMenu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBackToMenu.ForeColor = Color.White;
            btnBackToMenu.Location = new Point(12, 281);
            btnBackToMenu.Name = "btnBackToMenu";
            btnBackToMenu.Size = new Size(480, 99);
            btnBackToMenu.TabIndex = 12;
            btnBackToMenu.Text = "Menüü";
            btnBackToMenu.UseVisualStyleBackColor = false;
            btnBackToMenu.Click += btnBackToMenu_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(20, 312);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(91, 25);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Kokku: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 9;
            label1.Text = "Tooded";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(760, 15);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 10;
            label2.Text = "Ostukorv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(514, 221);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 11;
            label3.Text = "Kogus:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(40, 40, 40);
            panelHeader.BorderStyle = BorderStyle.FixedSingle;
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1040, 60);
            panelHeader.TabIndex = 13;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(60, 60, 60);
            panelMain.BorderStyle = BorderStyle.FixedSingle;
            panelMain.Controls.Add(btnBackToMenu);
            panelMain.Controls.Add(dataGridViewProducts);
            panelMain.Controls.Add(btnBackToWarehouse);
            panelMain.Controls.Add(pictureBoxProduct);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(numericUpDownQty);
            panelMain.Controls.Add(btnAddToCart);
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(740, 396);
            panelMain.TabIndex = 14;
            // 
            // panelCart
            // 
            panelCart.BackColor = Color.FromArgb(50, 50, 50);
            panelCart.BorderStyle = BorderStyle.FixedSingle;
            panelCart.Controls.Add(listBoxCart);
            panelCart.Controls.Add(lblTotal);
            panelCart.Controls.Add(btnPurchase);
            panelCart.Controls.Add(btnClearCart);
            panelCart.Location = new Point(740, 60);
            panelCart.Name = "panelCart";
            panelCart.Size = new Size(300, 396);
            panelCart.TabIndex = 15;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1040, 453);
            Controls.Add(panelCart);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ShopForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pood";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQty).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelCart.ResumeLayout(false);
            panelCart.PerformLayout();
            ResumeLayout(false);
        }

        private DataGridView dataGridViewProducts;
        private PictureBox pictureBoxProduct;
        private ListBox listBoxCart;
        private NumericUpDown numericUpDownQty;
        private Button btnAddToCart;
        private Button btnPurchase;
        private Button btnClearCart;
        private Button btnBackToWarehouse;
        private Button btnBackToMenu;
        private Label lblTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panelHeader;
        private Panel panelMain;
        private Panel panelCart;
    }
}