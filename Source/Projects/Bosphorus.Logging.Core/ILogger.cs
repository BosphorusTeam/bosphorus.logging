namespace Bosphorus.Library.Logging.Core
{
    public interface ILogger
    {
        void Log<TLogModel>(TLogModel logModel) where TLogModel : ILogModel;
    }
}
