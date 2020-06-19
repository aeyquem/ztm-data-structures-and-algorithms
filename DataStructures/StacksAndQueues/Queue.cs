using data_structures_and_algorithms.LinkedLists;

namespace data_structures_and_algorithms.StacksAndQueues
{
    public class Queue<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        public int Length { get; set; }

        public Queue()
        {
            Length = 0;
            First = null;
            Last = null;
        }

        public Queue(T value) : this()
        {
            Enqueue(value);
        }

        public void Enqueue(T value)
        {
            var newNode = new Node<T>(value);
            if (Length == 0)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Length++;
        }

        public T Dequeue()
        {
            var node = First;
            First = First.Next;
            Length--;
            return node.Value;
        }

        public T Peek()
        {
            return First.Value;
        }


    }
}