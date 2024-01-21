using System;
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
        string fileName = @"C:\Temp\file.txt";
        // Arrange
        FileLogger fileLogger = new FileLogger(fileName);

        // Act
        fileLogger.Log(LogLevel.Warning, "Warnings");
        string logFile = "";
        using (StreamReader sr = File.OpenText(fileName))
        {
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                logFile = line + logFile;
            }
        }
        //string firsLine= sr.ReadToEnd();

        // Assert
        Assert.AreEqual($"{System.DateTime.Now} {"FileLoggerTests"} {LogLevel.Warning}: {"Warnings"}", logFile);
    }
}
