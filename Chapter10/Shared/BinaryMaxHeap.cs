using System;
using System.Collections.Generic;

namespace Heap
{
	public class BinaryMaxHeap<T> : BinaryHeap<T>
	{
		public BinaryMaxHeap(int capacity, IComparer<T> comparer)
			: base(capacity, comparer)
		{
		}

		/// <returns>if x => y return true; if x < y return false</returns>
		protected override bool IsRelationSucceed(T x, T y)
		{
			// relation: x => y
			return Comparer.Compare(x, y) != -1;
		}
	}
}

