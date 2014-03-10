namespace Bosphorus.Library.Logging.Core.Extension
{
    public class LogSelectionDecorator : ILogger
    {
        private readonly ILogger decorated;
        private readonly ILogFilter logFilter;

        public LogSelectionDecorator(ILogger decorated, ILogFilter logFilter)
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
