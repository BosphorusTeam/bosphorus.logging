using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core.Logger
{
    public static partial class LoggerExtension
    {
        public static void Debug(this ILogger extended, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Debug);
            extended.Log(logModel);
        }

        public static void Error(this ILogger extended, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Error);
            extended.Log(logModel);
        }

        public static void Fatal(this ILogger extended, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Fatal);
            extended.Log(logModel);
        }

        public static void Info(this ILogger extended, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Info);
            extended.Log(logModel);
        }

        public static void Log(this ILogger extended, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Null);
            extended.Log(logModel);
        }

        public static void Warn(this ILogger extended, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Warn);
            extended.Log(logModel);
        }

        private static LogModel BuildLogModel(string message, LogLevel logLevel)
        {
            LogModel logModel = new LogModel {Message = message, Level = logLevel};
            return logModel;
        }
    }
}
