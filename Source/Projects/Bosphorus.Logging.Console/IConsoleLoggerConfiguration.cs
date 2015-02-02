using Bosphorus.Configuration.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Console
{
    public interface IConsoleLoggerConfiguration<TLog> : IConfiguration 
        where TLog : ILog
    {
        string LogFormat { get; }
    }
}
