namespace GenericsHomework
{
    public class Node<T>
    {
        private T _value { get; set; }
        private Node<T>? Next {  get; set; }
        private Node<T> Head { get { return this; } set { Head = this; } }

        public Node(T value)
        {
            _value = value;
            this.Next = null;
        }
        public override string ToString() => _value.ToString();

        public Node<T> Next
        {
            get { return Next ?? this; }
            private set { Next = value; }
        }

        public void Clear()
        {
            if (this.Next != null)
            {
                this.Next = null;
            }
        }

        public void Append(T value)
        {

        }
        private bool doesExists(T? value) // will be using it when appending
        {

            return false;
        }
    }
}
