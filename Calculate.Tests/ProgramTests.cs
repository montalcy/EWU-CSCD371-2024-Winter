using System.IO;
using Xunit;
using Calculate;
using System;

namespace Calculate.Tests;
public class ProgramTests
{

    [Fact]
    public void WriteLine_SettingConsoleToCheckWriting_Success()
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
    public void ReadLine_SettingWriteLineAndCheckingCorrectValueRead_Success()
    {
        string writting = "writting";
        string actual = "actual";
        string expectedReadLine = " ";
        string actualReadLine = " ";
        Program program = new()
        {
            WriteLine = (strings) => writting = strings,
            ReadLine = () => expectedReadLine,
        };
        program.WriteLine(actual);
        actualReadLine = program.ReadLine()!;

        Assert.Equal(expectedReadLine, actualReadLine);

    }

    [Fact]
    public void WriteLine_OutputMatchesInputWhenCalled_Successful()
    {
        string? output = null;
        Action<string> mockWriteLine = (rString) => output = rString; // creates a mock Action<string> delegate that assigns the input string to the output variable.
        Program program = new Program { WriteLine = mockWriteLine }; // instantiates the Program class and assigns the mock WriteLine delegate to its WriteLine property.

        program.WriteLine("Test WriteLine");

        Assert.Equal("Test WriteLine", output);
    }

    [Fact]
    public void ReadLine_ReturnsExpectedStringWhenCalled_Successful()
    {
        string input = "Test ReadLine";
        Func<string?> mockReadLine = () => input; // creates a mock Func<string?> delegate that returns the predefined string input when invoked.
        Program program = new Program { ReadLine = mockReadLine }; //  instantiates the Program class and assigns the mock ReadLine delegate to its ReadLine property.

        string result = program.ReadLine()!; // call the ReadLine method of the Program instance and store the result.

        Assert.Equal("Test ReadLine", result);
    }

}
