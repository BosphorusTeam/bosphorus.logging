using Bosphorus.Configuration.Core;
using Bosphorus.Configuration.Core.Configuration;
using Bosphorus.Configuration.Core.Parameter;

namespace Bosphorus.Logging.Database.Logger
{
    public class Configuration : AbstractConfiguration
    {
        private const string DEFAULT_SESSIONALIAS = "Default";

        public Configuration(IParameterProvider parameterProvider) 
            : base("Bosphorus.Logging.Database", parameterProvider)
        {
        }

        public string SessionAlias => GetValue("SessionAlias", DEFAULT_SESSIONALIAS);
    }
}