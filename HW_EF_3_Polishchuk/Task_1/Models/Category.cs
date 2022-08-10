using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    public class Category
    {
        [Column("Category_id")]
        public int Id { get; set; }
        [Column("Category_Name")]
        public string Name { get; set; } = null!;
        public string Importance { get; set; } = null!;
        public List<CategoryTask> CategoryTasks { get; set; }
        public Category()
        {
            CategoryTasks = new List<CategoryTask>();
        }
    }
}
