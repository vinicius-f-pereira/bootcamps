using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exploring.Models
{
	public class Person
	{
		//validating get and set
		private string _name;
		public string Name 
		{
			get
			{
				return _name.ToUpper();
			}
			
			set
			{
				//if it enter here, will throw exception and stop the program.
				if (value == "")
				{
					throw new ArgumentException("Name can't be empty!");
				}
				_name = value;
			}
		}
		public int Age { get; set; }
		
		public void Greeting()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
		}
	}
}

/* this module is to see deeply about get, set, methods */
