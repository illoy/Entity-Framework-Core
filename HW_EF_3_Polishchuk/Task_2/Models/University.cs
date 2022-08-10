using System.ComponentModel.DataAnnotations.Schema;

namespace Task_2.Models
{
    public class University
    {
        [Column("UniversityId")]
        public int Id { get; set; }
        [Column("University_Name")]
        public string Name { get; set; } = null!;
        public string Description { get; set; } = "-";

        public List<Student> Students { get; set; }
        public University()
        {
            Students = new List<Student>();
        }
    }
}
