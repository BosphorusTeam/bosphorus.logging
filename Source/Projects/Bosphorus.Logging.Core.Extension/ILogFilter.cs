namespace Bosphorus.Library.Logging.Core.Extension
{
    public interface ILogFilter
    {
        bool IsLoggable<TLogModel>(TLogModel logModel) where TLogModel : ILogModel;
    }
}
