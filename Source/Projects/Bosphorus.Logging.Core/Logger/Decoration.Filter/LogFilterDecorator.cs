using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger.Decoration.Filter
{
    public class LogFilterDecorator<TLog> : AbstractLogger<TLog>, ILogger<TLog> 
        where TLog : ILog
    {
        private readonly ILogger<TLog> decorated;
        private readonly ILogFilter logFilter;

        public LogFilterDecorator(ILogger<TLog> decorated, ILogFilter logFilter)
        {
            this.decorated = decorated;
            this.logFilter = logFilter;
        }

        public override void Log(TLog log)
        {
            bool isLoggable = logFilter.IsLoggable(log);
            if (!isLoggable)
                return;

            decorated.Log(log);
        }
    }
}
