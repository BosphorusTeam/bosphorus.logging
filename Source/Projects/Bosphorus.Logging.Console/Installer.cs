using Bosphorus.Container.Castle.Registration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Console
{
    public class Installer: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For(typeof(IConsoleLogger<>))
                    .ImplementedBy(typeof (ConsoleLogger<>))
                    .NamedAutomatically("ConsoleLogger"),

                Component
                    .For(typeof(IConsoleLoggerConfiguration<>))
                    .ImplementedBy(typeof(ConsoleLoggerConfiguration<>))
                    .IsFallback()
            );
        }
    }

}
