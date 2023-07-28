using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
