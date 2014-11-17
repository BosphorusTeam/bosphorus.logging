using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Installerr;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Library.Logging.Core.Decoration.Exception;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Library.Logging.Core.Registration
{
    public class DecorationInstaller: AbstractWindsorInstaller, IDecoratorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Decorator
                    .For(typeof(ILogger<>))
                    .Is(typeof(ExceptionDecorator<>))
            );
        }
    }
}
