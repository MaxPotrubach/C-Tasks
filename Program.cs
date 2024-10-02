using ConsoleApp1;

namespace Pz1
{
	internal class Program
	{
		public const int N = 10 + 4;
		static void Main(string[] args)
		{
			Ex1 ex1 = new Ex1();
			ex1.Exercise(N);
			Ex2 ex2 = new Ex2();
			ex2.Exercise();
			Ex3 ex3 = new Ex3();
			ex3.Exercise(N);
			Ex4 ex4 = new Ex4();
			ex4.Exercise(N);
		}
	}
}