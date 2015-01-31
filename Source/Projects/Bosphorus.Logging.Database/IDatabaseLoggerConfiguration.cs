using Bosphorus.Configuration.Core;

namespace Bosphorus.Logging.Database
{
    public interface IDatabaseLoggerConfiguration: IConfiguration
    {
        string SessionAlias { get; }
    }
}
