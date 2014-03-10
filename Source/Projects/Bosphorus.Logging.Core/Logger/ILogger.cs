using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Core.Logger
{
    public interface ILogger
    {
        void Log<TLogModel>(TLogModel logModel) where TLogModel : ILogModel;
    }
}
