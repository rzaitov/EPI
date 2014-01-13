using System;

namespace MaxSubarray
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] test = new int[] { 904, 40, 523, 12, -335, -385, -124, 481, -31 };

			int l, r, sum;
			SumArrayDivider devider = new SumArrayDivider();
			devider.Divide1(test, out l, out r, out sum);

			Console.WriteLine(string.Format("A[{0}:{1}] sum = {2}", l, r, sum));
		}
	}
}
