//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericsHomework
{
    public class Node<T>
    {
        private T _value { get; set; }
        private Node<T> Next {  get; set; }
        public int Size;
        private Node<T> Head { get; set; }

        public Node(T value)
        {
            _value = value;
            if (Size == 1) { Next = Head; }
            else { Next = this; };
        }

        public T GetData()
        {
            return _value;
        }

        override public string ToString()
        {
            Node<T> current = Head;
            string list = "";
            while (current.Next != Head)
            {
                list += current.GetData();
            }

            return "Your linked list: " + list;
        }

        public void Clear()
        {
            if (this.Next != null)
            {
                this.Next = null;
            }
        }


        public void RemoveAll()
        {
            Node<T> curr = Head;
            Node<T> prev;
            while (curr.Next.Next != Head)
            {
                prev = curr;
                curr.Next = curr.Next.Next;
                curr = curr.Next;
            }
            curr.Next = curr.Next.Next;
        }




        public void Append(T value)
        {
            Node<T> curr = Head;
            Node<T> addition = new Node<T>(value);

            if (Exists(value))
            {
                throw new ArgumentException("This already exists in the list");
            }

            if (Head.Next == Head)
            {
                Head = addition;
                Size = 1;
            }
            else
            {
                while (Next != Head)
                {
                    curr = curr.Next;
                }
                curr.Next = addition;
                Size++;
            }

        }

        public bool Exists(T data)
        {
            Node<T> curr = Head;
            while (curr != Head)
            {
                if (curr._value.Equals(data))
                {
                    return true;
                }
                curr = curr.Next;
            }
            return false;
        }
    }
}
