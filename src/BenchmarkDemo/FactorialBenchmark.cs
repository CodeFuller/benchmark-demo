using BenchmarkDotNet.Attributes;
using ProductionCode;

namespace BenchmarkDemo
{
	public class FactorialBenchmark
	{
		[Params(100, 10000)]
		public int N { get; set; }

		[Benchmark]
		public int CalculateRecursively()
		{
			return Calculate<RecursiveFactorialCalculator>();
		}

		[Benchmark]
		public int CalculateIteratively()
		{
			return Calculate<IterativeFactorialCalculator>();
		}

		private int Calculate<TCalculator>()
			where TCalculator : IFactorialCalculator, new()
		{
			var calculator = new TCalculator();
			return calculator.Calculate(N);
		}
	}
}
