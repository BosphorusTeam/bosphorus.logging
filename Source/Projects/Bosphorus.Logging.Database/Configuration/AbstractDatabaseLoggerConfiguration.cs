using System.Collections;
using Bosphorus.Configuration.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database.Configuration
{
    public abstract class AbstractDatabaseLoggerConfiguration<TLog> : AbstractConfiguration<DatabaseLogger<TLog>>, IDatabaseLoggerConfiguration<TLog> 
        where TLog : ILog
    {
        private const string DEFAULT_SESSIONALIAS = "Log";

        protected AbstractDatabaseLoggerConfiguration(IParameterProvider parameterProvider) 
            : base(parameterProvider)
        {
        }

        public abstract IDictionary SessionManagerCreationArguments { get; }
    }
}