using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core
{
    public static class ILoggerExtensions
    {
        public static void Debug<TLog>(this ILogger<TLog> extended, string message) 
            where TLog : ILog, new()
        {
            TLog log = BuildLogModel<TLog>(message, LogLevel.Debug);
            extended.Log(log);
        }

        public static void Error<TLog>(this ILogger<TLog> extended, string message) 
            where TLog : ILog, new()
        {
            TLog log = BuildLogModel<TLog>(message, LogLevel.Error);
            extended.Log(log);
        }

        public static void Fatal<TLog>(this ILogger<TLog> extended, string message) 
            where TLog : ILog, new()
        {
            TLog log = BuildLogModel<TLog>(message, LogLevel.Fatal);
            extended.Log(log);
        }

        public static void Info<TLog>(this ILogger<TLog> extended, string message) 
            where TLog : ILog, new()
        {
            TLog log = BuildLogModel<TLog>(message, LogLevel.Info);
            extended.Log(log);
        }

        public static void Log<TLog>(this ILogger<TLog> extended, string message) 
            where TLog : ILog, new()
        {
            TLog log = BuildLogModel<TLog>(message, LogLevel.Null);
            extended.Log(log);
        }

        public static void Warn<TLog>(this ILogger<TLog> extended, string message) 
            where TLog : ILog, new()
        {
            TLog log = BuildLogModel<TLog>(message, LogLevel.Warn);
            extended.Log(log);
        }

        private static TLog BuildLogModel<TLog>(string message, LogLevel logLevel)
            where TLog : ILog, new()
        {
            TLog log = new TLog {Message = message, Level = logLevel};
            return log;
        }
    }
}
