using System;
using System.Collections.Generic;

using NUnit.Framework;

using BinarySearch;

namespace UnitTest
{
	[TestFixture]
	public class FindFirstGreaterThan
	{
		private int[] _testData;
		Comparer<int> _comparer;

		[SetUp]
		public void Setup()
		{
			_testData = new int[] { -14, -10, 2, 108, 108, 243, 285, 285, 285, 401 };
			_comparer = Comparer<int>.Default;
		}

		[Test]
		public void ElementInsideRagne()
		{
			int index;

			index = _testData.FirstGreaterThan(-14, _comparer);
			Assert.AreEqual(1, index);

			index = _testData.FirstGreaterThan(1, _comparer);
			Assert.AreEqual(2, index);

			index = _testData.FirstGreaterThan(2, _comparer);
			Assert.AreEqual(3, index);

			index = _testData.FirstGreaterThan(100, _comparer);
			Assert.AreEqual(3, index);

			index = _testData.FirstGreaterThan(400, _comparer);
			Assert.AreEqual(9, index);
		}

		[Test]
		public void ElementLessThanLeftBound()
		{
			int index;

			index = _testData.FirstGreaterThan(-20, _comparer);
			Assert.AreEqual(0, index);

			index = _testData.FirstGreaterThan(-15, _comparer);
			Assert.AreEqual(0, index);
		}

		[Test]
		public void ElementsGreaterOrEqualThanRightBound()
		{
			int index;

			index = _testData.FirstGreaterThan(401, _comparer);
			Assert.AreEqual(-1, index);

			index = _testData.FirstGreaterThan(500, _comparer);
			Assert.AreEqual(-1, index);
		}
	}

}

