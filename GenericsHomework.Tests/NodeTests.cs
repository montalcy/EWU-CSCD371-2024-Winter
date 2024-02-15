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
    public void Init_DataHead_Successful()
    {
        Node<string> list = new("IAmHead");
        Assert.Equal("IAmHead", list.GetData());
    }

    [Fact]
    public void Init_NullData_Fail()
    {
        Node<string> list = new(null);
        Assert.Throws<ArgumentNullException>(() => list.ToString());
    }

    //[Fact]
    //public void Append_AlreadyExists_ThrowsException()
    //{
    //    Node<string> list = new("IamHead");
    //    list.Append("IamNext");
    //    list.Append("IamNextNext");
    //    Assert.Throws<ArgumentException>(list.Exists("IamHead"));
    //    Assert.Throws<ArgumentException>(() => list.Exists("IamNext"));
    //    Assert.Throws<ArgumentException>(() => list.Exists("IamNextNext"));
    //}

    //[Fact]
    //public void Exists_AlreadyExists_ThrowsException()
    //{
    //    Node<string> list = new("IamHead");
    //    list.Append("IamNext");
    //    list.Append("IamNextNext");
    //    Assert.Throws<ArgumentException>(()=>list.Exists("IamHead"));
    //    Assert.Throws<ArgumentException>(() => list.Exists("IamNext"));
    //    Assert.Throws<ArgumentException>(() => list.Exists("IamNextNext"));
    //}


    //[Fact]
    //public void Remove_ClearsAllButCurrent_Successful()
    //{
    //    Node<string> list = new("IAmHead");
    //    list.Append("imnext");
    //    list.Append("nexttonext");
    //    list.Append("last");
    //    list.Clear();
    //    Assert.Equal(list.Next.GetData(), list.GetData());
    //}

    [Fact]
    public void Size_AppendingThree_Success()
    {
        Node<string> list = new("iamhead");
        list.Append("nextnode");
        list.Append("next");
        list.Append("last");
        Assert.Equal(3, list.Size);
    }


    [Fact]
    public void Value_initMatches_Success()
    {
        Node<string> list = new("start");
        Assert.Equal("start", list.GetData());
    }

    [Fact]
    public void ToString_ValueToString_Success()
    {
        Node<string> list = new("start");
        Assert.Equal("start", list.ToString());
    }

    [Fact]
    public void Clear_AllCleared_Success()
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
    public void Append_NextNode_Successful()
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
