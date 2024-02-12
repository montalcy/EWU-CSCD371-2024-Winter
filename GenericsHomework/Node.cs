//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericsHomework;

public class Node<T>
{
    private T _value { get; set; }
    private Node<T> next { get; set; }
    public int Size;
    private Node<T> Head { get; set; }

    public Node(T value)
    {
        _value = value;
        if (Size == 1) { next = Head; }
        else { next = this; };
    }

    public T GetData()
    {
        return _value;
    }

    override public string ToString()
    {
        Node<T> current = Head;
        string list = "";
        while (current.next != Head)
        {
            list += current.GetData();
        }

        return "Your linked list: " + list;
    }

    public void Clear()
    {
        if (this.next != null)
        {
            this.next = null;
        }
    }


    public void RemoveAll()
    {
        Node<T> curr = Head;
        Node<T> prev;
        while (curr.next.next != Head)
        {
            prev = curr;
            curr.next = curr.next.next;
            curr = curr.next;
        }
        curr.next = curr.next.next;
    }




    public void Append(T data)
    {
        Node<T> curr = Head;
        Node<T> addition = new Node<T>(data);

        if (Exists(data))
        {
            throw new ArgumentException("This already exists in the list");
        }

        if (Head.next == Head)
        {
            Head = addition;
            Size = 1;
        }
        else
        {
            while (next != Head)
            {
                curr = curr.next;
            }
            curr.next = addition;
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
            curr = curr.next;
        }
        return false;
    }
}

