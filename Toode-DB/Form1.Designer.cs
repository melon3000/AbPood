namespace WinFormsApp1
{
    partial class Form1
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
            toode_pb = new PictureBox();
            toodeLbl = new Label();
            kogusLbl = new Label();
            hindLbl = new Label();
            kategorLbl = new Label();
            kogusTextB = new TextBox();
            hindTextB = new TextBox();
            toodeTextB = new TextBox();
            lisakategorBtn = new Button();
            kustutakategorBtn = new Button();
            lisaBtn = new Button();
            uuendaBtn = new Button();
            KustutaBtn = new Button();
            puhastaBtn = new Button();
            otsifailBtn = new Button();
            poodBtn = new Button();
            kat_box = new ComboBox();
            dataGridView1 = new DataGridView();
            panelHeader = new Panel();
            label1 = new Label();
            panelControls = new Panel();
            panelGrid = new Panel();
            ((System.ComponentModel.ISupportInitialize)toode_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelHeader.SuspendLayout();
            panelControls.SuspendLayout();
            panelGrid.SuspendLayout();
            SuspendLayout();
            // 
            // toode_pb
            // 
            toode_pb.BackColor = Color.FromArgb(60, 60, 60);
            toode_pb.BorderStyle = BorderStyle.FixedSingle;
            toode_pb.Location = new Point(276, 23);
            toode_pb.Name = "toode_pb";
            toode_pb.Size = new Size(811, 365);
            toode_pb.SizeMode = PictureBoxSizeMode.Zoom;
            toode_pb.TabIndex = 0;
            toode_pb.TabStop = false;
            // 
            // toodeLbl
            // 
            toodeLbl.AutoSize = true;
            toodeLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            toodeLbl.ForeColor = Color.White;
            toodeLbl.Location = new Point(20, 25);
            toodeLbl.Name = "toodeLbl";
            toodeLbl.Size = new Size(56, 20);
            toodeLbl.TabIndex = 1;
            toodeLbl.Text = "Toode:";
            // 
            // kogusLbl
            // 
            kogusLbl.AutoSize = true;
            kogusLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            kogusLbl.ForeColor = Color.White;
            kogusLbl.Location = new Point(20, 65);
            kogusLbl.Name = "kogusLbl";
            kogusLbl.Size = new Size(57, 20);
            kogusLbl.TabIndex = 2;
            kogusLbl.Text = "Kogus:";
            // 
            // hindLbl
            // 
            hindLbl.AutoSize = true;
            hindLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            hindLbl.ForeColor = Color.White;
            hindLbl.Location = new Point(20, 105);
            hindLbl.Name = "hindLbl";
            hindLbl.Size = new Size(46, 20);
            hindLbl.TabIndex = 3;
            hindLbl.Text = "Hind:";
            // 
            // kategorLbl
            // 
            kategorLbl.AutoSize = true;
            kategorLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            kategorLbl.ForeColor = Color.White;
            kategorLbl.Location = new Point(20, 145);
            kategorLbl.Name = "kategorLbl";
            kategorLbl.Size = new Size(90, 20);
            kategorLbl.TabIndex = 4;
            kategorLbl.Text = "Kategooria:";
            // 
            // kogusTextB
            // 
            kogusTextB.BackColor = Color.FromArgb(60, 60, 60);
            kogusTextB.BorderStyle = BorderStyle.FixedSingle;
            kogusTextB.Font = new Font("Segoe UI", 10F);
            kogusTextB.ForeColor = Color.White;
            kogusTextB.Location = new Point(120, 63);
            kogusTextB.Name = "kogusTextB";
            kogusTextB.Size = new Size(150, 25);
            kogusTextB.TabIndex = 5;
            // 
            // hindTextB
            // 
            hindTextB.BackColor = Color.FromArgb(60, 60, 60);
            hindTextB.BorderStyle = BorderStyle.FixedSingle;
            hindTextB.Font = new Font("Segoe UI", 10F);
            hindTextB.ForeColor = Color.White;
            hindTextB.Location = new Point(120, 103);
            hindTextB.Name = "hindTextB";
            hindTextB.Size = new Size(150, 25);
            hindTextB.TabIndex = 6;
            // 
            // toodeTextB
            // 
            toodeTextB.BackColor = Color.FromArgb(60, 60, 60);
            toodeTextB.BorderStyle = BorderStyle.FixedSingle;
            toodeTextB.Font = new Font("Segoe UI", 10F);
            toodeTextB.ForeColor = Color.White;
            toodeTextB.Location = new Point(120, 23);
            toodeTextB.Name = "toodeTextB";
            toodeTextB.Size = new Size(150, 25);
            toodeTextB.TabIndex = 8;
            // 
            // lisakategorBtn
            // 
            lisakategorBtn.BackColor = Color.FromArgb(80, 80, 80);
            lisakategorBtn.FlatAppearance.BorderSize = 0;
            lisakategorBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            lisakategorBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            lisakategorBtn.FlatStyle = FlatStyle.Flat;
            lisakategorBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lisakategorBtn.ForeColor = Color.White;
            lisakategorBtn.Location = new Point(19, 187);
            lisakategorBtn.Name = "lisakategorBtn";
            lisakategorBtn.Size = new Size(120, 35);
            lisakategorBtn.TabIndex = 9;
            lisakategorBtn.Text = "➕ Lisa";
            lisakategorBtn.UseVisualStyleBackColor = false;
            lisakategorBtn.Click += lisaBtn_Click;
            // 
            // kustutakategorBtn
            // 
            kustutakategorBtn.BackColor = Color.FromArgb(192, 80, 77);
            kustutakategorBtn.FlatAppearance.BorderSize = 0;
            kustutakategorBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(172, 60, 57);
            kustutakategorBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 100, 97);
            kustutakategorBtn.FlatStyle = FlatStyle.Flat;
            kustutakategorBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            kustutakategorBtn.ForeColor = Color.White;
            kustutakategorBtn.Location = new Point(150, 187);
            kustutakategorBtn.Name = "kustutakategorBtn";
            kustutakategorBtn.Size = new Size(120, 35);
            kustutakategorBtn.TabIndex = 10;
            kustutakategorBtn.Text = "🗑️ Kustuta";
            kustutakategorBtn.UseVisualStyleBackColor = false;
            kustutakategorBtn.Click += kustutakategorBtn_Click;
            // 
            // lisaBtn
            // 
            lisaBtn.BackColor = Color.FromArgb(86, 156, 214);
            lisaBtn.FlatAppearance.BorderSize = 0;
            lisaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 136, 194);
            lisaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 176, 234);
            lisaBtn.FlatStyle = FlatStyle.Flat;
            lisaBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lisaBtn.ForeColor = Color.White;
            lisaBtn.Location = new Point(21, 6);
            lisaBtn.Name = "lisaBtn";
            lisaBtn.Size = new Size(120, 40);
            lisaBtn.TabIndex = 11;
            lisaBtn.Text = "➕ Lisa";
            lisaBtn.UseVisualStyleBackColor = false;
            lisaBtn.Click += lisaBtn_Click_1;
            // 
            // uuendaBtn
            // 
            uuendaBtn.BackColor = Color.FromArgb(106, 176, 76);
            uuendaBtn.FlatAppearance.BorderSize = 0;
            uuendaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 156, 56);
            uuendaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(126, 196, 96);
            uuendaBtn.FlatStyle = FlatStyle.Flat;
            uuendaBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            uuendaBtn.ForeColor = Color.White;
            uuendaBtn.Location = new Point(399, 6);
            uuendaBtn.Name = "uuendaBtn";
            uuendaBtn.Size = new Size(120, 40);
            uuendaBtn.TabIndex = 12;
            uuendaBtn.Text = "Uuenda";
            uuendaBtn.UseVisualStyleBackColor = false;
            uuendaBtn.Click += uuendaBtn_Click;
            // 
            // KustutaBtn
            // 
            KustutaBtn.BackColor = Color.FromArgb(192, 80, 77);
            KustutaBtn.FlatAppearance.BorderSize = 0;
            KustutaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(172, 60, 57);
            KustutaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(212, 100, 97);
            KustutaBtn.FlatStyle = FlatStyle.Flat;
            KustutaBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            KustutaBtn.ForeColor = Color.White;
            KustutaBtn.Location = new Point(147, 6);
            KustutaBtn.Name = "KustutaBtn";
            KustutaBtn.Size = new Size(120, 40);
            KustutaBtn.TabIndex = 13;
            KustutaBtn.Text = "Eemalda";
            KustutaBtn.UseVisualStyleBackColor = false;
            KustutaBtn.Click += KustutaBtn_Click;
            // 
            // puhastaBtn
            // 
            puhastaBtn.BackColor = Color.FromArgb(241, 196, 15);
            puhastaBtn.FlatAppearance.BorderSize = 0;
            puhastaBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(221, 176, 0);
            puhastaBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 216, 35);
            puhastaBtn.FlatStyle = FlatStyle.Flat;
            puhastaBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            puhastaBtn.ForeColor = Color.White;
            puhastaBtn.Location = new Point(273, 6);
            puhastaBtn.Name = "puhastaBtn";
            puhastaBtn.Size = new Size(120, 40);
            puhastaBtn.TabIndex = 14;
            puhastaBtn.Text = "Puhasta";
            puhastaBtn.UseVisualStyleBackColor = false;
            puhastaBtn.Click += puhastaBtn_Click;
            // 
            // otsifailBtn
            // 
            otsifailBtn.BackColor = Color.FromArgb(80, 80, 80);
            otsifailBtn.FlatAppearance.BorderSize = 0;
            otsifailBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 100, 100);
            otsifailBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 120, 120);
            otsifailBtn.FlatStyle = FlatStyle.Flat;
            otsifailBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            otsifailBtn.ForeColor = Color.White;
            otsifailBtn.Location = new Point(525, 6);
            otsifailBtn.Name = "otsifailBtn";
            otsifailBtn.Size = new Size(120, 40);
            otsifailBtn.TabIndex = 15;
            otsifailBtn.Text = "📁 Vali pilt";
            otsifailBtn.UseVisualStyleBackColor = false;
            otsifailBtn.Click += otsifailBtn_Click;
            // 
            // poodBtn
            // 
            poodBtn.BackColor = Color.FromArgb(86, 156, 214);
            poodBtn.FlatAppearance.BorderSize = 0;
            poodBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 136, 194);
            poodBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(106, 176, 234);
            poodBtn.FlatStyle = FlatStyle.Flat;
            poodBtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            poodBtn.ForeColor = Color.White;
            poodBtn.Location = new Point(968, 12);
            poodBtn.Name = "poodBtn";
            poodBtn.Size = new Size(120, 35);
            poodBtn.TabIndex = 20;
            poodBtn.Text = "\U0001f6d2 Poodi";
            poodBtn.UseVisualStyleBackColor = false;
            poodBtn.Click += poodBtn_Click;
            // 
            // kat_box
            // 
            kat_box.BackColor = Color.FromArgb(60, 60, 60);
            kat_box.FlatStyle = FlatStyle.Flat;
            kat_box.Font = new Font("Segoe UI", 10F);
            kat_box.ForeColor = Color.White;
            kat_box.FormattingEnabled = true;
            kat_box.Location = new Point(120, 143);
            kat_box.Name = "kat_box";
            kat_box.Size = new Size(150, 25);
            kat_box.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(45, 45, 45);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(80, 80, 80);
            dataGridView1.Location = new Point(20, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1040, 180);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(40, 40, 40);
            panelHeader.Controls.Add(poodBtn);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1100, 60);
            panelHeader.TabIndex = 24;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1100, 60);
            label1.TabIndex = 0;
            label1.Text = "Toodete Laohaldus";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.FromArgb(50, 50, 50);
            panelControls.BorderStyle = BorderStyle.FixedSingle;
            panelControls.Controls.Add(toodeLbl);
            panelControls.Controls.Add(toodeTextB);
            panelControls.Controls.Add(kogusLbl);
            panelControls.Controls.Add(kat_box);
            panelControls.Controls.Add(hindLbl);
            panelControls.Controls.Add(kategorLbl);
            panelControls.Controls.Add(kogusTextB);
            panelControls.Controls.Add(hindTextB);
            panelControls.Controls.Add(lisakategorBtn);
            panelControls.Controls.Add(kustutakategorBtn);
            panelControls.Controls.Add(toode_pb);
            panelControls.Location = new Point(0, 60);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(1100, 410);
            panelControls.TabIndex = 25;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.FromArgb(60, 60, 60);
            panelGrid.BorderStyle = BorderStyle.FixedSingle;
            panelGrid.Controls.Add(dataGridView1);
            panelGrid.Controls.Add(lisaBtn);
            panelGrid.Controls.Add(KustutaBtn);
            panelGrid.Controls.Add(puhastaBtn);
            panelGrid.Controls.Add(uuendaBtn);
            panelGrid.Controls.Add(otsifailBtn);
            panelGrid.Dock = DockStyle.Bottom;
            panelGrid.Location = new Point(0, 470);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(1100, 250);
            panelGrid.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1100, 720);
            Controls.Add(panelGrid);
            Controls.Add(panelControls);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laohaldus";
            ((System.ComponentModel.ISupportInitialize)toode_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelHeader.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            panelGrid.ResumeLayout(false);
            ResumeLayout(false);
        }

        private PictureBox toode_pb;
        private Label toodeLbl;
        private Label kogusLbl;
        private Label hindLbl;
        private Label kategorLbl;
        private TextBox kogusTextB;
        private TextBox hindTextB;
        private TextBox toodeTextB;
        private Button lisakategorBtn;
        private Button kustutakategorBtn;
        private Button lisaBtn;
        private Button uuendaBtn;
        private Button KustutaBtn;
        private Button puhastaBtn;
        private Button otsifailBtn;
        private Button poodBtn;
        private ComboBox kat_box;
        private DataGridView dataGridView1;
        private Panel panelHeader;
        private Panel panelControls;
        private Panel panelGrid;
        private Label label1;
    }
}