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
    public void InitDataHeadSuccessful()
    {
        Node<string> list = new("IAmHead");
        Assert.Equal("IAmHead", list.GetData());
    }

    [Fact]
    public void InitNullDataFail()
    {
        Node<string> list = new(null);
        Assert.Throws<ArgumentNullException>(() => list.ToString());
    }

    [Fact]
    public void AppendAlreadyExistsThrowsException()
    {
        Node<string> list = new("IamHead");
        Assert.Throws<ArgumentException>(()=>list.Append("IamHead"));
    }

    [Fact]
    public void ExistsAlreadyExistsTrue()
    {
        Node<string> list = new("IamHead");
        bool exists=list.Exists("IamHead");
        Assert.True(exists);
    }

    [Fact]
    public void SizeAppendingThreeSuccess()
    {
        Node<string> list = new("iamhead");
        list.Append("nextnode");
        list.Append("next");
        list.Append("last");
        Assert.Equal(3, list.Size);
    }


    [Fact]
    public void ValueinitMatchesSuccess()
    {
        Node<string> list = new("start");
        Assert.Equal("start", list.GetData());
    }

    [Fact]
    public void ToStringValueToStringSuccess()
    {
        Node<string> list = new("start");
        Assert.Equal("start", list.ToString());
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


}
