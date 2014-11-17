using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Library.Logging.Console;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Library.Logging.Core.Decoration.Thread;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class Installer: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For(typeof(ILogger<>))
                    .ImplementedBy(typeof(ConsoleLogger<>))
                    .Named("Temp")
                    .IsDefault(),

                Decorator
                    .For(typeof(ILogger<>))
                    .Is(typeof(ThreadedDecorator<>))
            );
        }
    }

}
