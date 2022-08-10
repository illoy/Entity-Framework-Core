using System.ComponentModel.DataAnnotations.Schema;

namespace Task_2.Models
{
    public class Student
    {
        [Column("Student_Id")]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string Phone { get; set; } = "-";

        public int UniversityId { get; set; }
        [ForeignKey("UniversityId")]
        public University Universities { get; set; }

    }
}
