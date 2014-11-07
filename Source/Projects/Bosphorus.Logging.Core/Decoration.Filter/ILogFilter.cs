using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core.Decoration.Filter
{
    public interface ILogFilter
    {
        bool IsLoggable<TLogModel>(TLogModel logModel) where TLogModel : ILog;
    }
}
