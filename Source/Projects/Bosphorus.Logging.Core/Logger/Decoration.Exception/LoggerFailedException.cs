using System;
using Bosphorus.Common.Clr.Exception;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger.Decoration.Exception
{
    public class LoggerFailedException : ExceptionBase
    {
        public LoggerFailedException(Type logType, ILog log, System.Exception innerException)
            : base(ExceptionMessage.Build("GenericLogger execution failed.").Add("LogType", logType).Add("Log", log), innerException)
        {
        }
    }
}