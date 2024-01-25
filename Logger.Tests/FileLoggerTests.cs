using System;
using System.IO;
using System.Linq;

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
        //string virtualPath = Path.Combine("C:\\Users\\Cynthia\\Desktop", fileName);
        //string virtualPath=System.Reflection.Assembly.GetExecutingAssembly().Location;
        //virtualPath = Path.Combine(virtualPath, fileName);

        string virtualPath = string.Join(@"\", (Environment.CurrentDirectory));
        string path = Path.Combine(virtualPath, fileName);
        FileLogger fileLogger = new (path);

        
        // Act
        fileLogger.Log(LogLevel.Warning, "Warnings");
        
        string log = $"{System.DateTime.Now} {"FileLogger"} {LogLevel.Warning}: {"Warnings"}";
        
        //string read="";
        string contents = File.ReadLines(path).Last();

        //if (File.Exists(virtualPath))
        //{
        //    // Create a file to write to.
        //    StreamReader sr = File.OpenText(virtualPath);;
        //    read = sr.ReadToEnd();
        //    read.Trim();
        //}

        // Assert
        Assert.AreEqual(log, contents);
    }
}
