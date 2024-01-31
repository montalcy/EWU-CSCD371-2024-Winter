using Xunit;
using Moq;
using System;
using System.IO;

namespace CanHazFunny.Tests;

public class JesterTests
{

    [Fact]
    public void Jester_NullService_ReturnsArgumentNull()
    {
        bool exceptionThrown=false;
        string expectedParamName = "service";
        try
        {
            new Jester(null!, new OutputtingJoke());
        }
        catch (ArgumentNullException ex)
        {
            exceptionThrown = true;
            Assert.Equal(expectedParamName, ex.ParamName);
        }
        Assert.True(exceptionThrown);

    }

    [Fact]
    public void Jester_NullOutputtingJoke_ReturnsArgumentNull()
    {
        bool exceptionThrown = false;
        string expectedParamName = "output";

        try
        {
            new Jester(new JokeService(), null!);
        }
        catch (ArgumentNullException ex)
        {
            exceptionThrown = true;
            Assert.Equal(expectedParamName, ex.ParamName);
        }
        Assert.True(exceptionThrown);

    }


    [Fact]
    public void TellJoke_ForceInputtingChuck_SuccesfulNotEqual()
    {
        var service = new Mock<JokeService>();
        var output = new Mock<OutputtingJoke>();
        JokeService servicer = new();
        Jester jester = new(service.Object, output.Object);
        OutputtingJoke o = new();

        string _initialJoke = "Chuck Norris Joke";
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            jester.TellJoke(_initialJoke);
            Assert.NotEqual(_initialJoke, sw.ToString());
        } 
    }

    [Fact]
    public void TellJoke_FromJokeServiceInput_DoesNotReturnChuck_Succeful()
    {
        var service = new Mock<JokeService>();
        var output = new Mock<OutputtingJoke>();
        JokeService servicer = new();
        Jester jester = new(service.Object, output.Object);

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            jester.TellJoke();
            Assert.DoesNotContain("Chuck Norris", sw.ToString());
        }
    }


}
