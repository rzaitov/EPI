using System;

using BinaryTree;
using StrBn = BinaryTree.BinaryNodeWithParent<string>;

namespace InorderTraversal
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

			// Expected A B C D E F G H I 
			StrBn.Inorder(f, n => Console.Write(string.Format("{0} ", n.Data)));

			Console.WriteLine();

			var iterator = new InorderIterator<string>(f);
			while(iterator.MoveNext())
			{
				Console.Write(string.Format("{0} ", ((StrBn)iterator.Current).Data));
			}

		}
	}
}
