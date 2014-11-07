using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core
{
    public interface ILogger<in TLog>
        where TLog : ILog
    {
        void Log(TLog log);
    }
}
