using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploring.Models
{
	public class Course
	{
		public string Name { get; set; }
		public List<Person> Students { get; set; }

		//body expression can be used in methods too.
		public void AddStudent(Person student) => Students.Add(student);

		public int Enrolled() => Students.Count;

		public void RemoveStudent(Person student) => Students.Remove(student);

		public void ListStudents()
		{
			Console.WriteLine($"Students from {Name} course:");
			foreach (Person student in Students)
			{
				Console.WriteLine(student.FullName);
			}
		}
	}
}
