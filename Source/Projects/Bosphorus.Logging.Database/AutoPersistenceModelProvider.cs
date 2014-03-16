using System.Collections.Generic;
using System.Reflection;
using Bosphorus.Dao.NHibernate.Session.Provider.Factory;
using FluentNHibernate.Automapping;

namespace Bosphorus.Logging.Database
{
    public class AutoPersistenceModelProvider : AbstractAutoPersistenceModelProvider
    {
        protected override AutoPersistenceModel GetAutoPersistenceModel(IEnumerable<Assembly> allLoadedAssemblies)
        {
            AutoPersistenceModel autoPersistenceModel = AutoMap.Assemblies(new AutoMappingConfiguration(), allLoadedAssemblies);
            return autoPersistenceModel;
        }
    }
}
