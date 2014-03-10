using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core.Logger.Decoration
{
    class LogFilterDecorator : ILogger
    {
        private readonly ILogger decorated;
        private readonly ILogFilter logFilter;

        public LogFilterDecorator(ILogger decorated, ILogFilter logFilter)
        {
            this.decorated = decorated;
            this.logFilter = logFilter;
        }

        public void Log<TLogModel>(TLogModel logModel) where TLogModel : ILogModel
        {
            bool isLoggable = logFilter.IsLoggable(logModel);
            if (!isLoggable)
                return;

            decorated.Log(logModel);
        }
    }
}
