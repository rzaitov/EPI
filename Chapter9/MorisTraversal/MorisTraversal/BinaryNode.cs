using System;

namespace MorisTraversal
{
	public class BinaryNode<T>
	{
		public T Data { get; set; }
		public BinaryNode<T> Left { get; set; }
		public BinaryNode<T> Right { get; set; }

		public BinaryNode()
		{
		}

		public static void MorisInorderTraversal(BinaryNode<T> node, Action<BinaryNode<T>> visit)
		{
			while(node != null)
			{
				if(node.Left != null)
				{
					BinaryNode<T> p = node.Left;

					while(p.Right != null && p.Right != node)
						p = p.Right;

					if(p.Right != null)
					{
						visit(node);
						p.Right = null;
						node = node.Right;
					}
					else
					{
						p.Right = node;
						node = node.Left;
					}
				}
				else
				{
					visit(node);
					node = node.Right;
				}
			}
		}
	}
}

