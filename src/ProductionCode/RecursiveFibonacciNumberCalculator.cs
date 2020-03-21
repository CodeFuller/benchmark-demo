namespace ProductionCode
{
	public class RecursiveFibonacciNumberCalculator : IFibonacciNumberCalculator
	{
		public int Calculate(int n)
		{
			switch (n)
			{
				case 0:
					return 0;

				case 1:
					return 1;

				default:
					return Calculate(n - 1) + Calculate(n - 2);
			}
		}
	}
}
