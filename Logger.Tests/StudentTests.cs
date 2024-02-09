using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests;

public class StudentTests
{
    [Fact]
    public void StudentConstructor_CheckingEqualityRecordType_Equal()
    {

        //should return true since they are the same type of records
        Base student1 = new Student("First", "Last", null);
        Base student2 = new Student("First2", "Last2", null);
        Assert.Equal(student1.GetType(), student2.GetType());

    }

    [Fact]
    public void StudentConstructor_CheckingEquality_Equal()
    {

        //should return true since they are the same type of records
        Base student1 = new Student("First", "Last", null);
        Base student2 = new Student("First", "Last", null);
        Assert.Equal(student1, student2);

    }

    [Fact]
    public void StudentConstructor_CheckingEquality_NotEqual()
    {

        //should return true since they are the same type of records
        Base student1 = new Student("First", "Last", null);
        Base student2 = new Employee("First2", "Last2", null);
        Assert.NotEqual(student1.GetType(), student2.GetType());

    }

    [Fact]
    public void Constructor_CheckingEqualityWithDifferentRecords_NotEqual()
    {
        //should return false since they are different records
        Student student = new("First", "Last", null);
        Employee employee = new("First", "Last", null);

        Assert.NotEqual(student.GetType(), employee.GetType());
    }

    [Fact]
    public void Constructor_CheckingEqualityForFullNameVersusObjectType_NotEqualAndEqual()
    {
        //should return false since they are different records
        Student student = new("First", "Last", null);
        Student students = new("Last", "First", null);

        Assert.Equal(student.GetType(), students.GetType());
        Assert.False(student == students);
    }
}
