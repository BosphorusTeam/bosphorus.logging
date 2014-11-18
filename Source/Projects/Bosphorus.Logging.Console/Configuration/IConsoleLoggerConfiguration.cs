using Bosphorus.Configuration.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Console.Configuration
{
    public interface IConsoleLoggerConfiguration<TLog> : IConfiguration 
        where TLog : ILog
    {
        string LogFormat { get; }
    }
}
