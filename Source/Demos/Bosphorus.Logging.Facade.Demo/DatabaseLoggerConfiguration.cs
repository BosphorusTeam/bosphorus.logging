using System.Collections;
using Bosphorus.Configuration.Core;
using Bosphorus.Logging.Database.Configuration;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class DatabaseLoggerConfiguration<TLog>: AbstractConfiguration<TLog>, IDatabaseLoggerConfiguration<TLog>
    {
        private readonly IDictionary dictionary;

        public DatabaseLoggerConfiguration(IParameterProvider parameterProvider) 
            : base(parameterProvider)
        {
            dictionary = new Hashtable();
            dictionary.Add("SessionAlias", "Log");
        }

        public IDictionary SessionManagerCreationArguments
        {
            get { return dictionary; }

        }
    }
}