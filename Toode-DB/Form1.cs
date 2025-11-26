using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\db2-main\DbUsage2-main\toodeDB.mdf;Integrated Security=True;Connect Timeout=30";

        SqlConnection connect;

        SqlCommand command;
        SqlDataAdapter adapter_toode, adapter_kategooria;

        OpenFileDialog open;
        byte[] imageData;

        public Form1()
        {
            InitializeComponent();

            connect = new SqlConnection(connectionString);

            NaitaKategooriad();
            NaitaAndmed();
        }

        private void lisaBtn_Click(object sender, EventArgs e)
        {
            bool olemas = kat_box.Items.Cast<object>().Any(item => item.ToString() == kat_box.Text);

            if (!olemas && !string.IsNullOrWhiteSpace(kat_box.Text))
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("INSERT INTO Kategooria (Kategooria_nimetus) VALUES (@kat)", connect);
                    command.Parameters.AddWithValue("@kat", kat_box.Text);
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Kategooria lisatud!");
                    NaitaKategooriad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Viga: " + ex.Message);
                    if (connect.State == ConnectionState.Open) connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Selline kategooria on juba olemas, või nimetus tekstiridas puudub!");
            }
        }

        private void otsifailBtn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane\source\repos\WinFormsApp1\images";
            open.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string projectPath = AppDomain.CurrentDomain.BaseDirectory;
                string imagesFolder = Path.Combine(projectPath, "images");

                Directory.CreateDirectory(imagesFolder);

                string destPath = Path.Combine(imagesFolder, toodeTextB.Text + Path.GetExtension(open.FileName));

                try
                {
                    File.Copy(open.FileName, destPath, true);
                    toode_pb.Image = Image.FromFile(destPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Viga faili valimisel: " + ex.Message);
                }
            }
        }

        private void lisaBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(toodeTextB.Text) || string.IsNullOrWhiteSpace(kogusTextB.Text) || string.IsNullOrWhiteSpace(hindTextB.Text))
            {
                MessageBox.Show("Täitke kõik väljad!");
                return;
            }

            try
            {
                connect.Open();

                command = new SqlCommand("SELECT Id FROM Kategooria WHERE Kategooria_nimetus = @kat", connect);
                command.Parameters.AddWithValue("@kat", kat_box.Text);
                object result = command.ExecuteScalar();

                if (result == null)
                {
                    MessageBox.Show("Kategooriat ei leitud!");
                    connect.Close();
                    return;
                }

                int katId = Convert.ToInt32(result);

                if (!int.TryParse(kogusTextB.Text, out int kogus) || !int.TryParse(hindTextB.Text, out int hind))
                {
                    MessageBox.Show("Sisestage numbrilised väärtused väljadesse 'Kogus' ja 'Hind'.");
                    connect.Close();
                    return;
                }

                command = new SqlCommand(
                    "INSERT INTO Toodetabel (Toodenimetus, Kogus, Hind, Pilt, Bpilt, Kategooriad) " +
                    "VALUES (@toode, @kogus, @hind, @pilt, @bpilt, @kat)", connect);

                command.Parameters.AddWithValue("@toode", toodeTextB.Text);
                command.Parameters.AddWithValue("@kogus", kogus);
                command.Parameters.AddWithValue("@hind", hind);

                if (open != null && !string.IsNullOrEmpty(open.FileName))
                {
                    string extension = Path.GetExtension(open.FileName);
                    command.Parameters.AddWithValue("@pilt", toodeTextB.Text + extension);
                    byte[] imageData = File.ReadAllBytes(open.FileName);
                    command.Parameters.AddWithValue("@bpilt", imageData);
                }
                else
                {
                    command.Parameters.AddWithValue("@pilt", DBNull.Value);
                    command.Parameters.AddWithValue("@bpilt", DBNull.Value);
                }

                command.Parameters.AddWithValue("@kat", katId);

                int rows = command.ExecuteNonQuery();
                MessageBox.Show($"Toode on edukalt lisatud!");

                connect.Close();
                NaitaAndmed();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga lisamisel: " + ex.Message);
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void NaitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooria", connect);
            DataTable tabel_kat = new DataTable();
            adapter_kategooria.Fill(tabel_kat);
            connect.Close();

            kat_box.Items.Clear();
            foreach (DataRow item in tabel_kat.Rows)
            {
                kat_box.Items.Add(item["Kategooria_nimetus"].ToString());
            }
        }
        private void kustutakategorBtn_Click(object sender, EventArgs e)
        {
            if (kat_box.SelectedItem != null)
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("DELETE FROM Kategooria WHERE Kategooria_nimetus=@kat", connect);
                    command.Parameters.AddWithValue("@kat", kat_box.SelectedItem.ToString());
                    command.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Kategooria on kustutatud!");
                    NaitaKategooriad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Viga kategooria kustutamisel: " + ex.Message);
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Valige kustutamiseks kategooria!");
            }
        }
        public void NaitaAndmed()
        {
            connect.Open();

            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter(
                "SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Pilt, T.Bpilt, " +
                "K.Kategooria_nimetus AS Kategooria " +
                "FROM Toodetabel T INNER JOIN Kategooria K ON T.Kategooriad = K.Id", connect);

            adapter_toode.Fill(dt_toode);
            connect.Close();

            dataGridView1.DataSource = dt_toode;

            if (!dataGridView1.Columns.Contains("Bpilt"))
                dataGridView1.Columns.Add("Bpilt", "Bpilt");

            dataGridView1.Columns["Bpilt"].Visible = true
                ;
        }

        private Form popupForm;

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Проверяем, что наведение именно на столбец "Bpilt"
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Bpilt")
                {
                    var cellValue = dataGridView1.Rows[e.RowIndex].Cells["Bpilt"].Value;
                    if (cellValue is byte[] data && data.Length > 0)
                    {
                        using MemoryStream ms = new MemoryStream(data);
                        Image img = Image.FromStream(ms);
                        ShowPopupImage(img, e.RowIndex, e.ColumnIndex);
                    }
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            popupForm?.Close();
        }

        private void ShowPopupImage(Image img, int rowIndex, int colIndex)
        {
            popupForm?.Close();

            popupForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                Size = new Size(200, 200),
                StartPosition = FormStartPosition.Manual,
                TopMost = true,
                BackColor = Color.Black,
                Opacity = 0.95
            };

            PictureBox pb = new PictureBox
            {
                Image = img,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            popupForm.Controls.Add(pb);

            Rectangle cellRect = dataGridView1.GetCellDisplayRectangle(colIndex, rowIndex, true);
            Point cellLocation = dataGridView1.PointToScreen(cellRect.Location);
            popupForm.Location = new Point(cellLocation.X + cellRect.Width + 10, cellLocation.Y);

            popupForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FillFieldsFromSelectedRow();
            }
        }

        private void FillFieldsFromSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];

                toodeTextB.Text = row.Cells["Toodenimetus"].Value?.ToString() ?? "";
                kogusTextB.Text = row.Cells["Kogus"].Value?.ToString() ?? "";
                hindTextB.Text = row.Cells["Hind"].Value?.ToString() ?? "";

                string kategooria = row.Cells["Kategooria"].Value?.ToString();
                if (!string.IsNullOrEmpty(kategooria))
                {
                    kat_box.Text = kategooria;
                }

                //naitame pilt
                if (row.Cells["Bpilt"].Value is byte[] imageData && imageData.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(imageData))
                        {
                            toode_pb.Image = Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                        toode_pb.Image = null;
                    }
                }
                else
                {
                    toode_pb.Image = null;
                }
            }
        }

        private void puhastaBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            toodeTextB.Clear();
            kogusTextB.Clear();
            hindTextB.Clear();
            kat_box.SelectedIndex = -1;
            toode_pb.Image = null;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
            }
        }

        private void KustutaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Valige kustutamiseks rida!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                var confirm = MessageBox.Show(
                    "Oled kindel, et soovid seda toodet kustutada?",
                    "Kinnitus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Toodetabel WHERE Id = @Id", connect))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        connect.Open();
                        int rows = cmd.ExecuteNonQuery();
                        connect.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("Toode on edukalt kustutatud!", "Edu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NaitaAndmed();
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Toodet ei leitud!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga kustutamisel: " + ex.Message, "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void uuendaBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vali uuendatav toode!");
                return;
            }

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

            if (id <= 0)
            {
                MessageBox.Show("Vale ID!");
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                List<string> updateFields = new List<string>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;

                //Toodenimetus
                if (!string.IsNullOrWhiteSpace(toodeTextB.Text))
                {
                    updateFields.Add("Toodenimetus=@toode");
                    cmd.Parameters.AddWithValue("@toode", toodeTextB.Text.Trim());
                }

                //Kogus
                if (!string.IsNullOrWhiteSpace(kogusTextB.Text))
                {
                    if (int.TryParse(kogusTextB.Text, out int kogus))
                    {
                        updateFields.Add("Kogus=@kogus");
                        cmd.Parameters.AddWithValue("@kogus", kogus);
                    }
                    else
                    {
                        MessageBox.Show("Põld 'kogus peab olema number!");
                        connect.Close();
                        return;
                    }
                }

                //Hind
                if (!string.IsNullOrWhiteSpace(hindTextB.Text))
                {
                    if (decimal.TryParse(
                        hindTextB.Text.Replace(',', '.'),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out decimal hind))
                    {
                        updateFields.Add("Hind=@hind");
                        cmd.Parameters.AddWithValue("@hind", hind);
                    }
                    else
                    {
                        MessageBox.Show("Hind peab olema number!");
                        connect.Close();
                        return;
                    }
                }

                //Pildid
                if (toode_pb.Image != null && open != null && !string.IsNullOrEmpty(open.FileName))
                {
                    if (File.Exists(open.FileName))
                    {
                        string ext = Path.GetExtension(open.FileName);
                        string fileName = toodeTextB.Text.Trim() + ext;

                        updateFields.Add("Pilt=@pilt");
                        updateFields.Add("Bpilt=@bpilt");

                        byte[] imageBytes = File.ReadAllBytes(open.FileName);
                        cmd.Parameters.AddWithValue("@pilt", fileName);
                        cmd.Parameters.AddWithValue("@bpilt", imageBytes);
                    }
                }

                //Kategooria
                if (kat_box.SelectedIndex != -1)
                {
                    updateFields.Add("Kategooriad=@kat");

                    SqlCommand getCat = new SqlCommand(
                        "SELECT Id FROM Kategooria WHERE Kategooria_nimetus=@nim", connect);
                    getCat.Parameters.AddWithValue("@nim", kat_box.Text);

                    int katId = Convert.ToInt32(getCat.ExecuteScalar());
                    cmd.Parameters.AddWithValue("@kat", katId);
                }

                if (updateFields.Count == 0)
                {
                    MessageBox.Show("Andmeid uuendamiseks pole! Täitke vähemalt üks väli.");
                    connect.Close();
                    return;
                }

                //UPDATE
                string query = "UPDATE Toodetabel SET " +
                               string.Join(", ", updateFields) +
                               " WHERE Id=@id";

                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = query;

                int rows = cmd.ExecuteNonQuery();
                connect.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Toode on edukalt uuendatud!");
                    NaitaAndmed();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Värskendamise viga!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Viga: " + ex.Message);
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void poodBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
        }
    }
}
