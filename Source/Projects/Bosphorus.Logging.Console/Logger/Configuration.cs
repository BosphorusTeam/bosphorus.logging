using Bosphorus.Configuration.Core;
using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Core.Parameter;

namespace Bosphorus.Logging.Console.Logger
{
    public class Configuration<TLog> : AbstractConfiguration
    {
        private const string DEFAULT_LOGFORMAT = "DateTime: {0}, Level:{1}, Message:{2}";

        public Configuration(IParameterProvider parameterProvider) 
            : base("Bosphorus.Logging.Console." + typeof(TLog).Name, parameterProvider)
        {
        }

        public string LogFormat => GetValue("LogFormat", DEFAULT_LOGFORMAT);
    }
}