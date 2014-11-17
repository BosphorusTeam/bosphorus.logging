using System;
using System.Collections.Generic;
using Bosphorus.Library.Logging.Console.Configuration;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Console
{
    public class ConsoleLogger<TLog> : IConsoleLogger<TLog>, ILogger<TLog>
        where TLog : ILog
    {
        private readonly string logFormat;
        private static readonly IDictionary<LogLevel, ConsoleColor> logColors;

        static ConsoleLogger()
        {
            logColors = new Dictionary<LogLevel, ConsoleColor>();
            logColors.Add(LogLevel.Debug, ConsoleColor.Cyan);
            logColors.Add(LogLevel.Error, ConsoleColor.Red);
            logColors.Add(LogLevel.Fatal, ConsoleColor.Red);
            logColors.Add(LogLevel.Info, ConsoleColor.Green);
            logColors.Add(LogLevel.Null, ConsoleColor.White);
            logColors.Add(LogLevel.Warn, ConsoleColor.Yellow);
        }

        public ConsoleLogger(IConsoleLoggerConfiguration configuration)
        {
            this.logFormat = configuration.LogFormat;
        }

        public void Log(TLog log)
        {
            //TODO: Not thread safe, color are conflicted and race each other :))
            ConsoleColor consoleColor = logColors[log.Level];
            System.Console.ForegroundColor = consoleColor;
            System.Console.WriteLine(logFormat, log.DateTime, log.Level, log.Message);
            System.Console.ResetColor();
        }
    }
}
