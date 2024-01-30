using Xunit;
using Moq;

namespace CanHazFunny.Tests;

public class JesterTests
{
    [Theory]
    [InlineData("How do trees get on a computer? They just log in")]
    public void TellJoke_CorrectJokeInput_OutputMatches(string joke)
    {
        var service = new Mock<IJokeService>();
        var output = new Mock<IJokeOutput>();
        service.Setup(x => x.GetJoke()).Returns(joke);
        //output.Setup(OutputtingJoke => OutputtingJoke.PrintingJokeyJoke(joke));
        Jester jester = new(service.Object, output.Object);
        jester.TellJoke();
        output.Verify(x => x.PrintingJokeyJoke(joke));
    }


}
