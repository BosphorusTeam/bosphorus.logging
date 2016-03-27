using System.Collections.Generic;
using Bosphorus.Logging.Model;
using Castle.Windsor;

namespace Bosphorus.Logging.Core.Logger
{
    public class GenericLogger
    {
        private readonly IWindsorContainer container;

        public GenericLogger(IWindsorContainer container)
        {
            this.container = container;
        }

        public void Log<TLog>(TLog log) 
            where TLog : ILog
        {
            ILogger<TLog> logger = container.Resolve<ILogger<TLog>>();
            logger.Log(log);
        }

        public void Log<TLog>(IEnumerable<TLog> logs) 
            where TLog : ILog
        {
            ILogger<TLog> logger = container.Resolve<ILogger<TLog>>();
            logger.Log(logs);
        }
    }
}
