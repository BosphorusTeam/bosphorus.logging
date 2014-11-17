using Bosphorus.Configuration.Core;

namespace Bosphorus.Library.Logging.Console.Configuration
{
    public interface IConsoleLoggerConfiguration: IConfiguration
    {
        string LogFormat { get; }
    }
}
