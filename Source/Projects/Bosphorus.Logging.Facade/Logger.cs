using System;
using System.Collections.Generic;
using System.Text;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Library.Logging.Facade;
using Bosphorus.Library.Facade.Loader.Castle.Stream;
using Bosphorus.Library.Facade.Core.Facade.Base;

namespace Bosphorus.Library.Facades
{
    public partial class Logger : ExternalLoadedFacadeBase<Logger, StreamFacadeLoader>
    {
        private static ILogger logger;
        private static object loggerLock;

        static Logger()
        {
            loggerLock = new object();
        }

        private static ILogger InternalLogger
        {
            get
            {
                lock (loggerLock)
                {
                    if (logger == null)
                        logger = (ILogger)Container.Resolve(typeof(ILogger));
                    return logger;
                }
            }
        }

        public static void Log(string message)
        {
            Log(message, LogType.Null);
        }

        public static void Debug(string message)
        {
            Log(message, LogType.Debug);
        }

        public static void Information(string message)
        {
            Log(message, LogType.Information);
        }

        public static void Warning(string message)
        {
            Log(message, LogType.Warning);
        }

        public static void Error(string message)
        {
            Log(message, LogType.Error);
        }

        public static void Log(string message, LogType logType)
        {
            ILogModel logModel = new LogModel(message, logType);
            Log(logModel);
        }

        public static void Log(ILogModel logModel)
        {
            InternalLogger.Log(logModel);
        }
    }
}
