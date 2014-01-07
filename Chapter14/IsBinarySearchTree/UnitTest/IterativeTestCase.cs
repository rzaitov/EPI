using System;

using NUnit.Framework;

using BinaryTree;
using Bn = BinaryTree.BinaryNode<int>;

namespace UnitTest
{
	[TestFixture]
	public class IterativeTestCase : TestCaseBase
	{
		protected override bool CheckTree(Bn node)
		{
			return node.IsBinarySearchTree2(_comparer);
		}
	}
}

