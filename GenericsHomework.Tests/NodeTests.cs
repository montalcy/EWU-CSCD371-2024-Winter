using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace GenericsHomework.Tests;
public class NodeTests
{
    [Fact]
    public void GetDataHeadSuccessful()
    {
        Node<string> list = new Node<string>("IAmHead");
        Assert.Equal("IAmHead", list.GetData());
    }

    [Fact]
    public void GetDataHeadFailed()
    {
        Assert.Equal("true", "true");
    }

    //[Fact]
    //public void Append_NextNode_Successful()
    //{
    //    Node<string> list = new Node<string>("IAmHead");
    //    list.Append((string)"Next");
    //    Assert.Equal(list.next.GetData(), "Next");
    //}



}
