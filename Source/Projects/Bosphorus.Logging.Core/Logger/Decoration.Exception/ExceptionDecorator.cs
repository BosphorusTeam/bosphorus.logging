using System;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger.Decoration.Exception
{
    public class ExceptionDecorator<TLog> : AbstractLogger<TLog>, ILogger<TLog> 
        where TLog : ILog
    {
        private readonly ILogger<TLog> decorated;
        private static readonly Type logType;

        static ExceptionDecorator()
        {
            logType = typeof (TLog);
        }

        public ExceptionDecorator(ILogger<TLog> decorated)
        {
            this.decorated = decorated;
        }

        public override void Log(TLog log)
        {
            try
            {
                decorated.Log(log);
            }
            catch (System.Exception exception)
            {
                throw new LoggerFailedException(logType, log, exception);
            }
        }
    }
}
