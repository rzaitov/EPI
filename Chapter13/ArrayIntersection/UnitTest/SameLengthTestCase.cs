using System;
using System.Collections.Generic;

using NUnit.Framework;

using SortedCollectionIntersection;

namespace UnitTest
{
	[TestFixture]
	public class SameLengthTestCase : TestCaseBase
	{
		protected override List<int> DoIntersect(IList<int> first, IList<int> second)
		{
			return first.IntersectOrdered3(second, _comparer);
		}
	}
}

