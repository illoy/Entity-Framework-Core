using Microsoft.EntityFrameworkCore;
using Task_1.Models;

namespace Task_1.Data
{
    internal class ProductContext : DbContext
    {
        public DbSet<Company> Companies { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Country> Countries { get; set; } = null!;
        
        
        //public ProductContext() 
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ILLIA;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
