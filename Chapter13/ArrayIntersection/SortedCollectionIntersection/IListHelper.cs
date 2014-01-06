using System;
using System.Collections.Generic;

using BinarySearch;

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

		/// <summary>
		/// Intersect ordered collections. Best for n << m. Result array will be wihout duplicates. Time: O(n*log(m))
		/// </summary>
		public static List<T> IntersectOrdered2<T>(this IList<T> first, IList<T> second, Comparer<T> comparer)
		{
			bool firstIsBigger = first.Count > second.Count;

			IList<T> small = firstIsBigger ? second : first;
			IList<T> huge = firstIsBigger ? first : second;

			List<T> common = new List<T>();

			int index;
			for(int i = 0; i < small.Count; i++)
			{
				if(i != 0 && comparer.Compare(small[i], small[i - 1]) == 0)
					continue;

				index = huge.DoBinarySearch(small[i], comparer);
				if(index >= 0)
					common.Add(small[i]);
			}

			return common;
		}

		/// <summary>
		/// Intersect ordered collections. Best for n = m. Result array will be wihout duplicates. Time: O(n + m)
		/// </summary>
		public static List<T> IntersectOrdered3<T>(this IList<T> first, IList<T> second, Comparer<T> comparer)
		{
			List<T> common = new List<T>();
			int i = 0, j = 0;

			while(i < first.Count && j < second.Count)
			{
				int comparision = comparer.Compare(first[i], second[j]);

				if((i == 0 || comparer.Compare(first[i], first[i - 1]) != 0) && comparision == 0)
				{
					common.Add(first[i]);
					i++;
					j++;
				}
				else if(comparision == 1)
				{
					j++;
				}
				else
				{
					i++;
				}
			}

			return common;
		}
	}
}

