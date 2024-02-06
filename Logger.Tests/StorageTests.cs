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
    public void StudentConstructor_CheckingEquality_Equal()
    {
        
        //should return true since they are the same type of records
        FullName full = new("First", "Last");
        FullName full2 = new("First2", "Last2");
        IEntity student1 = new Student("First", "Last", full, null);
        IEntity student2 = new Student("First2", "Last2", full2, null);
        Assert.Equal(student1.GetType(), student2.GetType());

    }
    [Fact]
    public void EmployeeConstructor_CheckingEquality_Equal()
    {
        //should return true since they are the same type of records
        FullName full = new("First", "Last");
        FullName full2 = new("First2", "Last2");
        IEntity et1 = new Employee("First", "Last", full, null);
        IEntity et2 = new Employee("First2", "Last2", full2, null);
        Assert.Equal(et1.GetType(), et2.GetType());

    }

    [Fact]
    public void BookConstructor_CheckingEquality_Equal()
    {
        //should return true since they are the same type of records
        Book book1 = new("Book");
        Book book2 = new("Book2");
        Assert.Equal(book1.GetType(), book2.GetType());
    }
    
    [Fact]
    public void Constructor_CheckingEqualityWithDifferentRecords_NotEqual()
    {
        //should return false since they are different records
        FullName full = new("First", "Last");
        FullName full2 = new("First2", "Last2");
        Employee et1 = new("First", "Last", full, null);
        Book book2 = new("Book");

        Assert.NotEqual(et1.GetType(), book2.GetType());
    }

    [Fact]
    public void Constructor_CheckingEqualityForFullNameVersusObjectType_NotEqualAndEqual()
    {
        //should return false since they are different records
        Book book = new Book("The book");
        Book book2 = new Book("The other book");

        Assert.Equal(book.GetType(), book2.GetType());
        Assert.False(book==book2);
    }

    [Fact]
    public void StorageContain_CheckingIfBookWasPlacedIn_True()
    {
        Storage storage = new Storage();
        IEntity book = new Book("BOOK title");
        storage.Add(book);
        Assert.True(storage.Contains(book));
    }

    [Fact]
    public void StorageContain_CheckingIfStudentWasPlacedIn_True()
    {
        Storage storage = new Storage();
        FullName fullname = new("Cynthia", "Montalvo");
        IEntity student1 = new Student("Cynthia", "Montalvo", fullname,null);
        storage.Add(student1);
        Assert.True(storage.Contains(student1));
    }

    [Fact]
    public void StorageContain_CheckingIfEmployeeWasPlacedIn_True()
    {
        Storage storage = new Storage();
        FullName fullname = new("Cynthia", "Montalvo");
        IEntity employee1 = new Employee("Cynthia", "Montalvo", fullname, null);
        storage.Add(employee1);
        Assert.True(storage.Contains(employee1));
    }

    [Fact]
    public void GetFullName_TwoRecords_NotEqual()
    {
        //should return false since they are different records
        FullName full = new("First", "Last");
        FullName otherFull = new("Fist", "Last");
        Assert.NotEqual(otherFull.GetFullName(), full.GetFullName());
    }
}

