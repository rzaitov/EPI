using System;
using System.Collections.Generic;

namespace ArrayPartition
{
	public static class ArrayHelper
	{
		/// <summary>
		/// bottom: [0: smaller-1]
		/// middle: [smaller: equal-1]
		/// unclassified: [equal: bigger]
		/// top: [bigger+1: len-1]
		/// </summary>
		public static void Rearrange<T>(this T[] array, int pivotIndex, IComparer<T> comparer)
		{
			int smaller = 0;
			int equal = 0;
			int bigger = array.Length - 1;

			T pivot = array[pivotIndex];

			while(equal <= bigger)
			{
				int comparision = comparer.Compare(array[equal], pivot);
				switch(comparision)
				{
					case -1:
						Swap(array, smaller++, equal++);
						break;

					case 1:
						Swap(array, equal, bigger--);
						break;

					case 0:
						equal++;
						break;

					default:
						throw new InvalidOperationException();
				}
			}
		}

		public static void Swap<T>(this T[] array, int index1, int index2)
		{
			T tmp = array[index1];
			array[index1] = array[index2];
			array[index2] = tmp;
		}
	}
}

