using System;

using NUnit.Framework;

using BinaryTree;
using Bn = BinaryTree.BinaryNode<int>;

namespace UnitTest
{
	[TestFixture]
	public class RecursiveTestCase : TestCaseBase
	{
		protected override bool CheckTree(BinaryNode<int> node)
		{
			return node.IsBinarySearchTree1(_comparer);
		}
	}
}

