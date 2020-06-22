using System.Collections.Generic;
using data_structures_and_algorithms.Trees;

namespace data_structures_and_algorithms.Algorithms.Searching
{
    public static partial class Searching
    {
        public static BNode<int> BreadFirstSearch(this BinaryTree tree, int value)
        {
            var node = tree.Head;
            var queue = new Queue<BNode<int>>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var tempNode = queue.Dequeue();

                if (tempNode.Value == value) return tempNode;

                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                }
                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                }
            }

            return null;
        }

        public static BNode<int> BreadFirstSearchRecursive(this BinaryTree tree, int searchedValue)
        {
            //this is to generate the first element in the queue and then go recursive,
            var node = tree.Head;
            var queue = new Queue<BNode<int>>();
            queue.Enqueue(node);
            return BreadFirstSearchRecursive(searchedValue, queue);
        }

        private static BNode<int> BreadFirstSearchRecursive(int searchedValue, Queue<BNode<int>> queue)
        {
            if (queue?.Count != 0)
            {
                var tempNode = queue.Dequeue();

                if (tempNode.Value == searchedValue) return tempNode;

                if (tempNode.Right != null)
                {
                    queue.Enqueue(tempNode.Right);
                }
                if (tempNode.Left != null)
                {
                    queue.Enqueue(tempNode.Left);
                }

                return BreadFirstSearchRecursive(searchedValue, queue);
            }

            return null;
        }

        public static BNode<int> BreadFirstSearchRecursive2(this BinaryTree tree, int searchedValue)
        {

            var node = tree.Head;
            var queue = new Queue<BNode<int>>();
            queue.Enqueue(node);

            return IterateQueue();

            BNode<int> IterateQueue()
            {
                if (queue?.Count != 0)
                {
                    var tempNode = queue.Dequeue();

                    if (tempNode.Value == searchedValue) return tempNode;

                    if (tempNode.Right != null)
                    {
                        queue.Enqueue(tempNode.Right);
                    }
                    if (tempNode.Left != null)
                    {
                        queue.Enqueue(tempNode.Left);
                    }

                    return IterateQueue();
                }
                return null;
            }
        }
    }
}