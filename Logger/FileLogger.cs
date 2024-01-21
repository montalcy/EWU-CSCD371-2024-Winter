using System;
using System.IO;

namespace Logger;
public class FileLogger : BaseLogger
{
    private readonly string filePaths;

    public FileLogger(string filePath)
    {
        this.filePaths = filePath;

        if (File.Exists(filePaths))
        {
            File.Delete("file.txt");
        }
        FileStream fs = File.Create(filePaths) ;

            
    }

    public override void Log(LogLevel logLevel, string message)
    {
        string logEntry = $"{System.DateTime.Now} {nameof(ClassName)} {logLevel}: {message}";

        // FileStream stream = new(filePaths + ".txt", FileMode.Open);
        
        using (FileStream fs, File.Open(filePaths));

        using (StreamWriter sw = new(stream))
        {  
            sw.WriteLine(logEntry);
            sw.Dispose();
        }

    
    }
}