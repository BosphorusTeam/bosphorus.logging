using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Library.Logging.Console.Configuration;
using Bosphorus.Library.Logging.Core;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Library.Logging.Console
{
    public class Installer: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For(typeof (ILogger<>))
                    .Forward(typeof (IConsoleLogger<>))
                    .ImplementedBy(typeof (ConsoleLogger<>))
                    .IsFallback()
                    .NamedUnique(),

                Component
                    .For(typeof(IConsoleLoggerConfiguration<>))
                    .ImplementedBy(typeof(ConsoleLoggerConfiguration<>))
                    .IsFallback()
                    .NamedUnique()
            );
        }
    }

}
