using System;

namespace BinaryTree
{
	public class BinaryNodeWithParent<T>
	{
		public T Data { get; set; }
		public BinaryNodeWithParent<T> Parent { get; set; }
		public BinaryNodeWithParent<T> Left { get; set; }
		public BinaryNodeWithParent<T> Right { get; set; }

		public BinaryNodeWithParent()
			: this(default(T))
		{
		}

		public BinaryNodeWithParent(T data)
		{
			Data = data;
		}

		public static void Inorder(BinaryNodeWithParent<T> node, Action<BinaryNodeWithParent<T>> visit)
		{
			BinaryNodeWithParent<T> prev = null, next = null;

			while(node != null)
			{
				if(prev == null || prev.Left == node || prev.Right == node) // go down
				{
					if(node.Left != null)
					{
						next = node.Left;
					}
					else
					{
						visit(node);
						next = node.Right ?? node.Parent;
					}
				}
				else if(node.Left == prev)
				{
					visit(node);
					next = node.Right ?? node.Parent;
				}
				else
				{
					next = node.Parent;
				}

				prev = node;
				node = next;
			}
		}
	}
}

