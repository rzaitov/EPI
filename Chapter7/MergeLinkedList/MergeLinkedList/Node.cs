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
			Node<T> head = null;
			Node<T> tail = null;

			while(first != null && second != null)
			{
				bool isFirstBigger = comparer.Compare(first.Data, second.Data) == 1;
				if(isFirstBigger)
					AppendAndAdvance(ref second, ref head, ref tail);
				else
					AppendAndAdvance(ref first, ref head, ref tail);
			}

			if(first == null)
				AppendNode(second, ref head, ref tail);

			if(second == null)
				AppendNode(first, ref head, ref tail);

			return head;
		}

		private static void AppendNode(Node<T> nodeToAppend, ref Node<T> head, ref Node<T> tail)
		{
			if(head != null) // after first call tail != null
				tail.Next = nodeToAppend;
			else             // first method call
				head = nodeToAppend;

			tail = nodeToAppend;
		}

		private static void AppendAndAdvance(ref Node<T> nodeToAppend, ref Node<T> head, ref Node<T> tail)
		{
			AppendNode(nodeToAppend, ref head, ref tail);
			nodeToAppend = nodeToAppend.Next;
		}
	}
}

