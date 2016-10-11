using System;

namespace PO_BST
{
	public class BinarySearchTree<TNode> where TNode : IComparable<TNode>, IEquatable<TNode>
	{
		public static int Counter { get; private set; }
		private readonly TNode _value;
		private readonly BinarySearchTree<TNode> _right;
		private readonly BinarySearchTree<TNode> _left;

		private BinarySearchTree(TNode value, BinarySearchTree<TNode> left, BinarySearchTree<TNode> right)
		{
			Counter++;
			_value = value;
			_right = right;
			_left = left;
		}

		public static BinarySearchTree<TNode> SingleNode(TNode value)
		{
			return new BinarySearchTree<TNode>(value, null, null);
		}

		public TNode Value { get { return _value; } }

		public BinarySearchTree<TNode> Right { get { return _right; } }

		public BinarySearchTree<TNode> Left { get { return _left; } }

		public BinarySearchTree<TNode> Add(TNode value)
		{
			throw new NotImplementedException();
		}

		public BinarySearchTree<TNode> RemoveSubTree(TNode value)
		{
			throw new NotImplementedException();
		}

	}
}
