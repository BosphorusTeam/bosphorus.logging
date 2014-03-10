using System.Collections.Generic;
using System.Reflection;
using Bosphorus.Dao.NHibernate.Session.Provider.Factory;
using Castle.Core.Internal;
using FluentNHibernate.Automapping;

namespace Bosphorus.Logging.Database
{
    public class AutoPersistenceModelProvider : AbstractAutoPersistenceModelProvider
    {
        public override AutoPersistenceModel GetAutoPersistenceModel(IAssemblyProvider assemblyProvider)
        {
            IEnumerable<Assembly> assemblies = assemblyProvider.GetAssemblies();
            AutoPersistenceModel autoPersistenceModel = AutoMap.Assemblies(new AutoMappingConfiguration(), assemblies);
            return autoPersistenceModel;
        }
    }
}
