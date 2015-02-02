using Bosphorus.Container.Castle.Registration;
using Bosphorus.Logging.Core.Facade;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Core
{
    public class Installer: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For<Logger>()
            );
        }
    }

}
