using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_2.Models
{
    public class Company
    {
        [Column("Company_id")]
        public int Id { get; set; }

        [Column("CompanyName")]
        public string Name { get; set; } = null!;

        [Column("CompanyDecription")]
        public string? Description { get; set; }

        [Column("CompanyPhone")]
        public string? Phone { get; set; } 
    }
}
