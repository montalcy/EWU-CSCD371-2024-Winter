using Xunit;
using Moq;
using System;

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

    //[Fact]
    //public void TellJoke_NoChuckNorris_ReturnsJoke()
    //{
    //    JokeService jokeService=new();
    //    Jester jester = new(jokeService, new OutputtingJoke());
        
    //}

    [Theory]
    [InlineData("How do trees get on a computer? They just log in")]
    public void TellJoke_CorrectJokeInput_OutputMatches(string joke)
    {
        var service = new Mock<IJokeService>();
        var output = new Mock<IJokeOutput>();
        service.Setup(x => x.GetJoke()).Returns(joke);
        output.Setup(r => r.PrintingJokeyJoke(joke));
        Jester jester =
        output.VerifyAll();// (x => x.PrintingJokeyJoke(joke));
    }
}
