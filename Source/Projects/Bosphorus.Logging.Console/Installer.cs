using Bosphorus.Common.Api.Container;
using Bosphorus.Logging.Console.Logger;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Component = Castle.MicroKernel.Registration.Component;

namespace Bosphorus.Logging.Console
{
    public class Installer: IBosphorusInstaller
    {

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For(typeof (IConsoleLogger<>))
                    .ImplementedBy(typeof (ConsoleLogger<>))
                    .NamedFull(),

                Component
                    .For(typeof (IConfiguration<>))
                    .ImplementedBy(typeof(DefaultConfiguration<>))
                    .IsFallback()
            );
        }
    }

}
