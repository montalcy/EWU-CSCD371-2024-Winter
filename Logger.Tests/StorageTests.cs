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
    public void StorageRemove_CheckingIfEmployeeWasRemoved_True()
    {
        Storage storage = new();
        Base employee1 = new Employee("Cynthia", "Montalvo", null);
        storage.Add(employee1);
        Assert.True(storage.Contains(employee1));
        storage.Remove(employee1);
        Assert.False(storage.Contains(employee1));
    }

    [Fact]
    public void StorageRemove_CheckingIfStudentWasRemoved_True()
    {
        Storage storage = new();
        Student student1 = new("Cynthia", "Montalvo", null);
        storage.Add(student1 );
        Assert.True(storage.Contains(student1));
        storage.Remove(student1);
        Assert.False(storage.Contains(student1));
    }

    [Fact]
    public void StorageRemove_CheckingIfBookWasRemoved_True()
    {
        Storage storage = new();
        Book book = new("Cynthia's book");
        storage.Add(book);
        Assert.True(storage.Contains(book));
        storage.Remove(book);
        Assert.False(storage.Contains(book));
    }


    [Fact]
    public void StorageGet_CheckingIfEmployeeWasPlacedIn_True()
    {
        Storage storage = new();
        Employee employee1 = new("Cynthia", "Montalvo", null);
        storage.Add(employee1);
        Assert.Equal(employee1, storage.Get(employee1.Id));
    }

    [Fact]
    public void StorageGet_CheckingIfStudenteWasPlacedIn_True()
    {
        Storage storage = new();
        Student student1 = new("Cynthia", "Montalvo", null);
        storage.Add(student1);
        Assert.Equal(student1, storage.Get(student1.Id));
    }

    [Fact]
    public void StorageGet_CheckingIfBookWasPlacedIn_True()
    {
        Storage storage = new();
        Book book = new("Cynthia's book");
        storage.Add(book);
        Assert.Equal(book, storage.Get(book.Id));
    }


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

