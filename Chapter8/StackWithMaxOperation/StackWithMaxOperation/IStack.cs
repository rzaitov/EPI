using System;
using System.Collections.Generic;

namespace StackWithMaxOperation
{
	public interface IStack<T>
	{
		void Push(T element);
		T Pop();
		T Peak();
		bool IsEmpty();
	}
}

