using Task_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Task_2.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<University> Universities { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ILLIA;Initial Catalog=UniversityContext_Lab3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(p => p.Universities)
                .WithMany(t => t.Students)
                .HasForeignKey(p => p.UniversityId);
                //.HasPrincipalKey(t => t.Name);
        }
    }


}
