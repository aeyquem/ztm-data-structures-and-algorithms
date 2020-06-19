using System;

namespace data_structures_and_algorithms.LinkedLists
{
    public class LinkedList<T>
    {
        Node<T> Head { get; set; }
        Node<T> Tail { get; set; }
        int Length { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }

        public LinkedList(T value)
        {
            Append(value);
        }

        public void Append(T value)
        {
            var newNode = new Node<T>(value);
            if (Length == 0)
            {
                Head = newNode;
                Tail = Head;
            }
            else
            {
                Tail.Next = newNode;
                Tail = Tail.Next;
            }
            Length++;
        }

        public void Prepend(T value)
        {
            var newHead = new Node<T>(value);
            newHead.Next = Head;
            Head = newHead;
            Length++;
        }

        public void Insert(T value, int index = 0)
        {
            if (index == 0)
            {
                Prepend(value);
            }
            else if (index >= Length)
            {
                Append(value);
            }
            else
            {
                var currentNode = Traverse(index - 1);
                var newNode = new Node<T>(value);
                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
                Length++;
            }
        }

        public void Remove(int index)
        {
            if (index >= Length)
            {
                return;
            }
            if (index == 0)
            {
                Head = Head.Next;
            }
            else
            {
                var previousNode = Traverse(index - 1);
                if (previousNode.Next == Tail)
                {
                    Tail = previousNode;
                }
                previousNode.Next = previousNode.Next.Next;
                Length--;
            }
        }

        public void Reverse()
        {
            if (Length < 2)
            {
                return;
            }

            Tail = Head;
            var second = Head.Next;
            Head.Next = null;

            while (second != null)
            {
                var temp = second.Next;
                second.Next = Head;
                Head = second;
                second = temp;
            }
        }

        private Node<T> Traverse(int index)
        {
            var currentNode = Head;
            for (int i = 0; i < index; i++)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        public void PrintList()
        {
            var currentNode = Head;
            int i = 0;
            while (currentNode != null)
            {
                System.Console.WriteLine(i + ":" + currentNode.Value.ToString());
                currentNode = currentNode.Next;
                i++;
            }
            System.Console.WriteLine("Head: " + Head.Value);
            System.Console.WriteLine("Tail: " + Tail.Value);
        }
    }
}