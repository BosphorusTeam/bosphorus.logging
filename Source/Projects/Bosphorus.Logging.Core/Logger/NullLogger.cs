using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger
{
    public class NullLogger<TLog> : AbstractLogger<TLog>, ILogger<TLog> 
        where TLog : ILog
    {
        public override void Log(TLog log)
        {
        }
    }
}