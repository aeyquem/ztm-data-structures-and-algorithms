namespace data_structures_and_algorithms.LinkedLists
{
    public class DoublyLinkedList<T>
    {
        public DNode<T> Head { get; set; }
        public DNode<T> Tail { get; set; }
        public int Length { get; set; }

        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }

        public DoublyLinkedList(T value)
        {
            Append(value);
        }

        public void Append(T value)
        {
            var newNode = new DNode<T>(value);
            if (Length == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
                Tail = Tail.Next;
            }
            Length++;
        }

        public void Prepend(T value)
        {
            var newNode = new DNode<T>(value);
            if (Length == 0)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
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
                var newNode = new DNode<T>(value);
                var currentNode = Traverse(index - 1);

                newNode.Next = currentNode.Next;
                newNode.Previous = currentNode;
                currentNode.Next = newNode;
                currentNode.Next.Previous = currentNode;
                Length++;
            }
        }

        public void Remove(int index)
        {
            if (index >= Length) return;

            var nodeToDelete = Traverse(index);
            if (nodeToDelete == Head)
            {
                Head.Next.Previous = null;
                Head = Head.Next;
            }
            else if (nodeToDelete == Tail)
            {
                Tail.Previous.Next = null;
                Tail = Tail.Previous;
            }
            else
            {
                nodeToDelete.Previous.Next = nodeToDelete.Next;
                nodeToDelete.Next.Previous = nodeToDelete.Previous;
            }
            Length--;
        }

        private DNode<T> Traverse(int index)
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