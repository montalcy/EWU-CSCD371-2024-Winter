using Xunit;
using Moq;

namespace CanHazFunny.Tests;

public class JokeServiceTests
{
    [Fact]
    public void GetJoke_ProperlyInitializedJokeService_ReturnsJoke()
    {
        JokeService jokeService = new();
        Assert.NotNull(jokeService.GetJoke());
    }



}