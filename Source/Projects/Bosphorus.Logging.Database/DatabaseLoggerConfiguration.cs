using Bosphorus.Configuration.Core;

namespace Bosphorus.Logging.Database
{
    public class DatabaseLoggerConfiguration : AbstractConfiguration, IDatabaseLoggerConfiguration
    {
        private const string DEFAULT_SESSIONALIAS = "Default";

        public DatabaseLoggerConfiguration(IParameterProvider parameterProvider) 
            : base("Logger.Database", parameterProvider)
        {
        }

        public string SessionAlias
        {
            get
            {
                string sessionAlias = GetValue("SessionAlias", DEFAULT_SESSIONALIAS);
                return sessionAlias;
            } 

        }
    }
}