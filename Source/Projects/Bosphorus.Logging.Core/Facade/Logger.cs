using Bosphorus.Logging.Model;
using Castle.Windsor;

namespace Bosphorus.Logging.Core.Facade
{
    public class Logger
    {
        private readonly IWindsorContainer container;

        public Logger(IWindsorContainer container)
        {
            this.container = container;
        }

        public void Log<TLog>(TLog log) where TLog : ILog
        {
            ILogger<TLog> logger = container.Resolve<ILogger<TLog>>();
            logger.Log(log);
        }
    }
}
