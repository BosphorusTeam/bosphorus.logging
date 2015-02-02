using Bosphorus.Logging.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database
{
    public interface IDatabaseLogger<in TLog> : ILogger<TLog> 
        where TLog : ILog
    {
    }
}