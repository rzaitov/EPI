using System;
using System.Collections.Generic;

using NUnit.Framework;

using BinaryTree;
using Bn = BinaryTree.BinaryNode<int>;

namespace UnitTest
{
	public abstract class TestCaseBase
	{
		protected BinaryNode<int> _bst;
		protected BinaryNode<int> _notBst;
		protected Comparer<int> _comparer;

		[SetUp]
		public void SetUp()
		{
			_bst = CreateBst();
			_notBst = CreateNotBst();
			_comparer = Comparer<int>.Default;
		}

		private BinaryNode<int> CreateBst()
		{
			Bn l = new Bn(5).Left(4).Right(5);
			Bn r = new Bn(20).Left(15).Right(30);

			Bn root = new Bn(10).Left(l).Right(r);
			return root; 
		}

		private BinaryNode<int> CreateNotBst()
		{
			Bn l = new Bn(5).Left(4).Right(5);
			Bn r = new Bn(20).Left(9).Right(30);

			Bn root = new Bn(10).Left(l).Right(r);
			return root; 
		}

		[Test]
		public void CheckBst()
		{
			bool isBst = CheckTree(_bst);
			Assert.IsTrue(isBst);
		}

		[Test]
		public void CheckNotBst()
		{
			bool isBst = CheckTree(_notBst);
			Assert.IsFalse(isBst);
		}

		protected abstract bool CheckTree(Bn node);
	}
}

