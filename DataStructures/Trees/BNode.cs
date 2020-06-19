namespace data_structures_and_algorithms.Trees
{
    public class BNode<T>
    {
        public T Value { get; set; }
        public BNode<T> Left { get; set; }
        public BNode<T> Right { get; set; }

        public BNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}