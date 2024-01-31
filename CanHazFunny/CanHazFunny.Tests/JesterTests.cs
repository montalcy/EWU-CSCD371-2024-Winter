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
        Jester jester = new Jester(service.Object, output.Object);
        jester.TellJoke();
        output.Verify(r => r.PrintingJokeyJoke(joke));
    }
    [Theory]
    [InlineData("Chuck Norris joke")]
    public void TellJoke_ChuckNorrisJokeInput_OutputDoesNotMatches(string joke)
    {
        var service = new Mock<IJokeService>();
        var output = new Mock<IJokeOutput>();
        service.Setup(x => x.GetJoke()).Returns(joke);
        Jester jester = new Jester(service.Object, output.Object);
        jester.TellJoke();
        output.Verify(r => r.PrintingJokeyJoke(joke), Times.Never);
        
    }

    [Fact]
    public void TellJoke_JokeInput_DoesNotReturnChuck()
    {
        var service = new Mock<IJokeService>();
        var output = new Mock<IJokeOutput>();
        JokeService servicer = new();
        Jester jester = new(service.Object, output.Object);
        Assert.DoesNotContain("Chuck Norris", jester.TellJoke().ToString);
        //Jester jester = new(service.Object, output.Object);
        //jester.TellJoke();

        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw); // Redirect Console.Out to StringWriter

            // Act
            jester.TellJoke();

            // Assert

            Assert.DoesNotContain("Chuck Norris", sw.ToString());
        }
    }


}
