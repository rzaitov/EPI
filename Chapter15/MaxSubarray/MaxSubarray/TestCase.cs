using System;

using NUnit.Framework;

namespace MaxSubarray
{
	[TestFixture]
	public class TestCase 
	{
		[Test]
		public void Test()
		{
			Check(new int[] { 904, 40, 523, 12, -335, -385, -124, 481, -31 }, 0, 3, 1479);
			Check(new int[] { -10, 5, 1, -1, -5, 15, 5, -3, -4, 100 }, 1, 9, 113);
		}

		private void Check(int[] array, int lExpected, int rExpected, int sumExpected)
		{
			int l, r, sum;
			SumArrayDivider devider = new SumArrayDivider();
			devider.Divide(array, out l, out r, out sum);

			Assert.AreEqual(lExpected, l);
			Assert.AreEqual(rExpected, r);
			Assert.AreEqual(sumExpected, sum);
		}
	}
}

