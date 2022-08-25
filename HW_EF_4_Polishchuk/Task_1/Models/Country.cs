using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    public class Country
    {
        [Column("Country_Id")]
        public int Id { get; set; }
        [Column("CountryName")]
        public string Name { get; set; } = null!;

        public List<Company> Companies { get; set; }
        public Country()
        {
            Companies = new List<Company>();
        }
    }
}
