using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Console.Logger
{
    public interface IConsoleLogger<in TLog> : ILogger<TLog> 
        where TLog : ILog
    {
    }
}