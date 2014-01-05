using System;
using System.Collections.Generic;
using System.Linq;

namespace Heap
{
	public abstract class BinaryHeap<T>
	{
		public int _capacity { get; private set; }
		protected int _heapSize { get; private set; }

		protected T[] _heapStorage;
		protected IComparer<T> Comparer { get; private set; }

		public IEnumerable<T> HeapElements
		{
			get { return _heapStorage.Take(_heapSize); }
		}

		public BinaryHeap(int capacity, IComparer<T> comparer)
		{
			_capacity = capacity;
			Comparer = comparer;

			_heapSize = 0;
			_heapStorage = new T[_capacity];
		}

		public void Add(T element)
		{
			VerifyState();

			int index = _heapSize++;
			_heapStorage[index] = element;

			while(index > 0)
			{
				int parentIndex = CalcParentIndex(index);
				T parentElement = _heapStorage[parentIndex];

				if(IsRelationSucceed(parentElement, element))
				{
					break;
				}
				else
				{
					Swap(parentIndex, index);
					index = parentIndex;
				}
			}
		}

		protected void Heapify(int i)
		{
			int left, rigth, largest = i;

			do
			{
				left = 2 * i + 1;
				rigth = 2 * i + 2;

				if(left < _heapSize && !IsRelationSucceed(_heapStorage[largest], _heapStorage[left]))
					largest = left;

				if(rigth < _heapSize && !IsRelationSucceed(_heapStorage[largest], _heapStorage[rigth]))
					largest = rigth;

				if(i == largest)
					break;

				Swap(i, largest);
				i = largest;
			}
			while(true);
		}

		/// <summary>
		/// For max-heap this must be x => y. For min-heap this must be x <= y 
		/// </summary>
		protected abstract bool IsRelationSucceed(T x, T y);

		public T Delete()
		{
			VerifyNotEmpty();

			T root = _heapStorage[0];
			_heapStorage[0] = _heapStorage[--_heapSize];

			Heapify(0);

			return root;
		}

		private void VerifyState()
		{
			if(_heapSize == _capacity)
				throw new InvalidOperationException();
		}

		private void VerifyNotEmpty()
		{
			if(IsEmpty())
				throw new InvalidOperationException();
		}

		public bool IsEmpty()
		{
			return _heapSize <= 0;
		}

		private int CalcParentIndex(int index)
		{
			return (index - (index % 2 == 0 ? 2 : 1)) / 2;
		}

		protected void Swap(int i, int j)
		{
			T tmp = _heapStorage[i];
			_heapStorage[i] = _heapStorage[j];
			_heapStorage[j] = tmp;
		}
	}
}

