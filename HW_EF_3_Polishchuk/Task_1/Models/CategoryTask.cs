namespace Task_1.Models
{
    public class CategoryTask
    {
        public int MyTaskId { get; set; }
        public MyTask MyTask { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
