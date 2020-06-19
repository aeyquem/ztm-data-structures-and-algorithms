
using System;
using data_structures_and_algorithms.LinkedLists;

namespace data_structures_and_algorithms.StacksAndQueues
{
    public class StackLL<T>
    {
        public Node<T> Top { get; private set; }
        public Node<T> Bottom { get; private set; }
        public int Length { get; set; }

        public StackLL()
        {
            Top = null;
            Length = 0;
        }

        public StackLL(T value)
        {
            Length = 0;
            Push(value);
        }

        public void Push(T value)
        {
            var newNode = new Node<T>(value);
            if (Length == 0)
            {
                Top = newNode;
                Bottom = newNode;
            }
            else
            {
                newNode.Next = Top;
                Top = newNode;
            }
            Length++;
        }

        public T Pop()
        {
            var node = Top;
            Top = Top.Next;
            Length--;
            return node.Value;
        }

        public T Peek()
        {
            return Top.Value;
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}