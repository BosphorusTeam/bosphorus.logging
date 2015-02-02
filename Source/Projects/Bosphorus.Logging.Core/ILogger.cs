using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core
{
    public interface ILogger<in TLog>
        where TLog : ILog
    {
        void Log(TLog log);
    }
}
