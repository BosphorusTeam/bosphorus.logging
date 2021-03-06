﻿using Bosphorus.Logging.Core.Decoration.Filter;
using Bosphorus.Logging.Core.Decoration.Thread;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core
{
    public static class ILoggerDecorations
    {
        public static ILogger<TLog> Filtered<TLog>(this ILogger<TLog> extended, ILogFilter logFilter)
            where TLog : ILog
        {
            ILogger<TLog> decorated = new LogFilterDecorator<TLog>(extended, logFilter);
            return decorated;
        }

        public static ILogger<TLog> Threaded<TLog>(this ILogger<TLog> extended)
            where TLog : ILog
        {
            ILogger<TLog> decorated = new ThreadedDecorator<TLog>(extended);
            return decorated;
        }
    }
}
