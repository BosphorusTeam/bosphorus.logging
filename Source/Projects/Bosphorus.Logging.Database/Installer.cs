using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Database.Configuration;
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
                    .For(typeof(ILogger<>))
                    .Forward(typeof(IDatabaseLogger<>))
                    .ImplementedBy(typeof(DatabaseLogger<>))
                    .IsFallback()
                    .NamedUnique()

                //Component
                //    .For(typeof(IDatabaseLoggerConfiguration<>))
                //    .ImplementedBy(typeof(AbstractDatabaseLoggerConfiguration<>))
                //    .IsFallback()
                //    .NamedUnique()
            );
        }
    }

}
