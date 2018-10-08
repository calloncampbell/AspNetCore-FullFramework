using Microsoft.Extensions.Logging;
using System;
using ReflectInsight.Extensions.Logging;
using ReflectSoftware.Insight.Common;
using ReflectSoftware.Insight;

namespace ClassLibrary.Complete
{  
    public interface IClass1
    {
    }

    public class Class1 : IClass1
    {
        readonly ILogger _logger;
        readonly IReflectInsight _reflectInsightLog;

        /// <summary>
        /// Initializes a new instance of the <see cref="Class1"/> class.
        /// </summary>
        /// <param name="loggerFactory">The logger factory.</param>
        public Class1(ILoggerFactory loggerFactory)
        {
            // ReflectInsight.Extensions.Logger
            _logger = loggerFactory.CreateLogger<Class1>();
            _logger.LogInformation("Class1 constructor - Welcome to ReflectInsight.Extensions.Logging.");

            // ReflectInsight Logging
            _reflectInsightLog = new ReflectSoftware.Insight.ReflectInsight();
            _reflectInsightLog.SendInformation("Class1 constructor - Welcome to ReflectInsight logging.");
        }
    }
}
