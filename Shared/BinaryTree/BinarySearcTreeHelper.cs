using System;
using System.Collections.Generic;

namespace BinaryTree
{
	public static class BinarySearchTreeHelper
	{
		class MinMax<T>
		{
			public bool IsMinValue { get; set; }
			public bool IsMaxValue { get; set; }
			public T Value { get; set; }

			public MinMax()
				: this(default(T))
			{
			}

			public MinMax(T data)
			{
				Value = data;
			}
		}

		/// <summary>
		/// Time: O(n) Space: O(h). Use recurrsion
		/// </summary>
		public static bool IsBinarySearchTree1<T>(this BinaryNode<T> node, Comparer<T> comparer)
		{
			MinMax<T> absMin = new MinMax<T> { IsMinValue = true };
			MinMax<T> absMax = new MinMax<T> { IsMaxValue = true };

			return IsBinarySearchTree1<T>(node, absMin, absMax, comparer);
		}

		private static bool IsBinarySearchTree1<T>(BinaryNode<T> node, MinMax<T> lower, MinMax<T> upper, Comparer<T> comparer)
		{
			if(node == null)
				return true;

			// data < lower
			if(!lower.IsMinValue && comparer.Compare(node.Data, lower.Value) == -1)
				return false;

			// data > upper
			if(!upper.IsMaxValue && comparer.Compare(upper.Value, node.Data) == -1)
				return false;

			return IsBinarySearchTree1(node.Left, lower, new MinMax<T>(node.Data), comparer) &&
			       IsBinarySearchTree1(node.Right, new MinMax<T>(node.Data), upper, comparer);
		}

		public static bool IsBinarySearchTree2<T>(this BinaryNode<T> node, Comparer<T> comparer)
		{
			BinaryNode<T> pre = null;
			bool result = true;
			MinMax<T> min = new MinMax<T> { IsMinValue = true };

			while(node != null)
			{
				if(node.Left != null)
				{
					pre = node.Left;

					while(pre.Right != null && pre.Right != node)
						pre = pre.Right;

					if(pre.Right != null)
					{
						result &= min.IsMinValue || comparer.Compare(node.Data, min.Value) != -1;

						min.Value = node.Data;
						min.IsMinValue = false;

						pre.Right = null;
						node = node.Right;
					}
					else
					{
						pre.Right = node;
						node = node.Left;
					}
				}
				else
				{
					result &= min.IsMinValue || comparer.Compare(node.Data, min.Value) != -1;

					min.Value = node.Data;
					min.IsMinValue = false;

					node = node.Right;
				}
			}

			return result;
		}
	}



}