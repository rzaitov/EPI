using System;

namespace MorisTraversal
{
	public class BinaryNode<T>
	{
		public T Data { get; set; }
		public BinaryNode<T> Left { get; set; }
		public BinaryNode<T> Right { get; set; }

		public BinaryNode()
			: this(default(T))
		{
		}

		public BinaryNode(T data)
		{
			Data = data;
		}

	}
}

