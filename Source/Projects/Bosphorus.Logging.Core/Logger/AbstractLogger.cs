using System.Collections.Generic;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger
{
    public abstract class AbstractLogger<TLog> : ILogger<TLog> 
        where TLog : ILog
    {
        public abstract void Log(TLog log);

        public void Log(IEnumerable<TLog> logs)
        {
            foreach (TLog log in logs)
            {
                Log(log);
            }
        }
    }
}