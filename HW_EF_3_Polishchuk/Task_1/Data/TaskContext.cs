using Microsoft.EntityFrameworkCore;
using Task_1.Models;

namespace Task_1.Data
{
    internal class TaskContext : DbContext
    {
        public DbSet<MyTask> MyTasks { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        //public TaskContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ILLIA;Initial Catalog=MyTassk_Lab3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CategoryTask>()
                .HasKey(k => new { k.MyTaskId, k.CategoryId });

            builder.Entity<CategoryTask>()
                .HasOne(ct => ct.MyTask)
                .WithMany(s => s.CategoryTasks)
                .HasForeignKey(ct => ct.MyTaskId);

            builder.Entity<CategoryTask>()
                .HasOne(ct => ct.Category)
                .WithMany(s => s.CategoryTasks)
                .HasForeignKey(ct => ct.CategoryId);
        }
    }
}
