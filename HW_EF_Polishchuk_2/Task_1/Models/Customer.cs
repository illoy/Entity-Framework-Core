using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    public class Customer
    {
        [Column("Customer_id")]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
