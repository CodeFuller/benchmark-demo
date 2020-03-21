namespace ProductionCode
{
	public class IterativeFibonacciNumberCalculator : IFibonacciNumberCalculator
	{
		public int Calculate(int n)
		{
			if (n <= 1)
			{
				return n;
			}

			var n1 = 1;
			var n2 = 0;

			for (var i = 2; i <= n; ++i)
			{
				(n1, n2) = (n1 + n2, n1);
			}

			return n1;
		}
	}
}
