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
        string fileName = "file.txt";
        // Arrange
        FileLogger fileLogger = new FileLogger(fileName);

        // Act
        fileLogger.Log(LogLevel.Warning, "Warnings");
        string virtualPath = Path.Combine("C:\\Users\\Cynthia\\Desktop", "file.txt");
        string logFile = "";
        //using (StreamReader sr = File.OpenText(fileName))
        //{
        //  string line = "";
        //while ((line = sr.ReadLine()) != null)
        //{
        //  Console.WriteLine(line);
        // logFile = line + logFile;
        //}
        //}
        //string firsLine= sr.ReadToEnd();
        string read="";
        string s;
        if (File.Exists(virtualPath))
        {
            // Create a file to write to.
            using (StreamReader sw = File.OpenText(virtualPath))
            {
                while ((s = sw.ReadLine()) != null)
                {
                    read=sw.ReadLine();
                }

            }
        }
        // Assert
        Assert.AreEqual($"{System.DateTime.Now} {"FileLoggerTests"} {LogLevel.Warning}: {"Warnings"}", read);
    }
}
