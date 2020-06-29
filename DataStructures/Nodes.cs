namespace data_structures_and_algorithms
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            this.Value = value;
            Next = null;
        }
    }

    public class DNode<T>
    {
        public T Value { get; set; }
        public DNode<T> Next { get; set; }
        public DNode<T> Previous { get; set; }

        public DNode(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}