using System;
using System.Collections.Generic;
using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Console.Logger
{
    public class ConsoleLogger<TLog> : AbstractLogger<TLog>, IConsoleLogger<TLog>, ILogger<TLog>
        where TLog : ILog
    {
        private readonly string logFormat;
        private static IDictionary<LogLevel, ConsoleColor> LogColors { get; }

        static ConsoleLogger()
        {
            LogColors = new Dictionary<LogLevel, ConsoleColor>();
            LogColors.Add(LogLevel.Debug, ConsoleColor.Cyan);
            LogColors.Add(LogLevel.Error, ConsoleColor.Red);
            LogColors.Add(LogLevel.Fatal, ConsoleColor.Red);
            LogColors.Add(LogLevel.Info, ConsoleColor.Green);
            LogColors.Add(LogLevel.Null, ConsoleColor.White);
            LogColors.Add(LogLevel.Warn, ConsoleColor.Yellow);
        }

        public ConsoleLogger(IConfiguration<TLog> configuration)
        {
            this.logFormat = configuration.LogFormat;
        }

        public override void Log(TLog log)
        {
            //TODO: Not thread safe, color are conflicted and race each other :))
            ConsoleColor consoleColor = LogColors[log.Level];
            System.Console.ForegroundColor = consoleColor;
            System.Console.WriteLine(logFormat, log.DateTime, log.Level, log.Message);
            System.Console.ResetColor();
        }
    }
}
