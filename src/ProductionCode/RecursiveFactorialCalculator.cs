namespace ProductionCode
{
	public class RecursiveFactorialCalculator : IFactorialCalculator
	{
		public int Calculate(int n)
		{
			return n == 1 ? 1 : n * Calculate(n - 1);
		}
	}
}
