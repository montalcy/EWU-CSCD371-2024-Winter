namespace Logger;

public class LogFactory
{
    public BaseLogger CreateLogger(string className)
    {
        LogFactory logger = new LogFactory();
        logger.ClassName = className;

        return null;
    }

    public void ConfigureFileLogger(string filePath)
    {
        
    }
}
