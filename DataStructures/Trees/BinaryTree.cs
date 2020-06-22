using System;
using System.Collections.Generic;

namespace data_structures_and_algorithms.Trees
{
    public class BinaryTree
    {
        public BNode<int> Head { get; set; }

        public BinaryTree()
        {
            Head = null;
        }

        public BinaryTree(int value)
        {
            Insert(value);
        }

        public void Insert(int value)
        {
            var newNode = new BNode<int>(value);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var tempHead = Head;
            while (tempHead != null)
            {
                if (tempHead.Value > value)
                {
                    if (tempHead.Left == null)
                    {
                        tempHead.Left = newNode;
                        return;
                    }
                    tempHead = tempHead.Left;
                }
                else if (tempHead.Value < value)
                {
                    if (tempHead.Right == null)
                    {
                        tempHead.Right = newNode;
                        return;
                    }
                    tempHead = tempHead.Right;
                }
                else return;
            }
        }

        public BNode<int> Lookup(int value)
        {
            var tempHead = Head;
            while (tempHead != null)
            {
                if (tempHead.Value > value)
                {
                    tempHead = tempHead.Left;
                }
                else if (tempHead.Value < value)
                {
                    tempHead = tempHead.Right;
                }

                else return tempHead;
            }
            return null;
        }

        //only right half implemented, second part shoud be the same but inverting sides
        public void Remove(int value)
        {
            if (Head == null)
            {
                return;
            }
            //look for de node keeping a reference to it's previous node
            var nodeToRemove = Head;
            var nodeToRemoveParent = Head;
            while (nodeToRemove != null)
            {
                if (nodeToRemove.Value > value)
                {
                    nodeToRemoveParent = nodeToRemove;
                    nodeToRemove = nodeToRemove.Left;
                }
                else if (nodeToRemove.Value < value)
                {
                    nodeToRemoveParent = nodeToRemove;
                    nodeToRemove = nodeToRemove.Right;

                }
                else
                {
                    break;
                }
            }
            //once found, look for its successor
            //go to the righ first, then as far as you can to the left
            var successor = nodeToRemove;
            var successorParent = successor;
            if (successor.Right != null)
            {
                successor = successor.Right;
                while (successor.Left != null)
                {
                    successorParent = successor;
                    successor = successor.Left;
                }

                //reasing the pointers
                if (nodeToRemove == Head)
                {
                    Head = successor;
                }
                else
                {
                    nodeToRemoveParent.Right = successor;
                }
                successorParent.Left = successor.Right;
                successor.Left = nodeToRemove.Left;
                successor.Right = nodeToRemove.Right;
            }
            //if there's no right, go the left and the as far right as possible
            else if (successor.Left != null)
            {
                successor = successor.Left;
                while (successor.Right != null)
                {
                    successor = successor.Right;
                }
            }
            else
            {
                successor = null;
            }
        }
    }
}