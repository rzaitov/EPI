using System;
using System.Collections.Generic;

namespace MergeLinkedList
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Node<int> first = FetchFirst();
			Node<int> second = FetchSecond();

			Node<int> union = Node<int>.Merge(first, second, Comparer<int>.Default);
			do
			{
				Console.Write(string.Format("{0} ", union.Data));
				union = union.Next;
			}
			while(union != null);
		}

		private static Node<int> FetchFirst()
		{
			Node<int> head = new Node<int> { Data = 2 };
			head.AppendNew(5).AppendNew(7);

			return head;
		}

		private static Node<int> FetchSecond()
		{
			Node<int> head = new Node<int> { Data = 3 };
			head.AppendNew(11).AppendNew(20);

			return head;
		}
	}
}
