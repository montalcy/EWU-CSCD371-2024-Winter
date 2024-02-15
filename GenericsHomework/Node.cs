//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericsHomework;

public class Node<T>
{
    private T Value { get; set; }
    public Node<T> Next { get; private set; }
    public int Size { get; set; }

    public Node(T value)
    {
        Value = value;
        Next = this;   
    }

    public T GetData()
    {
        return Value;
    }

    override public string ToString() => Value?.ToString() ?? throw new ArgumentNullException(nameof(Value));

    public void Clear()
    {
        Next = this;
        Size = 1;
    }


    public void Append(T data)
    {
        Node<T> addition = new(data);

        if (Exists(data))
        {
            throw new ArgumentException($"{data} already exists");
        }

        addition.Next = this.Next;
        Next = addition;
        Size++;
        }



    public bool Exists(T data)
    {
        Node<T> curr = this;
        if(curr.Value!.Equals(data))
            return true;
        curr = curr.Next;
        while (curr!=this)
        {
            if (curr.Value!.Equals(data))
            {
                return true;
            }
            curr = curr.Next;
        }
        return false;
    }
}

