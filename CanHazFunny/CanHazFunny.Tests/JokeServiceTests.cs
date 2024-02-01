using Xunit;
using Moq;

namespace CanHazFunny.Tests;

public class JokeServiceTests
{
    [Fact]
    public void GetJoke_ProperlyInitializedJokeService_ReturnsJoke_Successful()
    {
        JokeService jokeService = new();
        Assert.NotNull(jokeService.GetJoke());
    }
    [Fact]
    public void GetJoke_ProperlyInitializedJokeService_NotEmptyString_Successful()
    {
        JokeService jokeService = new();
        Assert.NotEmpty(jokeService.GetJoke());
    }



}