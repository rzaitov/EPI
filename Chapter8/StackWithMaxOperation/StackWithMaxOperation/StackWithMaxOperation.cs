using System;
using System.Collections.Generic;

namespace StackWithMaxOperation
{
	public class StackWithMaxOperation<T> : IStack<T>
	{
		private IComparer<T> _comparer;
		private Stack<Tuple<T, T>> _inner;

		public StackWithMaxOperation(IComparer<T> comparer, int capacity)
		{
			_inner = new Stack<Tuple<T, T>>(capacity);
			_comparer = comparer;
		}

		public void Push(T element)
		{
			T max = element;
			if(!IsEmpty())
			{
				T prevMax = _inner.Peak().Item2;
				max = _comparer.Compare(element, prevMax) >= 0 ? element : prevMax;
			}

			_inner.Push(new Tuple<T, T>(element, max));
		}

		public T Pop()
		{
			return _inner.Pop().Item1;
		}

		public T Peak()
		{
			return _inner.Peak().Item1;
		}

		public bool IsEmpty()
		{
			return _inner.IsEmpty();
		}

		public T Max()
		{
			return _inner.Peak().Item2;
		}
	}
}

