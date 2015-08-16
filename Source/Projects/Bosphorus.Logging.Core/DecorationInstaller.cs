using Bosphorus.Container.Castle.Registration;
using Bosphorus.Container.Castle.Registration.Fluent.Decoration;
using Bosphorus.Container.Castle.Registration.Installer;
using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Core.Logger.Decoration.Exception;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Core
{
    public class DecorationInstaller: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Decorator
                    .Of(typeof(ILogger<>))
                    .Is(typeof(ExceptionDecorator<>))
            );
        }
    }
}
