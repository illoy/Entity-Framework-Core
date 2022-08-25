using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    public class Product
    {
        [Column("Product_Id")]
        public int Id { get; set; }
        [Column("ProductName")]
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public Company? Company { get; set; }
    }
}
