using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

/* public means that everyone can access this class/method/properties */
/* private means that only can be accessed inside of the own class in properties */
/* if you try access in another file, you will receive a warning saying that you
 * can't access it because you don't have privileges. */

namespace exploring.Models
{
	public class Person
	{
		//validating get and set
		private string _name;
		private int _age;

		public string Name
		{
			// this symbol "=>" called as body expression. Used to simple 
			// validations, don't need to use curly brackets and return
			get => _name.ToUpper();

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
		
		public string LastName { get; set; }

		// when have only get and not set, property turn read only, it means
		// that you can't change in another file (e.g. person.FullName = "")
		public string FullName => $"{Name} {LastName}".ToUpper();

		public int Age
		{
			get => _age;

			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Age can't be less than zero!");
				}
				_age = value;
			}
		}

		public void Greeting()
		{
			Console.WriteLine($"Name: {FullName}, Age: {Age}");
		}
	}
}

/* this module is to see deeply about get, set, methods */
