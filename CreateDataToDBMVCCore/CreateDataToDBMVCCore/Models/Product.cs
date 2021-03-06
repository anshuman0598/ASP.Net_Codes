using System.ComponentModel.DataAnnotations.Schema;

namespace CreateDataToDBMVCCore.Models
{
    [Table("Product")]
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool Status { get; set; }
    }

}


