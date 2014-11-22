using Bosphorus.Container.Castle.Fluent;
using Bosphorus.Container.Castle.Fluent.Decoration;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Library.Logging.Core.Decoration.Thread;
using Bosphorus.Logging.Database;
using Bosphorus.Logging.Database.Configuration;
using Bosphorus.Logging.Model;
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
                    .ImplementedBy(typeof(DatabaseLogger<>)),

                //Component
                //    .For(typeof(IDatabaseLoggerConfiguration<>))
                //    .ImplementedBy(typeof(DatabaseLoggerConfiguration<>)),

                Decorator
                    .Of(typeof(ILogger<>))
                    .Is(typeof(ThreadedDecorator<>))
            );
        }
    }
}
