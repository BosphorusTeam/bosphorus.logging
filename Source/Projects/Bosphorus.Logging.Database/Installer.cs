using Bosphorus.Container.Castle.Registration;
using Bosphorus.Container.Castle.Registration.Fluent;
using Bosphorus.Container.Castle.Registration.Installer;
using Bosphorus.Logging.Database.Logger;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Database
{
    public class Installer: AbstractWindsorInstaller, IInfrastructureInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For<Logger.Configuration>(),

                Component
                    .For(typeof(IDatabaseLogger<>))
                    .ImplementedBy(typeof(DatabaseLogger<>))
                    .NamedUnique()
            );
        }
    }

}
