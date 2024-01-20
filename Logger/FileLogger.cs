namespace Logger;
public class FileLogger : BaseLogger
{
    private readonly string filePaths;

    public FileLogger(string filePath)
    {
        filePaths = filePath;
    }

    public override void Log(LogLevel logLevel, string message)
    {
        string logEntry = $"{System.DateTime.Now} {nameof(ClassName)} {logLevel}: {message}";

    }
}