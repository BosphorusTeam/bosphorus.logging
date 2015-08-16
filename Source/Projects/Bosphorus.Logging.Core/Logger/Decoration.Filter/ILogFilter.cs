using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger.Decoration.Filter
{
    public interface ILogFilter
    {
        bool IsLoggable<TLogModel>(TLogModel logModel) where TLogModel : ILog;
    }
}
