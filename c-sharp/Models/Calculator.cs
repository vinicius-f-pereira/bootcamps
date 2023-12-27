using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_sharp.Models
{
	public class Calculator
	{
		public void Sum(int x, int y)
		{
			Console.WriteLine($"{x} + {y} = {x + y}");
		}

		public void Sub(int x, int y)
		{
			Console.WriteLine($"{x} - {y} = {x - y}");
		}

		public void Mult(int x, int y)
		{
			Console.WriteLine($"{x} * {y} = {x * y}");
		}

		public void Div(int x, int y)
		{
			Console.WriteLine($"{x} / {y} = {x / y}");
		}

		public void Mod(int x, int y)
		{
			Console.WriteLine($"{x} % {y} = {x % y}");
		}

		public void Pow(int x, int y)
		{
			Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
		}

		public void Sin(double angle)
		{
			double rad = angle * Math.PI;
			Console.WriteLine($"Sin of {angle}° = {Math.Sin(rad)}");
		}
	}
}
