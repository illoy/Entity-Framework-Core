using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ProductNum { get; set; } = null!;
        public decimal Cost { get; set; } = 0;
        public int Count { get; set; } = 0;
        public DateTime SellStartDate { get; set; }

    }
}
