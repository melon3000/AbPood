namespace WinFormsApp1
{
    partial class MenuForm
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
            btnWarehouse = new Button();
            btnShop = new Button();
            lblTitle = new Label();
            panelHeader = new Panel();
            gradientPanel1 = new Panel();
            lblVersion = new Label();
            panelFooter = new Panel();
            panelHeader.SuspendLayout();
            gradientPanel1.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // btnWarehouse
            // 
            btnWarehouse.AccessibleName = "ToodeKatalog_btn";
            btnWarehouse.Anchor = AnchorStyles.None;
            btnWarehouse.BackColor = Color.FromArgb(86, 156, 214);
            btnWarehouse.FlatAppearance.BorderSize = 0;
            btnWarehouse.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 136, 194);
            btnWarehouse.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 176, 234);
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnWarehouse.ForeColor = Color.White;
            btnWarehouse.Location = new Point(63, 15);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(280, 70);
            btnWarehouse.TabIndex = 0;
            btnWarehouse.Text = "Toode kataloog";
            btnWarehouse.UseVisualStyleBackColor = false;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnShop
            // 
            btnShop.Anchor = AnchorStyles.None;
            btnShop.BackColor = Color.FromArgb(106, 176, 76);
            btnShop.FlatAppearance.BorderSize = 0;
            btnShop.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 156, 56);
            btnShop.FlatAppearance.MouseOverBackColor = Color.FromArgb(126, 196, 96);
            btnShop.FlatStyle = FlatStyle.Flat;
            btnShop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnShop.ForeColor = Color.White;
            btnShop.Location = new Point(63, 100);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(280, 70);
            btnShop.TabIndex = 1;
            btnShop.Text = "Pood";
            btnShop.UseVisualStyleBackColor = false;
            btnShop.Click += btnShop_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 100);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Laohaldus Süsteem";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(40, 40, 40);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(400, 100);
            panelHeader.TabIndex = 3;
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.FromArgb(60, 60, 60);
            gradientPanel1.Controls.Add(btnShop);
            gradientPanel1.Controls.Add(btnWarehouse);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 100);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(400, 189);
            gradientPanel1.TabIndex = 4;
            // 
            // lblVersion
            // 
            lblVersion.Dock = DockStyle.Fill;
            lblVersion.Font = new Font("Segoe UI", 8F);
            lblVersion.ForeColor = Color.Gray;
            lblVersion.Location = new Point(0, 0);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(400, 20);
            lblVersion.TabIndex = 5;
            lblVersion.Text = "Versioon 1.0 | © 2024 Laohaldus Süsteem";
            lblVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(30, 30, 30);
            panelFooter.Controls.Add(lblVersion);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 289);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(400, 20);
            panelFooter.TabIndex = 7;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(400, 309);
            Controls.Add(gradientPanel1);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Peamenüü";
            panelHeader.ResumeLayout(false);
            gradientPanel1.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button btnWarehouse;
        private Button btnShop;
        private Label lblTitle;
        private Panel panelHeader;
        private Panel gradientPanel1;
        private Label lblVersion;
        private Panel panelFooter;
    }
}