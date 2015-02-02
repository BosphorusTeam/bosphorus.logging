using System;
using Bosphorus.Container.Castle.Extra;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Facade
{
    public class Logger
    {
        private readonly IServiceRegistry serviceRegistry;

        public Logger(IServiceRegistry serviceRegistry)
        {
            this.serviceRegistry = serviceRegistry;
        }

        public void Log<TLog>(TLog log) where TLog : ILog
        {
            Type loggerType = typeof (ILogger<TLog>);
            object instance = serviceRegistry.Get(loggerType);

            ILogger<TLog> logger = (ILogger<TLog>) instance;
            logger.Log(log);
        }
    }
}
