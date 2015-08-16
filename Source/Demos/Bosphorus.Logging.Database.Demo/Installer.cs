using Bosphorus.Configuration.Core;
using Bosphorus.Configuration.Core.Parameter;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Container.Castle.Registration.Installer;
using Bosphorus.Dao.Core.Dao;
using Bosphorus.Dao.Lucene.Dao;
using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Database.Logger;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Database.Demo
{
    public class Installer: AbstractWindsorInstaller, IInfrastructureInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For<IParameterProvider>()
                    .ImplementedBy<ParameterProvider>(),

                Component
                    .For(typeof(ILogger<>))
                    .ImplementedBy(typeof(DatabaseLogger<>)),

                Component
                    .For(typeof(IDao<>))
                    .ImplementedBy(typeof(LuceneDao<>))
            );
        }
    }
}
