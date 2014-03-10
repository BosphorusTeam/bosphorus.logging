using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core.Logger.Decoration
{
    public interface ILogFilter
    {
        bool IsLoggable<TLogModel>(TLogModel logModel) where TLogModel : ILogModel;
    }
}
