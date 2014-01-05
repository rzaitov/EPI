using System;
using System.Collections;
using System.Collections.Generic;

namespace BinaryTree
{
	public class InorderIterator<T> : IEnumerator<BinaryNodeWithParent<T>>
	{
		private BinaryNodeWithParent<T> _root, _node, _prev, _next;
		private BinaryNodeWithParent<T> _current;

		public InorderIterator(BinaryNodeWithParent<T> root)
		{
			_root = root;
			Reset();
		}

		public bool MoveNext()
		{
			bool needToBreak = false;
			while(_node != null)
			{
				if(_prev == null || _prev.Left == _node || _prev.Right == _node) // go down
				{
					if(_node.Left != null)
					{
						_next = _node.Left;
					}
					else
					{
						_current = _node;
						_next = _node.Right ?? _node.Parent;
						needToBreak = true;
					}
				}
				else if(_node.Left == _prev)
				{
					_current = _node; // visit _cur
					_next = _node.Right ?? _node.Parent;
					needToBreak = true;
				}
				else
				{
					_next = _node.Parent;
				}

				_prev = _node;
				_node = _next;

				if(needToBreak)
					break;
			}

			return _node != null;
		}

		public void Reset()
		{
			_node = _root;
			_prev = _next = null;
		}

		public object Current
		{
			get
			{
				return _current;
			}
		}

		public void Dispose()
		{
			_root = _node = _prev = _next = null;
		}

		BinaryNodeWithParent<T> IEnumerator<BinaryNodeWithParent<T>>.Current
		{
			get
			{
				return _current;
			}
		}
	}
}

