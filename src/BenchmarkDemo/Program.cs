using System;
using ProductionCode;

namespace BenchmarkDemo
{
	public static class Program
	{
		public static void Main()
		{
			var calculator = new IterativeFactorialCalculator();

			Print(calculator, 1);
			Print(calculator, 2);
			Print(calculator, 5);
		}

		private static void Print(IFactorialCalculator calculator, int n)
		{
			var value = calculator.Calculate(n);

			Console.WriteLine($"Value for {n}: {value}", n, value);
		}
	}
}
