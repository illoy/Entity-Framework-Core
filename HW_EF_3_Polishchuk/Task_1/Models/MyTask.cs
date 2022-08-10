using System.ComponentModel.DataAnnotations.Schema;

namespace Task_1.Models
{
    public class MyTask
    {
        [Column("Task_id")]
        public int Id { get; set; }
        [Column("Task_Name")]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = "-";
        public List<CategoryTask> CategoryTasks { get; set; }
        public MyTask()
        {
            CategoryTasks = new List<CategoryTask>();
        }
    }
}
