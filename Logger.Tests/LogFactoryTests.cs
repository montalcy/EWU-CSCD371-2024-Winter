using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class LogFactoryTests
{
    [TestMethod]
    public void createLogger_NotConfigured_ReturnsNull()
    {
        // Arrange
        var logger = new LogFactory();

        // Act

        // Assert
        Assert.AreEqual(null, logger.CreateLogger(null));
    }

}
