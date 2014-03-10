using System;
using System.Collections.Generic;
using System.Text;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Library.Logging.Facade;
using System.Diagnostics;

namespace Bosphorus.Library.Facades
{
    partial class Logger
    {
        public class Scoped
        {
            public static IDisposable Log(string message)
            {
                return Log(message, LogType.Null);
            }

            public static IDisposable Debug(string message)
            {
                return Log(message, LogType.Debug);
            }

            public static IDisposable Information(string message)
            {
                return Log(message, LogType.Information);
            }

            public static IDisposable Warning(string message)
            {
                return Log(message, LogType.Warning);
            }

            public static IDisposable Error(string message)
            {
                return Log(message, LogType.Error);
            }

            public static IDisposable Log(string message, LogType logType)
            {
                ILogModel logModel = new LogModel(message, logType);
                return Log(logModel);
            }

            public static IDisposable Log(ILogModel logModel)
            {
                IDisposable disposable = new LogScope(logModel, Logger.Log);
                return disposable;
            }
        }
    }
}
