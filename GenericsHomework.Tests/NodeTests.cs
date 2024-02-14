using Xunit;

namespace GenericsHomework.Tests;
public class NodeTests
{
    [Fact]
    public void GetData_Head_Successful()
    {
        Node<string> list=new Node<string>("IAmHead");
        Assert.Equal("IAmHead", list.GetData());
    }

    //[Fact]
    //public void Append_NextNode_Successful()
    //{
    //    Node<string> list = new Node<string>("IAmHead");
    //    list.Append((string)"Next");
    //    Assert.Equal(list.next.GetData(), "Next");
    //}



}
