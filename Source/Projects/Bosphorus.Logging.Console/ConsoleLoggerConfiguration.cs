using Bosphorus.Configuration.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Console
{
    public class ConsoleLoggerConfiguration<TLog> : AbstractConfiguration<ConsoleLogger<TLog>>, IConsoleLoggerConfiguration<TLog>
        where TLog : ILog
    {
        private const string DEFAULT_LOGFORMAT = "DateTime: {0}, Level:{1}, Message:{2}";

        public ConsoleLoggerConfiguration(IParameterProvider parameterProvider) 
            : base(parameterProvider)
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