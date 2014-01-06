using System;
using System.Collections.Generic;

using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

using SortedCollectionIntersection;

namespace UnitTest
{
	[TestFixture]
	public class SmallHugeTestCase : TestCaseBase
	{
		protected override List<int> DoIntersect(IList<int> first, IList<int> second)
		{
			return first.IntersectOrdered2(second, _comparer);
		}
	}
}

