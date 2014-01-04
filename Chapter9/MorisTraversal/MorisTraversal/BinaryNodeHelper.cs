using System;

namespace MorisTraversal
{
	public static class BinaryNodeHelper
	{
		public static BinaryNode<T> Left<T>(this BinaryNode<T> parent, T leftChildData)
		{
			BinaryNode<T> lChild = new BinaryNode<T> { Data = leftChildData };
			return Left(parent, lChild);
		}

		public static BinaryNode<T> Left<T>(this BinaryNode<T> parent, BinaryNode<T> lChild)
		{
			parent.Left = lChild;
			return parent;
		}

		public static BinaryNode<T> Right<T>(this BinaryNode<T> parent, T rightChildData)
		{
			BinaryNode<T> rChild = new BinaryNode<T> { Data = rightChildData };
			return Right(parent, rChild);
		}

		public static BinaryNode<T> Right<T>(this BinaryNode<T> parent, BinaryNode<T> rChild)
		{
			parent.Right = rChild;
			return parent;
		}

	}
}

