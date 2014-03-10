using System.Reflection;
using Bosphorus.Common;
using Bosphorus.Dao.NHibernate.Session.Factory.Builder;
using FluentNHibernate.Automapping;

namespace Bosphorus.Logging.Database
{
    public class AutoPersistenceModelProvider : IAutoPersistenceModelProvider
    {
        private readonly AssemblyRepository assemblyRepository;

        public AutoPersistenceModelProvider(AssemblyRepository assemblyRepository)
        {
            this.assemblyRepository = assemblyRepository;
        }

        public AutoPersistenceModel GetAutoPersistenceModel()
        {
            Assembly[] assemblies = assemblyRepository.GetAssemblies();
            AutoPersistenceModel autoPersistenceModel = AutoMap.Assemblies(new AutoMappingConfiguration(), assemblies);
            return autoPersistenceModel;
        }
    }
}
