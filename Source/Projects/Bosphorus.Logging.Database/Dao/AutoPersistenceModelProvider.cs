using System.Collections.Generic;
using System.Reflection;
using Bosphorus.Dao.NHibernate.Configuration.Fluent.AutoPersistenceModelProvider;
using FluentNHibernate.Automapping;

namespace Bosphorus.Logging.Database.Dao
{
    public class AutoPersistenceModelProvider : AbstractAutoPersistenceModelProvider
    {
        public AutoPersistenceModelProvider(IDatabaseLoggerConfiguration configuration)
            : base(configuration.SessionAlias)
        {
        }

        protected override AutoPersistenceModel GetAutoPersistenceModel(IEnumerable<Assembly> allLoadedAssemblies)
        {
            IAutomappingConfiguration automappingConfiguration = new AutoMappingConfiguration();
            AutoPersistenceModel autoPersistenceModel = AutoMap.Assemblies(automappingConfiguration, allLoadedAssemblies);
            return autoPersistenceModel;
        }
    }
}
