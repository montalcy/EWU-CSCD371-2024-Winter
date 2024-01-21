using System;
using System.IO;

namespace Logger;
public class FileLogger : BaseLogger
{
    private readonly string filePaths;

    public FileLogger(string filePath)
    {
        this.filePaths = filePath;
        FileStream stream = new(filePaths + ".txt", FileMode.Create);
        StreamWriter writer = new(stream); 

        if (File.Exists(filePath))
        {
            writer.WriteLine(" hello ");
        }
        //filePaths = filePath;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        string logEntry = $"{System.DateTime.Now} {nameof(ClassName)} {logLevel}: {message}";
        FileStream stream = new(filePaths + ".txt", FileMode.Open);
        using (StreamWriter sr = new(stream))
        {  
                sr.WriteLine(logEntry);
        }
    
    }
}