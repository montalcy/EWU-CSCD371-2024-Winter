//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericsHomework;

public class Node<T>
{
    private T Value { get; set; }
    public Node<T>? Next { get; private set; }
    public int Size { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = this;
        Size = 1;
    }

    public T GetData()
    {
        return Value;
    }

    override public string ToString() => Value?.ToString() ?? throw new ArgumentNullException(nameof(Value));

    public void Clear()
    {
        //if (this.next != null)
        //{
        //    this.next = null;
        //}
    }


    public void Append(T data)
    {
        Node<T>? curr = Head;
        Node<T> addition = new(data);

        if (Exists(data))
        {
            throw new ArgumentException("This already exists in the list");
        }
        else
        {
            if (Head!.next! == Head)
            {
                Head = addition;
                Size = 1;
            }
            else
            {
                while (next != Head)
                {
                    curr = curr!.next!;
                }
                curr!.next = addition;
                Size++;
                addition.next = Head;
            }
        }



    }

    public bool Exists(T data)
    {
        Node<T>? curr = Head;
        while (curr != Head)
        {
            if (curr!._value!.Equals(data))
            {
                return true;
            }
            curr = curr!.next!;
        }
        return false;
    }
}

