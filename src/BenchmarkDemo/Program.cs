using System;
using ProductionCode;

namespace BenchmarkDemo
{
	public static class Program
	{
		public static void Main()
		{
			var calculator = new IterativeFibonacciNumberCalculator();

			Print(calculator, 0);
			Print(calculator, 1);
			Print(calculator, 2);
			Print(calculator, 7);
		}

		private static void Print(IFibonacciNumberCalculator calculator, int n)
		{
			var value = calculator.Calculate(n);

			Console.WriteLine($"Value for {n}: {value}", n, value);
		}
	}
}
