using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculate.Tests;
public class ProgramTests
{
    [Fact]
    public void WriteLineTest()
    {
        Program program = new();
        StringWriter sw = new();
        Console.SetOut(sw);
        program.WriteLine("Enter your expression: ");
        sw.Close();
        string expected="Enter your expression: \r\n";
        Assert.Equal(sw.ToString(), expected);
    }

    [Fact]
    public void ReadLineTest()
    {
        Program program = new();

    }

}
