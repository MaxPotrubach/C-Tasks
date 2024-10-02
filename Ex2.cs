using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Ex2
	{
		private double a = 5;
		private double b = 8;
		private double c = 10;
		private double Perimeter(double a, double b, double c)
		{
			return a + b + c;
		}

		private double Area(double p, double a, double b, double c)
		{
			return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
		}

		private void Type(double a, double b, double c)
		{
			if (a == b && b == c)
			{
				Console.WriteLine("Triangle is equilteral");
			}
			else if (a == b || b == c || c == a)
			{
				Console.WriteLine("Triangle is isosceles");
			}
			else
			{
				Console.WriteLine("Tringle is versatile");
			}
		}
		public void Exercise()
		{

			if (((a + b) < c || (b + c) < a || (c + a) < b) || (a <= 0 || b <= 0 || c <= 0))
			{
				Console.WriteLine("Trinagle is false");
				return;
			}

			Console.WriteLine("Triangle perimeter: " + (Perimeter(a, b, c)));

			double p = Perimeter(a, b, c) / 2;
			Console.WriteLine("Area of trianle: " + Area(p, a, b, c));

			Type(a, b, c);
		}
	}
}
