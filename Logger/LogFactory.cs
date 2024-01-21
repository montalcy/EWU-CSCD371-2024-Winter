using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Logger;

public class LogFactory

{
    private string? filePath;


    public BaseLogger? CreateLogger(string className)
    {
        if (filePath == null)
        {
            return null;
        }
        else
        {
           
            FileLogger logger = new FileLogger(filePath) { ClassName = className };
            return logger;
        }

    }

   

    public void ConfigureFileLogger(string filePath)
    {
        this.filePath = filePath;
    }
}
