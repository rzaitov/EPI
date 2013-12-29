using System;

namespace MergeLinkedList
{
	public static class NodeHelper
	{
		public static Node<T> AppendNew<T>(this Node<T> node, T data)
		{
			Node<T> next = new Node<T> { Data = data };
			node.Next = next;

			return next;
		}
	}
}

