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
        fs.Close();
            
    }

    public override void Log(LogLevel logLevel, string message)
    {
        string logEntry = $"{System.DateTime.Now} {nameof(ClassName)} {logLevel}: {message}";

        // FileStream stream = new(filePaths + ".txt", FileMode.Open);
        string path = Path.Combine("C:\\Users\\Cynthia\\Desktop", "test.txt");
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(logEntry);
            }
        }
        else if (File.Exists(path))
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(logEntry);
            }

        }
    }
    //using (FileStream fs, File.OpenText(filePaths));
    //using (StreamWriter sr = File.OpenText(filePaths))
    //{
    //  sr.WriteLine(logEntry);
    //sr.Dispose();
    //}



}
