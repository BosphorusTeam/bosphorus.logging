using Bosphorus.Configuration.Core;

namespace Bosphorus.Library.Logging.Console.Configuration
{
    public class ConsoleLoggerConfiguration : AbstractConfiguration, IConsoleLoggerConfiguration
    {
        private const string DEFAULT_LOGFORMAT = "DateTime: {0}, Level:{1}, Message:{2}";

        public ConsoleLoggerConfiguration(IParameterProvider parameterProvider) 
            : base(typeof(IConsoleLogger<>).FullName, parameterProvider)
        {
        }

        public string LogFormat
        {
            get
            {
                string result = GetValue("LogFormat", DEFAULT_LOGFORMAT);
                return result;
            }
        }
    }
}