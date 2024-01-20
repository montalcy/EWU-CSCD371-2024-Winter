using System.Security.Cryptography.X509Certificates;

namespace Logger;

public class LogFactory

{
    private string filePath; 
    //BaseLogger logger = new LogFactory();
    
    public BaseLogger CreateLogger(string className)
    {
        //public override string ClassName { get { return className; } }
        
        return null;
    }

   

    public void ConfigureFileLogger(string filePath)
    {
        this.filePath = filePath;
    }
}
