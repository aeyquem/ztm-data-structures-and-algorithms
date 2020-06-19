using System;
using System.Collections.Generic;
using data_structures_and_algorithms.LinkedLists;

namespace data_structures_and_algorithms.StacksAndQueues
{
    //NOT WORKING
    public class QueueS<T>
    {
        public Stack<T> Items { get; set; }

        public QueueS()
        {
            Items = new Stack<T>();
        }

        public QueueS(T value) : this()
        {
            Enqueue(value);
        }

        public void Enqueue(T value)
        {
            var tempStack = new Stack<T>();
            tempStack.Push(value);
            while (Items.Count != 0)
            {
                tempStack.Push(Items.Pop());
            }
            Items = tempStack;
        }

        public T Dequeue()
        {
            var tempStack = new Stack<T>();
            while (Items.Count != 0)
            {
                tempStack.Push(Items.Pop());
            }
            Items = tempStack;
            return Items.Pop();
        }

        public T Peek()
        {
            return Items.Peek();
        }
    }
}