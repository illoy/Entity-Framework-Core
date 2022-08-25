using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    public class Company
    {
        [Column("Company_Id")]
        public int Id { get; set; }
        [Column("CompanyName")]
        public string Name { get; set; } = null!;

        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        public List<Product> Countries { get; set; }
        public Company()
        {
            Countries = new List<Product>();
        }
    }
}
