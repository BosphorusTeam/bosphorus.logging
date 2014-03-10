using Bosphorus.Library.Logging.Core.Logger.Decoration;

namespace Bosphorus.Library.Logging.Core.Logger
{
    public static partial class LoggerExtension
    {
        public static ILogger Filtered(this ILogger extended, ILogFilter logFilter)
        {
            ILogger decorated = new LogFilterDecorator(extended, logFilter);
            return decorated;
        }
    }
}
