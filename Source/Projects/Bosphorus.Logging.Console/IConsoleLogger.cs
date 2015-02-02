using Bosphorus.Logging.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Console
{
    public interface IConsoleLogger<in TLog> : ILogger<TLog> 
        where TLog : ILog
    {
    }
}