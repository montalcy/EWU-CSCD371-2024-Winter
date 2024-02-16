using System;
using System.Collections;
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
    public void InitDataHeadSuccessful()
    {
        Node<string> list = new("IAmHead");
        Assert.Equal("IAmHead", list.GetData());
    }

    [Fact]
    public void AppendAlreadyExistsThrowsException()
    {
        Node<string> list = new("IamHead");
        list.Append("Hola");
        Assert.Throws<ArgumentException>(()=>list.Append("IamHead"));
        Assert.Throws<ArgumentException>(() => list.Append("Hola"));
    }

    [Fact]
    public void ExistsAlreadyExistsTrue()
    {
        Node<string> list = new("IamHead");
        bool exists=list.Exists("IamHead");
        Assert.True(exists);
    }

    [Fact]
    public void ExistsDesNotExistsFalse()
    {
        Node<string> list = new("IamHead");
        bool exists = list.Exists("head");
        Assert.False(exists);
    }

    [Fact]
    public void ToStringValueToStringSuccess()
    {
        Node<string> list = new("start");
        Node<string> list2 = new("last");
        Assert.Equal("start", list.ToString());
        Assert.Equal("last", list2.ToString());
    }

    [Fact]
    public void ClearAllClearedSuccess()
    {
        Node<string> list = new("start");
        list.Append("nextnode");
        list.Append("next");
        list.Append("last");
        list.Clear();
        Assert.True(list.Next.Equals(list));
        Assert.Equal("start", list.GetData());
    }

    [Fact]
    public void ClearFromSize1ClearedSuccess()
    {
        Node<string> list = new("start");
        list.Clear();
        Assert.True(list.Next.Equals(list));
        Assert.Equal("start", list.Next.GetData());
    }

    [Fact]
    public void AppendNextNodeSuccessful()
    {
        Node<string> list = new("iamhead");
        list.Append("nextnode");
        Assert.Equal("nextnode", list.Next.GetData());
        list.Append("next");
        Assert.Equal("next", list.Next.GetData());
        list.Append("last");
        Assert.Equal("last", list.Next.GetData());
    }

    [Fact]
    public void AppendAlreadyExistsDoesntChangeOurNextNode() {
        Node<string> node = new("first");
        node.Append("hello");
        Assert.Equal("hello", node.Next.GetData());
        node.Append("bye");
        Assert.Equal("bye", node.Next.GetData());
        Assert.Throws<ArgumentException>(() => node.Append("first"));
        Assert.NotEqual("first", node.Next.GetData());
        Assert.Equal("bye", node.Next.GetData());
    }




}
