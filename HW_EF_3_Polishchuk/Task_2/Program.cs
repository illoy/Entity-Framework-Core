using Task_2.Models;
using Task_2.Data;

using UniversityContext universities = new UniversityContext();

//University university1 = new University()
//{
//    Name = "NAU",
//    Description = "Some text about NAU"
//};

//University university2 = new University()
//{
//    Name = "KPI",
//    Description = "Some text about KPI"
//};

//universities.AddRange(university1, university2);
//universities.SaveChanges();

//List<Student> students = new List<Student>();
//students.Add(new Student { FirstName = "Anri", LastName = "AA", Age = 19, UniversityId = 1 });
//students.Add(new Student { FirstName = "Illia", LastName = "BB", Age = 21, Phone = "0985364782", UniversityId = 1 });
//students.Add(new Student { FirstName = "Max", LastName = "CC", Age = 24, UniversityId = 1 });
//students.Add(new Student { FirstName = "Roma", LastName = "DD", Age = 21, UniversityId = 1 });
//students.Add(new Student { FirstName = "Vlad", LastName = "EE", Age = 19, Phone = "0987461834", UniversityId = 2 });
//students.Add(new Student { FirstName = "Petya", LastName = "FF", Age = 23, UniversityId = 2 });
//students.Add(new Student { FirstName = "Kolya", LastName = "GG", Age = 25, UniversityId = 2 });
//students.Add(new Student { FirstName = "Anya", LastName = "HH", Age = 26, UniversityId = 2 });

//universities.Students.AddRange(students);
//universities.SaveChanges();



foreach (var item in universities.Universities.ToList())
{
    Console.WriteLine($"UNiversity - {item.Name}:");
    Console.WriteLine(item.Students.Count);
    foreach (var student in item.Students.ToList())
    {
        Console.WriteLine($"Student first name - {student.FirstName}");
        Console.WriteLine($"Student last name - {student.LastName}");
        Console.WriteLine($"Student age - {student.Age}");
        Console.WriteLine($"Student Phone - {student.Phone}");
    }
    Console.WriteLine();
}
