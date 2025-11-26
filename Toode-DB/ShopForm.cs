using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class ShopForm : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\db2-main\DbUsage2-main\toodeDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        private List<CartItem> cart = new List<CartItem>();
        private decimal totalAmount = 0;

        public ShopForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    "SELECT T.Id, T.Toodenimetus, T.Kogus, T.Hind, T.Bpilt, K.Kategooria_nimetus AS Kategooria " +
                    "FROM Toodetabel T INNER JOIN Kategooria K ON T.Kategooriad = K.Id WHERE T.Kogus > 0", connect);
                
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewProducts.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kauba laadimise viga: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Valige toode, mida soovite ostukorvi lisada!");
                return;
            }

            var row = dataGridViewProducts.SelectedRows[0];
            int productId = Convert.ToInt32(row.Cells["Id"].Value);
            string productName = row.Cells["Toodenimetus"].Value.ToString();
            decimal price = Convert.ToDecimal(row.Cells["Hind"].Value);
            int availableQty = Convert.ToInt32(row.Cells["Kogus"].Value);

            if (numericUpDownQty.Value > availableQty)
            {
                MessageBox.Show($"Laos pole piisavalt kaupa! Saadaval: {availableQty}");
                return;
            }

            var existingItem = cart.FirstOrDefault(x => x.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += (int)numericUpDownQty.Value;
            }
            else
            {
                cart.Add(new CartItem
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price,
                    Quantity = (int)numericUpDownQty.Value
                });
            }

            UpdateCartDisplay();
            MessageBox.Show($"Toode {productName} lisatud ostukorvi!");
        }

        private void UpdateCartDisplay()
        {
            listBoxCart.Items.Clear();
            totalAmount = 0;

            foreach (var item in cart)
            {
                decimal itemTotal = item.Price * item.Quantity;
                totalAmount += itemTotal;
                listBoxCart.Items.Add($"{item.ProductName} x{item.Quantity} = {itemTotal:C}");
            }

            lblTotal.Text = $"Kokku: {totalAmount:C}";
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Ostukorv on tühi!");
                return;
            }

            try
            {
                connect.Open();
                SqlTransaction transaction = connect.BeginTransaction();

                foreach (var item in cart)
                {
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Toodetabel SET Kogus = Kogus - @qty WHERE Id = @id AND Kogus >= @qty", 
                        connect, transaction);
                    cmd.Parameters.AddWithValue("@qty", item.Quantity);
                    cmd.Parameters.AddWithValue("@id", item.ProductId);
                    
                    int affected = cmd.ExecuteNonQuery();
                    if (affected == 0)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Kaupu pole piisavalt '{item.ProductName}' laos!");
                        connect.Close();
                        return;
                    }
                }

                transaction.Commit();
                connect.Close();

                MessageBox.Show($"Ost on lõpetatud! Kogusumma: {totalAmount:C}");
                cart.Clear();
                UpdateCartDisplay();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ostmisel tekkinud viga: " + ex.Message);
                if (connect.State == ConnectionState.Open) connect.Close();
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cart.Clear();
            UpdateCartDisplay();
            MessageBox.Show("Ostukorv on tühjendatud!");
        }

        private void btnBackToWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 warehouseForm = new Form1();
            warehouseForm.Show();
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewProducts.Rows[e.RowIndex];
                if (row.Cells["Bpilt"].Value is byte[] imageData && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBoxProduct.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxProduct.Image = null;
                }
            }
        }
    }

    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}