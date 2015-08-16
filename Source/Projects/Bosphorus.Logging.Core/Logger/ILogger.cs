using System.Collections.Generic;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger
{
    public interface ILogger<in TLog>
        where TLog : ILog
    {
        void Log(TLog log);

        void Log(IEnumerable<TLog> logs);
    }
}
