using Xunit;
using Moq;
using System;
using System.IO;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit.Sdk;

namespace CanHazFunny.Tests;

public class JokeOutputTests
{

    [Fact]
    public void PrintingJokeyJoke_ConsolePrinting_Successful()
    {
        OutputtingJoke output = new();
        string jokey = "Chuck Norris";
        using StringWriter sw = new();
        Console.SetOut(sw);
        output.PrintingJokeyJoke(jokey);
        Assert.NotEqual(jokey, sw.ToString());
    }
    [Fact]
    public void PrintingJokeyJoke_ConsolePrintingNull_Fail()
    {
        bool exceptionThrown = false;
        try
        {
            OutputtingJoke output = new();
            using StringWriter sw = new();
            Console.SetOut(sw);
            output.PrintingJokeyJoke(null!);
        }
        catch (ArgumentNullException)
        {
            exceptionThrown = true;
        }
        Assert.True(exceptionThrown);
    }

}