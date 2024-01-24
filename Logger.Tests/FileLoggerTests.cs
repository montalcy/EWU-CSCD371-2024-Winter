using System;
using System.IO;

using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void Log_WithPath_AppendsToOwnLine()
    {
        string fileName = "file.txt";
        // Arrange
        string virtualPath = Path.Combine("C:\\Users\\Cynthia\\Desktop", fileName);
        FileLogger fileLogger = new (virtualPath);

        // Act
        fileLogger.Log(LogLevel.Warning, "Warnings");
        
        string log = $"{System.DateTime.Now} {"FileLogger"} {LogLevel.Warning}: {"Warnings"}";
        
        string read="";
        
        if (File.Exists(virtualPath))
        {
            // Create a file to write to.
           
            StreamReader sr = File.OpenText(virtualPath);
            read = sr.ReadToEnd();
        }
        // Assert
        Assert.AreEqual(log, read);
    }
}
