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
        Base student1 = new Student("First", "Last", null);
        Base student2 = new Student("First2", "Last2", null);
        Assert.Equal(student1.GetType(), student2.GetType());

    }
    [Fact]
    public void EmployeeConstructor_CheckingEquality_Equal()
    {
        //should return true since they are the same type of records
        
        Base et1 = new Employee("First", "Last", null);
        Base et2 = new Employee("First2", "Last2", null);
        Assert.Equal(et1.GetType(), et2.GetType());

    }

    [Fact]
    public void BookConstructor_CheckingEquality_Equal()
    {
        //should return true since they are the same type of records
        Base book1 = new Book("ISBN", "Author");
        Base book2 = new Book("ISBN", "Author");
        Assert.Equal(book1.GetType(), book2.GetType());
    }
    
    [Fact]
    public void Constructor_CheckingEqualityWithDifferentRecords_NotEqual()
    {
        //should return false since they are different records
        Employee et1 = new("First", "Last", null);
        Book book2 = new("ISBN", "Author");

        Assert.NotEqual(et1.GetType(), book2.GetType());
    }

    [Fact]
    public void Constructor_CheckingEqualityForFullNameVersusObjectType_NotEqualAndEqual()
    {
        //should return false since they are different records
        Book book = new("ISBN", "Author");
        Book book2 = new("ISBN2", "Author2");

        Assert.Equal(book.GetType(), book2.GetType());
        Assert.False(book==book2);
    }

    [Fact]
    public void StorageContain_CheckingIfBookWasPlacedIn_True()
    {
        Storage storage = new();
        Base book = new Book("ISBN", "Author");
        storage.Add(book);
        Assert.True(storage.Contains(book));
    }

    [Fact]
    public void StorageContain_CheckingIfStudentWasPlacedIn_True()
    {
        Storage storage = new();
        Base student1 = new Student("Cynthia", "Montalvo",null);
        storage.Add(student1);
        Assert.True(storage.Contains(student1));
    }

    [Fact]
    public void StorageContain_CheckingIfEmployeeWasPlacedIn_True()
    {
        Storage storage = new();
        Base employee1 = new Employee("Cynthia", "Montalvo", null);
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
    [Fact]
    public void GetFullName_TwoRecords_Equal()
    {
        //should return false since they are different records

        Student s1 = new("First", "Last", null);
        Student s2 = new("First", "Last", null);

        Employee e1 = new("First", "Last", null);
        Employee e2 = new("First", "Last", null);

        Book book1 = new("ISBN", "Author");
        Book book2 = new("ISBN", "Author");

        Assert.Equal(s1, s2);
        Assert.Equal(e1, e2);
        Assert.Equal(book1, book2);
    }

}

