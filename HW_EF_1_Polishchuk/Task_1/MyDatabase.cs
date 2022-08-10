using System;
using System.Data.Entity;
using System.Linq;

namespace Task_1
{
    public class MyDatabase : DbContext
    {
        public MyDatabase()
            : base("name=LibaryData")
        {
        }

        public virtual DbSet<Emploees> Emploee { get; set; }
    }
}