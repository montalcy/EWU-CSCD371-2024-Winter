using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests;
public class StorageTests
{  
    [Fact]
    public void Constructor_CheckingEqualityWithDifferentRecords_NotEqual()
    {
        //should return false since they are different records
        Employee et1 = new("First", "Last", null);
        Book book2 = new("Title");

        Assert.NotEqual(et1.GetType(), book2.GetType());
    }

    [Fact]
    public void Constructor_CheckingEqualityForFullNameVersusObjectType_NotEqualAndEqual()
    {
        //should return false since they are different records
        Book book = new("Title");
        Book book2 = new("Titles");

        Assert.Equal(book.GetType(), book2.GetType());
        Assert.False(book == book2);
    }

    [Fact]
    public void StorageContain_CheckingIfBookWasPlacedIn_True()
    {
        Storage storage = new();
        Base book = new Book("Title");
        storage.Add(book);
        Assert.True(storage.Contains(book));
    }

    [Fact]
    public void StorageContain_CheckingIfStudentWasPlacedIn_True()
    {
        Storage storage = new();
        Base student1 = new Student("Cynthia", "Montalvo", null);
        storage.Add(student1);
        Assert.True(storage.Contains(student1));
    }

    [Fact]
    public void StorageRemove_CheckingIfEmployeeWasPlacedIn_True()
    {
        Storage storage = new();
        Base employee1 = new Employee("Cynthia", "Montalvo", null);
        storage.Add(employee1);
        Assert.True(storage.Contains(employee1));
        storage.Remove(employee1);
        Assert.False(storage.Contains(employee1));
    }


    /*[Fact]
    public void StorageGet_CheckingIfEmployeeWasPlacedIn_True()
    {
        Storage storage = new();
        Base employee1 = new Employee("Cynthia", "Montalvo", null);
        storage.Add(employee1);
        Assert.True(storage.Contains(employee1));
    }*/

    [Fact]
    public void StorageContains_CheckingIfEmployeeWasPlacedIn_True()
    {
        Storage storage = new();
        Base employee1 = new Employee("Cynthia", "Montalvo", null);
        storage.Add(employee1);
        Assert.True(storage.Contains(employee1));
    }

    // comnpare name then id should fail with different objects
}

