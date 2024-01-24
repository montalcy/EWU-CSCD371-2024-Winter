using System.Dynamic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Logger;

public class LogFactory

{
    private string? filePaths;


    public BaseLogger? CreateLogger(string className)
    {
        if (filePaths == null)
        {
            return null;
        }
        else
        {
            ConfigureFileLogger(filePaths);
            FileLogger logger = new (filePaths) { ClassName = className };
            return logger;
        }

    }

   

    public void ConfigureFileLogger(string filePath)
    {
        this.filePaths = filePath;
    }
}
