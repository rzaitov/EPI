using System;

using NUnit.Framework;

namespace MaxSubarray
{
	[TestFixture]
	public class TestCase 
	{
		[Test]
		public void TestDevide1()
		{
			CheckDevide1(new int[] { 904, 40, 523, 12, -335, -385, -124, 481, -31 }, 0, 3, 1479);
			CheckDevide1(new int[] { -10, 5, 1, -1, -5, 15, 5, -3, -4, 100 }, 1, 9, 113);
		}

		[Test]
		public void TestDevide2()
		{
			CheckDevide2(new int[] { 904, 40, 523, 12, -335, -385, -124, 481, -31 }, 0, 3, 1479);
			CheckDevide2(new int[] { -10, 5, 1, -1, -5, 15, 5, -3, -4, 100 }, 1, 9, 113);
		}

		private void CheckDevide1(int[] array, int lExpected, int rExpected, int sumExpected)
		{
			int l, r, sum;
			SumArrayDivider devider = new SumArrayDivider();
			devider.Divide1(array, out l, out r, out sum);

			Assert.AreEqual(lExpected, l);
			Assert.AreEqual(rExpected, r);
			Assert.AreEqual(sumExpected, sum);
		}

		private void CheckDevide2(int[] array, int lExpected, int rExpected, int sumExpected)
		{
			int l, r, sum;
			SumArrayDivider devider = new SumArrayDivider();
			devider.Divide2(array, out l, out r, out sum);

			Assert.AreEqual(lExpected, l);
			Assert.AreEqual(rExpected, r);
			Assert.AreEqual(sumExpected, sum);
		}

	}
}

