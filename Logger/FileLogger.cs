using System;
using System.IO;

namespace Logger;
public class FileLogger : BaseLogger
{
    private readonly string filePaths;

    public FileLogger(string filePath)
    {
        if (!File.Exists(filePath))
        {
            // Create a file to write to.
            StreamWriter sw = File.CreateText(filePath);
        }
        filePaths = filePath;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        string logEntry = $"{System.DateTime.Now} {nameof(ClassName)} {logLevel}: {message}";
        using (StreamReader sr = File.OpenText(filePaths))
        {
            string s;
            //Write to the file the logEntry
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(logEntry);
            }
        }
    
    }
}