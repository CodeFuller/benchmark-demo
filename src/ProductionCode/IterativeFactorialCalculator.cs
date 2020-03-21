namespace ProductionCode
{
	public class IterativeFactorialCalculator : IFactorialCalculator
	{
		public int Calculate(int n)
		{
			var value = 1;
			for (var i = 2; i <= n; ++i)
			{
				value *= i;
			}

			return value;
		}
	}
}
