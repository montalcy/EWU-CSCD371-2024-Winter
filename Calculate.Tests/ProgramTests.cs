using System.IO;
using Xunit;
using Calculate;
using System;

namespace Calculate.Tests;
public class ProgramTests
{

    [Fact]
    public void Write_Line_Test()
    {
        StringWriter output = new();
        Console.SetOut(output);
        string writting = "Writting theory";
        Program program = new();
        program.WriteLine(writting);
        Assert.Equal(output.ToString().Trim(), writting);
        Console.SetOut(Console.Out);
    }
    
    [Fact]
    public void Read_Line_Test()
    {
        string writting = "writting";
        string actual = "actual";
        string expectedReadLine = " ";
        string actualReadLine= " ";
        Program program = new()
        {
            WriteLine = (strings) => writting = strings,
            ReadLine = () => expectedReadLine,
        };
        program.WriteLine(actual);
        actualReadLine = program.ReadLine()!;

        Assert.Equal(expectedReadLine, actualReadLine);

    }

}
