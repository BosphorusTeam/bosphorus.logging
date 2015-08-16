using System;
using System.Collections.Generic;
using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Console.Logger
{
    public class ConsoleLogger<TLog> : AbstractLogger<TLog>, IConsoleLogger<TLog>, ILogger<TLog>
        where TLog : ILog
    {
        private static readonly IDictionary<LogLevel, ConsoleColor> logColors;
        private readonly string logFormat;

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

        public ConsoleLogger(Configuration<TLog> configuration)
        {
            this.logFormat = configuration.LogFormat;
        }

        public override void Log(TLog log)
        {
            //TODO: Not thread safe, color are conflicted and race each other :))
            ConsoleColor consoleColor = logColors[log.Level];
            System.Console.ForegroundColor = consoleColor;
            System.Console.WriteLine(logFormat, log.DateTime, log.Level, log.Message);
            System.Console.ResetColor();
        }
    }
}
