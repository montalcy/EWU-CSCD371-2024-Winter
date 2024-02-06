﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests;
public class StorageTests
{
    [Fact]
    public void StudentConstructor_CheckingEquality_Equal()
    {
        //should return true since they are the same type of records
        FullName full = new("First", "Last");
        FullName full2 = new("First2", "Last2");
        Student student1 = new("First", "Last", full, null);
        Student student2 = new("First2", "Last2", full2, null);
        Assert.True(student1.Equals(student2));

    }

    [Fact]
    public void EmployeeConstructor_CheckingEquality_Equal()
    {
        //should return true since they are the same type of records
        FullName full = new("First", "Last");
        FullName full2 = new("First2", "Last2");
        Employee et1 = new("First", "Last", full, null);
        Employee et2 = new("First2", "Last2", full2, null);
        Assert.True(et1.Equals(et2));

    }

    [Fact]
    public void BookConstructor_CheckingEquality_Equal()
    {
        //should return true since they are the same type of records
        Book book1 = new("Book");
        Book book2 = new("Book");
        Assert.True(book1.Equals(book2));
    }
    
    [Fact]
    public void Constructor_CheckingEqualityWithDifferentRecords_NotEqual()
    {
        //should return false since they are different records
        FullName full = new("First", "Last");
        FullName full2 = new("First2", "Last2");
        Employee et1 = new("First", "Last", full, null);
        Book book2 = new("Book");
        Assert.False(et1.Equals(book2));
    }
}

