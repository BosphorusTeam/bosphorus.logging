using System.Collections;
using Bosphorus.Configuration.Core;

namespace Bosphorus.Logging.Database.Configuration
{
    public interface IDatabaseLoggerConfiguration<TLog>: IConfiguration
    {
        IDictionary SessionManagerCreationArguments { get; }
    }
}
