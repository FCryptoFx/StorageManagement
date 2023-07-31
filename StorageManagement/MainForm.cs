using StorageManagement;
using StorageManagement.Classes;

namespace StorageManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillGridView();
        }

        void FillGridView()
        {
            List<Product> productsList = new List<Product>();
            Product product = new Product();

            productsList = product.GetProduct();

            dataGridViewProduct.DataSource = productsList;
        }

        private void buttonNewProduct_Click(object sender, EventArgs e)
        {
            NewProductForm formNewProduct = new NewProductForm();
            formNewProduct.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            FillGridView();
        }
    }
}