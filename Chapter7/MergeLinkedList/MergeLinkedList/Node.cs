using System;
using System.Collections.Generic;

namespace MergeLinkedList
{
	public class Node<T>
	{
		public T Data { get; set; }
		public Node<T> Next { get; set; }

		public Node()
		{
		}

		public static Node<T> Merge(Node<T> first, Node<T> second, IComparer<T> comparer)
		{
			Node<T> head = Min(first, second, comparer);
			Node<T> curr = head;

			while(first != null || second != null)
			{
				first = curr == first ? first.Next : first;
				second = curr == second ? second.Next : second;

				curr.Next = Min(first, second, comparer);
				curr = curr.Next;
			}

			return head;
		}

		protected static Node<T> Min(Node<T> x, Node<T> y, IComparer<T> comparer)
		{
			if(x == null)
				return y;

			if(y == null)
				return x;

			int comparision = comparer.Compare(x.Data, y.Data);

			switch(comparision)
			{
				case 1:
					return y;

				case 0:
				case -1:
					return x;

				default:
					throw new InvalidOperationException();
			}

		}
	}
}

