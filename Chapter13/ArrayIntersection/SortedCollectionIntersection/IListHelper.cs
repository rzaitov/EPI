using System;
using System.Collections.Generic;

namespace SortedCollectionIntersection
{
	public static class IListHelper
	{
		/// <summary>
		/// Intersect ordered collections. Result array will be wihout duplicates. Time: O(mn)
		/// </summary>
		public static List<T> IntersectOrdered1<T>(this IList<T> first, IList<T> second, Comparer<T> comparer)
		{
			List<T> common = new List<T>();

			for(int i = 0; i < first.Count; i++)
			{
				if(i != 0 && comparer.Compare(first[i], first[i - 1]) == 0)
					continue;

				for(int j = 0; j < second.Count; j++)
				{
					if(comparer.Compare(first[i], second[j]) == 0)
					{
						common.Add(first[i]);
						break;
					}
				}
			}

			return common;
		}
	}
}

