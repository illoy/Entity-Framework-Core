using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_2.Models;

namespace Task_2.Data
{
    internal class CompanyContext : DbContext
    {
        public DbSet<Company> Companys { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ILLIA;Initial Catalog=CompanyProductLab2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("CompanyProduct");
            builder.Property(p => p.Id).HasColumnName("Product_id");
            builder.Property(p => p.Name).HasMaxLength(20);
            builder.Property(p => p.Description).HasMaxLength(50).HasColumnName("ProductDescroption").HasDefaultValue("Not information!");
            builder.Property(p => p.Price).HasColumnName("ProductPrice");
        }
    }
}
