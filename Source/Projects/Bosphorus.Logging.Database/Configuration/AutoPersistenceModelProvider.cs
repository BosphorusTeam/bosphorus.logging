using System.Collections.Generic;
using System.Reflection;
using Bosphorus.Dao.NHibernate.Fluent.AutoPersistenceModelProvider;
using FluentNHibernate.Automapping;

namespace Bosphorus.Logging.Database
{
    public class AutoPersistenceModelProvider : AbstractAutoPersistenceModelProvider
    {
        protected override AutoPersistenceModel GetAutoPersistenceModel(IEnumerable<Assembly> allLoadedAssemblies)
        {
            IAutomappingConfiguration automappingConfiguration = new AutoMappingConfiguration();
            AutoPersistenceModel autoPersistenceModel = AutoMap.Assemblies(automappingConfiguration, allLoadedAssemblies);
            return autoPersistenceModel;
        }
    }
}
