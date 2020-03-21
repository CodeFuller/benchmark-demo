using BenchmarkDotNet.Running;

namespace BenchmarkDemo
{
	public static class Program
	{
		public static void Main()
		{
			var summary = BenchmarkRunner.Run<FactorialBenchmark>();
		}
	}
}
