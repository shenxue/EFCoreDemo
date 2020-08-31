using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDemo
{
    public class EFLogger : ILogger
    {
        private readonly string categoryName;
        public EFLogger(string categoryName) => this.categoryName = categoryName;
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var logContext = formatter(state, exception);
            Console.WriteLine();
            Console.WriteLine(logContext);//打印在控制台里
            Debugger.Log(0, categoryName, logContext);//打印在“输出”tab里面
        }
    }
}
