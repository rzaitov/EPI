using System;
using System.Collections;
using System.Collections.Generic;

using BinaryTree;

namespace MorisTraversal
{
	public class MorisIterator<T> : IEnumerator<BinaryNode<T>>
	{
		private BinaryNode<T> _start;
		private BinaryNode<T> _node;
		private BinaryNode<T> _current;

		public MorisIterator(BinaryNode<T> node)
		{
			_start = node;
			Reset();
		}

		public bool MoveNext()
		{
			bool hasNext = _node != null;

			while(hasNext)
			{
				if(_node.Left != null)
				{
					BinaryNode<T> p = _node.Left;

					while(p.Right != null && p.Right != _node)
						p = p.Right;

					if(p.Right != null)
					{
						_current = _node;
						p.Right = null;
						_node = _node.Right;

						break;
					}
					else
					{
						p.Right = _node;
						_node = _node.Left;
					}
				}
				else
				{
					_current = _node;
					_node = _node.Right;

					break;
				}
			}

			return hasNext;
		}

		public void Reset()
		{
			_node = _start;
		}

		public object Current
		{
			get { return _current; }
		}

		public void Dispose()
		{
			_start = null;
			_node = null;
			_current = null;
		}

		BinaryNode<T> IEnumerator<BinaryNode<T>>.Current
		{
			get { return _current; }
		}
	}
}

