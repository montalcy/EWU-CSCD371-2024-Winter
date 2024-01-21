using System.IO;

using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
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
        fileLogger.Log(LogLevel.Warning, "Warnings");
        StreamReader sr = File.OpenText("\"C:\\Users\\Cynthia\\Desktop\\test\"");
        string firsLine= sr.ReadToEnd();

        // Assert
        Assert.AreEqual($"{System.DateTime.Now} {"FileLoggerTests"} {LogLevel.Warning}: {"Warnings"}",firsLine );
    }
}
