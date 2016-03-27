using System;
using Bosphorus.Common.Api.Exception;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger.Decoration.Exception
{
    public class LoggerFailedException : ExceptionBase
    {
        public LoggerFailedException(Type logType, ILog log, System.Exception innerException)
            : base(ExceptionMessage.Build("GenericLogger execution failed.")
                  .Add(nameof(logType), logType)
                  .Add(nameof(log), log), innerException)
        {
        }
    }
}