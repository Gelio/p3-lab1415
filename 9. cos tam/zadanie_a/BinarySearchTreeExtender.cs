using System;
using System.Collections.Generic;

namespace PO_BST
{
    static class BinarySearchTreeExtender
    {
        static public IEnumerable<TNode> InOrder<TNode>(this BinarySearchTree<TNode> tree) where TNode : IComparable<TNode>, IEquatable<TNode>
        {
            if (tree == null)
                yield break;

            if (tree.Left != null)
            {
                foreach (var element in tree.Left.InOrder())
                    yield return element;
            }
            
            yield return tree.Value;

            if (tree.Right != null)
            {
                foreach (var element in tree.Right.InOrder())
                    yield return element;
            }
        }

        static public void Write<TNode>(this BinarySearchTree<TNode> tree) where TNode : IComparable<TNode>, IEquatable<TNode>
        {
            foreach (var element in tree.InOrder())
                Console.Write(element + " ");
            Console.WriteLine(String.Empty);
        }
        static public BinarySearchTree<TNode> Search<TNode>(this BinarySearchTree<TNode> tree, TNode value) where TNode : IComparable<TNode>, IEquatable<TNode>
        {
            if (tree == null)
                return null;

            int comparisonResult = value.CompareTo(tree.Value);
            if (comparisonResult == 0)
                return tree;
            else if (comparisonResult < 0)
                return tree.Left.Search(value);
            else
                return tree.Right.Search(value);
        }

        static public int NumberOfLeaves<TNode>(this BinarySearchTree<TNode> tree) where TNode : IComparable<TNode>, IEquatable<TNode>
        {
            if (tree == null)
                return 0;

            if (tree.Left == null && tree.Right == null)
                return 1;

            return tree.Left.NumberOfLeaves() + tree.Right.NumberOfLeaves();
        }
    }
}
