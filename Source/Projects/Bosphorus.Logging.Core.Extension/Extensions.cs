namespace Bosphorus.Library.Logging.Core.Extension
{
    public static class Extensions
    {
        public static void Debug(this ILogger logger, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Debug);
            logger.Log(logModel);
        }

        public static void Error(this ILogger logger, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Error);
            logger.Log(logModel);
        }

        public static void Fatal(this ILogger logger, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Fatal);
            logger.Log(logModel);
        }

        public static void Info(this ILogger logger, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Info);
            logger.Log(logModel);
        }

        public static void Log(this ILogger logger, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Null);
            logger.Log(logModel);
        }

        public static void Warn(this ILogger logger, string message)
        {
            LogModel logModel = BuildLogModel(message, LogLevel.Warn);
            logger.Log(logModel);
        }

        private static LogModel BuildLogModel(string message, LogLevel logLevel)
        {
            LogModel logModel = new LogModel {Message = message, Level = logLevel};
            return logModel;
        }
    }
}
