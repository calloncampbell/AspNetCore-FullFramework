using Microsoft.Extensions.Logging;
using System;
using ReflectInsight.Extensions.Logging;

namespace ClassLibrary.Complete
{  
    public interface IClass1
    {

    }

    public class Class1 : IClass1
    {
        readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> class.
        /// </summary>
        /// <param name="loggerFactory">The logger factory.</param>
        public Class1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Class1>();
            _logger.LogMessage("Class1 constructor - ReflectInsight message.");
        }
    }
}
