using System;
using System.Collections.Generic;

namespace StackWithMaxOperation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			StackWithMaxOperation<int> stack = new StackWithMaxOperation<int>(Comparer<int>.Default, 10);
			Push(new int[] { 1, 4, 3, 2, 5, 6, 9, 7, 8, 10 }, stack);

		}

		private static void Push(int[] numbers, StackWithMaxOperation<int> stack)
		{
			for(int i = 0; i < numbers.Length; i++)
			{
				int elem = numbers[i]; 
				stack.Push(elem);
				Console.WriteLine(string.Format("num: {0}, max: {1}", elem, stack.Max()));
			}

			while(!stack.IsEmpty())
			{
				int elem = stack.Pop();
				if(stack.IsEmpty())
					break;
				Console.WriteLine(string.Format("poped: {0}, cur max: {1}", elem, stack.Max()));

			}
		}
	}
}
