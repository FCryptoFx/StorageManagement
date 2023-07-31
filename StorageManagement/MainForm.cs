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
    }
}