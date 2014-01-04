using System;
using StrBn = MorisTraversal.BinaryNode<string>;

namespace MorisTraversal
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			StrBn d = new StrBn("D").Left("C").Right("E");
			StrBn b = new StrBn("B").Left("A").Right(d);

			StrBn i = new StrBn("I").Left("H");
			StrBn g = new StrBn("G").Right(i);

			StrBn f = new StrBn("F").Left(b).Right(g);

			MorisIterator<string> iterator = new MorisIterator<string>(f);
			while(iterator.MoveNext())
			{
				Console.Write(string.Format("{0} ", ((StrBn)iterator.Current).Data));
			}
		}
	}
}
