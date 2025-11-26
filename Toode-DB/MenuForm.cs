namespace WinFormsApp1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 warehouseForm = new Form1();
            warehouseForm.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
        }
    }
}