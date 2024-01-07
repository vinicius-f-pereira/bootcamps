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
			for (int count = 0; count < Students.Count; count++)
			{
				// string message = "Nbr " + (count + 1) + " " + Students[count].FullName; concatenation of strings. 
				string message = $"Std Nbr: {count + 1} - {Students[count].FullName}"; // interpolation of a string '$' to accept vars

				Console.WriteLine(message);
			}
		}
	}
}
