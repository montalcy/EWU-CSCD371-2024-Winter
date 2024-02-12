namespace GenericsHomework
{
    public class Node<T>
    {
        private T _value;
        private Node<T>? next;

        public Node(T value)
        {
            _value = value;
            this.next = null;
        }
        public override string ToString() => _value.ToString();

        public Node<T> Next
        {
            get { return next ?? this; }
            private set { next = value; }
        }
    }
}
