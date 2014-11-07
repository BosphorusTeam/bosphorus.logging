using Bosphorus.Library.Logging.Core.Decoration.Filter;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core
{
    public static partial class ILoggerDecorations
    {
        public static ILogger<TLog> Filtered<TLog>(this ILogger<TLog> extended, ILogFilter logFilter) 
            where TLog : ILog
        {
            ILogger<TLog> decorated = new LogFilterDecorator<TLog>(extended, logFilter);
            return decorated;
        }
    }
}
