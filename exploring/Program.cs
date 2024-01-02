using System.Net.Security;
using exploring.Models;

// with constructor, we can give arguments directly in function.
Person p1 = new Person("Stete", "Freitas");
// p1.Name = "Stete";
// p1.LastName = "Freitas";

Person p2 = new Person("Lila", "Freitas");
// p2.Name = "Lila";
// p2.LastName = "Freitas";

Person p3 = new Person("Nivi", "Freitas");
// p3.Name = "Nivi";
// p3.LastName = "Freitas";

Course englishCourse = new Course();
englishCourse.Name = "English";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);
englishCourse.AddStudent(p3);
englishCourse.ListStudents();
