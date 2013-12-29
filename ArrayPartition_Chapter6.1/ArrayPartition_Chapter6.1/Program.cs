using System;
using System.Collections.Generic;

namespace ArrayPartition
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] arr = new int[] { 10, 15, 5, 20, 1, 13, 40, 7, 4, 21 };
			arr.Rearrange(5, Comparer<int>.Default);

			foreach(int i in arr)
			{
				Console.Write("{0} ", i);
			}
		}
	}
}
