using Task_1.Models;
using Microsoft.EntityFrameworkCore;

namespace Task_1.Data
{
    internal class OrderContext : DbContext
    {
        public OrderContext() => Database.EnsureCreated();

        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Order { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ILLIA;Initial Catalog=StoreLab2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
