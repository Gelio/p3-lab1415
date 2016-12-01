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
    }
}
