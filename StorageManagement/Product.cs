﻿using Microsoft.Data.SqlClient;

namespace StorageManagement
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProdCode { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public string? Storage { get; set; }
        public int? CalcStore { get; set; }

        string connectionString = "Data Source=LOCALHOST;Initial Catalog=\"Storage Management\";Integrated Security=True";

        public List<Product> GetProduct()
        {
            List<Product> ProductList = new List<Product>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "SELECT Id, ProdCode, Description, Location, Storage, CalcStock FROM Storage Management";
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
                    product.CalcStore = Convert.ToInt32(dr["CalcStock"]);

                    ProductList.Add(product);
                }
            }
            return ProductList;
        }
    }
}
