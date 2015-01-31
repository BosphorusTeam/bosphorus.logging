using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Logging.Database.Common;
using Bosphorus.Logging.Database.Container;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Database
{
    public class Installer: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For(typeof(IDatabaseLogger<>))
                    .ImplementedBy(typeof(DatabaseLogger<>))
                    .NamedAutomatically("DatabaseLogger"),

                Component
                    .For<IDatabaseLoggerConfiguration>()
                    .ImplementedBy<DatabaseLoggerConfiguration>()
                    .IsFallback()
            );
        }
    }

}
