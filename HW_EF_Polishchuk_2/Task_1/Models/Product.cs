using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    public class Product
    {
        [Column("Product_id")]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }
}
