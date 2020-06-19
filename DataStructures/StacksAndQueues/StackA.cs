using System.Collections.Generic;

namespace data_structures_and_algorithms.StacksAndQueues
{
    public class StackA<T>
    {
        public List<T> Items { get; private set; }
        public int Length { get { return Items.Count; } }

        public StackA()
        {
            Items = new List<T>();
        }

        public StackA(T value) : this()
        {
            Push(value);
        }

        public void Push(T value)
        {
            Items.Add(value);
        }

        public T Pop()
        {
            var lastItem = Items[Length - 1];
            Items.RemoveAt(Length - 1);
            return lastItem;
        }

        public T Peek()
        {
            return Items[Length - 1];
        }

        public bool IsEmpty()
        {
            return Length == 0;
        }
    }
}