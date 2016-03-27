using Bosphorus.Logging.Console.Logger;
using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Core.Logger.Decoration.Buffered;
using Bosphorus.Logging.Core.Logger.Decoration.Thread;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Facade.Demo
{
    public class Installer: IDemoInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For(typeof(ILogger<>))
                    .ImplementedBy(typeof(ConsoleLogger<>)),

                Component
                    .For(typeof(ILogger<>))
                    .ImplementedBy(typeof(BufferedDecorator<>))
                    .IsDefault(),

                Component
                    .For(typeof(ILogger<>))
                    .ImplementedBy(typeof(ThreadedDecorator<>))
                    .IsDefault()
            );
        }
    }
}
