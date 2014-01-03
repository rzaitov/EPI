using System;
using StrBn = MorisTraversal.BinaryNode<string>;

namespace MorisTraversal
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			StrBn c = new StrBn { Data = "C" };
			StrBn e = new StrBn { Data = "E" };
			StrBn d = new StrBn { Data = "D", Left = c, Right = e };

			StrBn a = new StrBn { Data = "A" };
			StrBn b = new StrBn { Data = "B", Left = a, Right = d };

			StrBn h = new StrBn { Data = "H" };
			StrBn i = new StrBn { Data = "I", Left = h };

			StrBn g = new StrBn { Data = "G", Right = i };
			StrBn f = new StrBn { Data = "F", Left = b, Right = g };

			StrBn.MorisInorderTraversal(f, n => Console.Write(string.Format("{0} ", n.Data)));
		}
	}
}
