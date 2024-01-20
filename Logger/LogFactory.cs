using System.Security.Cryptography.X509Certificates;

namespace Logger;

public class LogFactory

{
    //BaseLogger logger = new LogFactory();
    
    public BaseLogger CreateLogger(string className)
    {
        //public override string ClassName { get { return className; } }
        
        return null;
    }

   

    public void ConfigureFileLogger(string filePath)
    {
        
    }
}
