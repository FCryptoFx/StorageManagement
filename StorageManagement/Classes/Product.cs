using Microsoft.Data.SqlClient;
using System.Data;

namespace StorageManagement.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProdCode { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? Storage { get; set; }
        public int? CalcStock { get; set; }

        string connectionString = "Data Source=KH006;Initial Catalog=StorageManagement;Integrated Security=True; Encrypt=False";

        public List<Product> GetProduct()
        {
            List<Product> ProductList = new List<Product>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "SELECT Id, ProdCode, Description, Location, Storage, CalcStock FROM Product";
            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Product product = new Product();

                    product.Id = Convert.ToInt32(dr["Id"]);
                    product.ProdCode = dr["ProdCode"].ToString();
                    product.Description = dr["Description"].ToString();
                    product.Location = dr["Location"].ToString();
                    product.Storage = dr["Storage"].ToString();
                    product.CalcStock = Convert.ToInt32(dr["CalcStock"]);

                    ProductList.Add(product);
                }
            }
            return ProductList;
        }

        public void CreateProduct(Product product)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string insertSQL = "INSERT INTO Product (ProdCode, Description, Location, Storage, CalcStock) " +
                                "VALUES (@ProdCode, @Description, @Location, @Storage, @CalcStock)";

            using (SqlCommand cmd = new SqlCommand(insertSQL, con))
            {
                cmd.Parameters.AddWithValue("@ProdCode", product.ProdCode);
                cmd.Parameters.AddWithValue("@Description", product.Description);
                cmd.Parameters.AddWithValue("@Location", product.Location);
                cmd.Parameters.AddWithValue("@Storage", product.Storage);
                cmd.Parameters.AddWithValue("@CalcStock", product.CalcStock);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
