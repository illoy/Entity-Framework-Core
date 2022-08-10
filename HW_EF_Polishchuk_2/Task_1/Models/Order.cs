using System.ComponentModel.DataAnnotations.Schema;
namespace Task_1.Models
{
    public class Order
    {
        [Column("Order_id")]
        public int Id { get; set; }
        public Customer Customer { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
