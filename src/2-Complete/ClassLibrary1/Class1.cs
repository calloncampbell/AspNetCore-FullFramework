using Microsoft.Extensions.Logging;
using System;
using ReflectInsight.Extensions.Logging;

namespace ClassLibrary.Complete
{  
    public class Class1
    {
        readonly ILogger _logger;

        public Class1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Class1>();
            _logger.LogMessage("Class1 constructor - ReflectInsight message.");
        }
    }
}
