using System;
using System.Collections.Generic;

using Heap;

namespace UnionOrderedFile
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] source = new int[] { 11, 5, 8, 3, 4, 15 };
			BinaryHeap<int> maxHeap = new BinaryMaxHeap<int>(6, Comparer<int>.Default);
			BinaryHeap<int> minHeap = new BinaryMinHeap<int>(6, Comparer<int>.Default);


			for(int i = 0; i < source.Length; i++)
			{
				maxHeap.Add(source[i]);
				minHeap.Add(source[i]);
			}

			Console.Write("Max-heap: ");
			PrintHeap(maxHeap);
			Console.WriteLine();

			Console.Write("Min-heap: ");
			PrintHeap(minHeap);
			Console.WriteLine();

			while(!maxHeap.IsEmpty())
			{
				int max = maxHeap.Delete();
				Console.Write(string.Format("deleted: {0} Remained: ", max));
				PrintHeap(maxHeap);
				Console.WriteLine();
			}

			while(!minHeap.IsEmpty())
			{
				int min = minHeap.Delete();
				Console.Write(string.Format("deleted: {0} Remained: ", min));
				PrintHeap(minHeap);
				Console.WriteLine();
			}
		}

		private static void PrintHeap<T>(BinaryHeap<T> heap)
		{
			foreach(T element in heap.HeapElements)
			{
				Console.Write(string.Format("{0} ", element));
			}
		}
	}
}
