using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database.Logger
{
    public interface IDatabaseLogger<in TLog> : ILogger<TLog> 
        where TLog : ILog
    {
    }
}