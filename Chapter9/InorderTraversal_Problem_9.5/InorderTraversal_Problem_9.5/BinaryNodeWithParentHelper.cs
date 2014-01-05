using System;

namespace BinaryTree
{
	public static class BinaryNodeWithParentHelper
	{
		public static BinaryNodeWithParent<T> Left<T>(this BinaryNodeWithParent<T> parent, T leftChildData)
		{
			BinaryNodeWithParent<T> lChild = new BinaryNodeWithParent<T> { Data = leftChildData };
			return Left(parent, lChild);
		}

		public static BinaryNodeWithParent<T> Left<T>(this BinaryNodeWithParent<T> parent, BinaryNodeWithParent<T> lChild)
		{
			lChild.Parent = parent;
			parent.Left = lChild;
			return parent;
		}

		public static BinaryNodeWithParent<T> Right<T>(this BinaryNodeWithParent<T> parent, T rightChildData)
		{
			BinaryNodeWithParent<T> rChild = new BinaryNodeWithParent<T> { Data = rightChildData };
			return Right(parent, rChild);
		}

		public static BinaryNodeWithParent<T> Right<T>(this BinaryNodeWithParent<T> parent, BinaryNodeWithParent<T> rChild)
		{
			rChild.Parent = parent;
			parent.Right = rChild;
			return parent;
		}
	}
}

