using System;
using System.Collections.Generic;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Console
{
    public class Logger<TLog> : ILogger<TLog> 
        where TLog : ILog
    {
        private readonly string logFormat;
        private static readonly IDictionary<LogLevel, ConsoleColor> logColors;
        private const string DEFAULT_FORMAT = "DateTime: {0}, Level:{1}, Message:{2}";

        static Logger()
        {
            logColors = new Dictionary<LogLevel, ConsoleColor>();
            logColors.Add(LogLevel.Debug, ConsoleColor.Cyan);
            logColors.Add(LogLevel.Error, ConsoleColor.Red);
            logColors.Add(LogLevel.Fatal, ConsoleColor.Red);
            logColors.Add(LogLevel.Info, ConsoleColor.Green);
            logColors.Add(LogLevel.Null, ConsoleColor.White);
            logColors.Add(LogLevel.Warn, ConsoleColor.Yellow);
        }

        public Logger()
            : this(DEFAULT_FORMAT)
        {
        }

        public Logger(string logFormat)
        {
            this.logFormat = logFormat;
        }

        public void Log(TLog log)
        {
            ConsoleColor consoleColor = logColors[log.Level];
            System.Console.ForegroundColor = consoleColor;
            System.Console.WriteLine(logFormat, log.DateTime, log.Level, log.Message);
            System.Console.ResetColor();
        }
    }
}
