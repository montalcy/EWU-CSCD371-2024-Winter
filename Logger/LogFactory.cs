﻿using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace Logger;

public class LogFactory

{
    private string filePath;
    BaseLogger logger;

    public BaseLogger CreateLogger(string className)
    {
        logger.ClassName = className;
        return logger;
    }

   

    public void ConfigureFileLogger(string filePath)
    {
        this.filePath = filePath;
    }
}
