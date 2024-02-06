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
        FullName full = new("First", "Last");
        FullName full2 = new("First2", "Last2");
        Student student1 = new("First", "Last", full, null);
        Student student2 = new("First2", "Last2", full2, null);
        Assert.True(student1.Equals(student2));

    }

    [Fact]
    public void EmployeeConstructor_CheckingEquality_Equal()
    {
        FullName full = new("First", "Last");
        FullName full2 = new("First2", "Last2");
        Employee et1 = new("First", "Last", full, null);
        Employee et2 = new("First2", "Last2", full2, null);
        Assert.True(et1.Equals(et2));

    }

}

