namespace Logger;

public abstract class BaseLogger
{
   
    public abstract string? ClassName {  get; set; }

    public abstract void Log(LogLevel logLevel, string message);
    
}

//string logAppend = $"{DateTime.Now} {ClassName} {loglevel}: {message}";
