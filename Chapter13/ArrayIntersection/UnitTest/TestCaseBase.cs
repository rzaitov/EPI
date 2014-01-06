using System;
using System.Collections.Generic;

using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace UnitTest
{
	public abstract class TestCaseBase
	{
		protected int[] _first;
		protected int[] _second;
		protected int[] _third;

		protected Comparer<int> _comparer;

		[SetUp]
		public void Setup()
		{
			_first = new int[] { 1, 2, 3, 4, 5, 5, 6, 6, 6, 7, 8, 9, 10, 10 };
			_second = new int[] { 5, 5, 6, 6, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
			_third = new int[] { 100, 200, 300, 400, 500 };

			_comparer = Comparer<int>.Default;

		}

		[Test]
		public void WithCommonElements()
		{
			Intersect(_first, _second, new int[] { 5, 6, 7, 8, 9, 10 });
		}

		[Test]
		public void IntersectWithEmptyCollection()
		{
			Intersect(_first, new int[] { }, new int[] { });
		}

		[Test]
		public void IntersectDifferentRanges()
		{
			Intersect(_first, _third, new int[] { });
		}

		private void Intersect(int[] first, int[] second, int[] expected)
		{
			List<int> intersection;

			intersection = DoIntersect(first, second);// first.IntersectOrdered1(second, _comparer);
			Assert.That(intersection, Is.EqualTo(expected));

			intersection = DoIntersect(second, first); // second.IntersectOrdered1(first, _comparer);
			Assert.That(intersection, Is.EqualTo(expected));
		}

		protected abstract List<int> DoIntersect(IList<int> first, IList<int> second);
	}
}

