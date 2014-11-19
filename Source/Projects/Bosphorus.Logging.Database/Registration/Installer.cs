using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Library.Logging.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Database.Registration
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
            );
        }
    }

}
