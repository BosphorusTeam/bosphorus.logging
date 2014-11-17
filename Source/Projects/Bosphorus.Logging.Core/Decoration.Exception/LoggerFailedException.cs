using System;
using Bosphorus.Common.Clr.Exception;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core.Decoration.Exception
{
    public class LoggerFailedException : ExceptionBase
    {
        public LoggerFailedException(Type logType, ILog log, System.Exception innerException)
            : base(ExceptionMessage.Build("Logger execution failed.").Add("LogType", logType).Add("Log", log), innerException)
        {
        }
    }
}