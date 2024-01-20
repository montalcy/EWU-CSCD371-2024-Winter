using System;

namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger logger, string message, params object[] arguments)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Error, string.Format(message, arguments));
        }
        else
        {
            throw new ArgumentNullException("logger null");
        }
        
    }

    public static void Warning(this BaseLogger logger, string message, params object[] arguments)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Warning, string.Format(message, arguments));
        }
        else
        {
            throw new ArgumentNullException("logger null");
        }
    }

    public static void Information(this BaseLogger logger, string message, params object[] arguments)
    {
        if (logger != null)
        {
            logger.Log(LogLevel.Information, string.Format(message, arguments));
        }
        else
        {
            throw new ArgumentNullException("logger null");
        }
    }

    public static void Debug(this BaseLogger logger, string message, params object[] arguments)
    {
        if (logger == null)
        {
            throw new ArgumentNullException("logger null");
        }
        logger.Log(LogLevel.Debug, string.Format(message, arguments));
    }

}
