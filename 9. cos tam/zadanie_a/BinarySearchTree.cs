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
            int comparisonResult = value.CompareTo(_value);
            if (comparisonResult == 0)
                return this;

            if (comparisonResult < 0)
            {
                // value < _value
                if (_left == null)
                    return new BinarySearchTree<TNode>(Value, SingleNode(value), Right);
                return new BinarySearchTree<TNode>(Value, _left.Add(value), Right);
            }
            else
            {
                // value > _value
                if (_right == null)
                    return new BinarySearchTree<TNode>(Value, Left, SingleNode(value));
                return new BinarySearchTree<TNode>(Value, Left, _right.Add(value));
            }
		}

		public BinarySearchTree<TNode> RemoveSubTree(TNode value)
		{
			int comparisonResult = value.CompareTo(_value);
            if (comparisonResult == 0)
                return null;
            
            if (comparisonResult < 0)
            {
                if (_left == null)
                    return this;

                if (_left.Value.CompareTo(value) == 0)
                    return new BinarySearchTree<TNode>(Value, null, Right);

                return new BinarySearchTree<TNode>(Value, _left.RemoveSubTree(value), Right);
            }
            else
            {
                if (_right == null)
                    return this;

                if (_right.Value.CompareTo(value) == 0)
                    return new BinarySearchTree<TNode>(Value, Left, null);

                return new BinarySearchTree<TNode>(Value, Left, _right.RemoveSubTree(value));
            }
		}

	}
}
