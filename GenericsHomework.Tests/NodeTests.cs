using Xunit;

namespace GenericsHomework.Tests;
public class NodeTests
{
    [Fact]
    public void Append_NextToHead_Successful()
    {
        Node<Object> list=new Node<object>("IAmHead");
        Node<Object> node = new Node<object>("IamNextToHead");
        list.Append(node);
        Assert.Equal("Your linked list: IamHead IamNextToHead", list.ToString());
    }

    [Fact]
    public void True_one_two()
    {
        Assert.Equal("", "");
    }

}
