using System;
using System.Collections.Generic;

using NUnit.Framework;

using BinarySearch;

namespace UnitTest
{
	[TestFixture]
	public class BinarySearchTestCase
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
		public void FindUniqElements()
		{
			int index;

			index = _testData.DoBinarySearch(-14, _comparer);
			Assert.AreEqual(0, index);

			index = _testData.DoBinarySearch(-10, _comparer);
			Assert.AreEqual(1, index);

			index = _testData.DoBinarySearch(2, _comparer);
			Assert.AreEqual(2, index);

			index = _testData.DoBinarySearch(243, _comparer);
			Assert.AreEqual(5, index);

			index = _testData.DoBinarySearch(401, _comparer);
			Assert.AreEqual(9, index);
		}

		[Test]
		public void FindDuplicatedElements()
		{
			int index;

			index = _testData.DoBinarySearch(108, _comparer);
			Assert.AreEqual(3, index);

			index = _testData.DoBinarySearch(285, _comparer);
			Assert.AreEqual(6, index);
		}

		[Test]
		public void FindNonexistedElements()
		{
			int index;

			index = _testData.DoBinarySearch(-15, _comparer);
			Assert.AreEqual(-1, index);

			index = _testData.DoBinarySearch(-20, _comparer);
			Assert.AreEqual(-1, index);

			index = _testData.DoBinarySearch(402, _comparer);
			Assert.AreEqual(-1, index);

			index = _testData.DoBinarySearch(777, _comparer);
			Assert.AreEqual(-1, index);
		}
	}
}

