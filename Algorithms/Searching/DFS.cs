using System.Collections.Generic;
using data_structures_and_algorithms.Trees;

namespace data_structures_and_algorithms.Algorithms.Searching
{
    public static partial class Searching
    {
        public static void DFSInOrder(this BinaryTree tree)
        {
            var list = new List<int>();

            TraverseInOrder(tree.Head);

            void TraverseInOrder(BNode<int> node)
            {
                if (node.Left != null)
                {
                    TraverseInOrder(node.Left);
                }
                list.Add(node.Value);
                if (node.Right != null)
                {
                    TraverseInOrder(node.Right);
                }
            }
        }

        public static void DFSPostOrder(this BinaryTree tree)
        {
            var list = new List<int>();

            TraversePostOrder(tree.Head);

            void TraversePostOrder(BNode<int> node)
            {
                if (node.Left != null)
                {
                    TraversePostOrder(node.Left);
                }
                if (node.Right != null)
                {
                    TraversePostOrder(node.Right);
                }
                list.Add(node.Value);
            }
        }

        public static void DFSPreOrder(this BinaryTree tree)
        {
            var list = new List<int>();

            TraversePreOrder(tree.Head);

            void TraversePreOrder(BNode<int> node)
            {
                list.Add(node.Value);
                if (node.Left != null)
                {
                    TraversePreOrder(node.Left);
                }
                if (node.Right != null)
                {
                    TraversePreOrder(node.Right);
                }
            }
        }
    }
}