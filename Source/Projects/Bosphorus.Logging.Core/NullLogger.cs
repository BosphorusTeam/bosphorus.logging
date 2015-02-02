using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core
{
    public class NullLogger<TLog> : ILogger<TLog> 
        where TLog : ILog
    {
        public void Log(TLog log)
        {
        }
    }
}