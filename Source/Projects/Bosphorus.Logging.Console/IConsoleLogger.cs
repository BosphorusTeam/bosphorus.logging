using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Console
{
    public interface IConsoleLogger<in TLog> : ILogger<TLog> 
        where TLog : ILog
    {
    }
}