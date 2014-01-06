using System;
using System.Collections.Generic;

using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

using SortedCollectionIntersection;

namespace UnitTest
{
	[TestFixture]
	public class NaiveImplTestCase : TestCaseBase
	{
		protected override List<int> DoIntersect(IList<int> first, IList<int> second)
		{
			return first.IntersectOrdered1(second, _comparer);
		}
	}
}

