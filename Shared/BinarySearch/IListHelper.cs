using System;
using System.Collections.Generic;

namespace BinarySearch
{
	public static class IListHelper
	{
		/// <summary>
		/// Return index of first occurence
		/// </summary>
		public static int DoBinarySearch<T>(this IList<T> array, T element, Comparer<T> comparer)
		{
			int middle, left = 0, right = array.Count - 1;
			int result = -1;

			while(left <= right)
			{
				middle = left + (right - left) / 2;
				int comparision = comparer.Compare(array[middle], element);

				switch(comparision)
				{
					case 1:
						right = middle - 1;
						break;

					case 0:
						result = middle;
						right = middle - 1;
						break;

					case -1:
						left = middle + 1;
						break;
				}
			}

			return result;
		}

		public static int FirstGreaterThan<T>(this IList<T> array, T element, Comparer<T> comparer)
		{
			int middle, left = 0, right = array.Count - 1;
			int result = -1;

			while(left <= right)
			{
				middle = left + (right - left) / 2;
				int comparision = comparer.Compare(array[middle], element);

				switch(comparision)
				{
					case 1:
						result = middle;
						right = middle - 1;
						break;

					case 0:
					case -1:
						left = middle + 1;
						break;
				}
			}

			return result;
		}
	}
}

