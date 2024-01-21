using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void createLogger_NotConfigured_ReturnsNull()
    {
        // Arrange
        var logger = new LogFactory();

        // Act
        //logger.CreateLogger(null);

        // Assert
        Assert.AreEqual(null, logger.CreateLogger(null));
    }
}
