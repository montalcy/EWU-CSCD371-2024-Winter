namespace Logger;
public class FileLogger : BaseLogger
{
    private string filePath;

    public FileLogger(string filePath)
    {
        filePath = filePath;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        string logEntry = $"{System.DateTime.Now} {ClassName} {logLevel}: {message}";

    }
}