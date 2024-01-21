using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void log_WithPath_AppendsToOwnLine()
    {
        // Arrange
        FileLogger fileLogger = new FileLogger("\"C:\\Users\\Cynthia\\Desktop\\test\"");

        // Act

        // Assert
        
    }
}
