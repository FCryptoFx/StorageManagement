using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StorageManagement.Classes;

namespace StorageManagement
{
    public partial class NewProductForm : Form
    {
        public NewProductForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            SaveProductData();
            this.Close();
        }

        void SaveProductData()
        {
            Product product = new Product();

            product.ProdCode = textBoxCodeProd.Text;
            product.Description = textBoxDescription.Text;
            product.Location = textBoxLocation.Text;
            product.Storage = textBoxStorage.Text;
            product.CalcStock = (int?)numericUpDownCalcStock.Value;

            product.CreateProduct(product);
        }
    }
}
