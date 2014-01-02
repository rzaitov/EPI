using System;

namespace StackWithMaxOperation
{
	public class Stack<T> : IStack<T>
	{
		private T[] _storage;
		private Int32 _current;

		public Stack(Int32 capacity)
		{
			_storage = new T[capacity];
			_current = -1;
		}

		public void Push(T element)
		{
			VerifyIndex();
			_storage[++_current] = element;
		}

		public T Pop()
		{
			VerifyIndex();
			VerifyNotEmpty();

			return _storage[_current--];
		}

		public T Peak()
		{
			VerifyIndex();
			VerifyNotEmpty();

			return _storage[_current];
		}

		public bool IsEmpty()
		{
			VerifyIndex();

			return _current == -1;
		}

		private void IsIndexValid()
		{
			return _current >= -1 && _current < _storage.Length;
		}

		private void VerifyIndex()
		{
			if(!IsIndexValid())
				throw new InvalidOperationException();
		}

		private void VerifyNotEmpty()
		{
			if(!IsEmpty())
				throw new InvalidOperationException();
		}
	}
}