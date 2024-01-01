using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploring.Models
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		
		public void Greeting()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
		}
	}
}

/* this module is to see deeply about get, set, methods */
