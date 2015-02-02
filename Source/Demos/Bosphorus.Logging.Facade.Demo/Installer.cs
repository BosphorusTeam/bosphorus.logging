using Bosphorus.Container.Castle.Fluent.Decoration;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Dao.NHibernate.Dao;
using Bosphorus.Logging.Core;
using Bosphorus.Logging.Core.Decoration.Thread;
using Bosphorus.Logging.Database;
using Bosphorus.Logging.Database.Container;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Facade.Demo
{
    public class Installer: AbstractWindsorInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For(typeof (ILogger<>))
                    .ImplementedBy(typeof(DatabaseLogger<>)),

                Decorator
                    .Of(typeof(ILogger<>))
                    .Is(typeof(ThreadedDecorator<>)),

                LoggingComponent
                    .IDao
                    .ImplementedBy(typeof(NHibernateStatelessDao<>))
            );
        }
    }
}
