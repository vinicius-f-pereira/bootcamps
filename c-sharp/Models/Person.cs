using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

/* namespace are like env path
methods can be called as functions too
 */
namespace c_sharp.Models
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public void Greeting()
		{
			Console.WriteLine($"Hello! Ny name is {Name} and I'm {Age} years old.");
		}
	}
}

/* You can use @class or any other reserved key of CS with '@', but isn't a good practice. */
/* You can build to class with the same name in the same project, but they need to have
different namespaces. */
