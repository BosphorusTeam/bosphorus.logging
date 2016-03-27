using Bosphorus.Common.Api.Container;
using Bosphorus.Logging.Database.Logger;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Database
{
    public class Installer: IBosphorusInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For(typeof(IDatabaseLogger<>))
                    .ImplementedBy(typeof(DatabaseLogger<>))
                    .NamedFull()
            );
        }
    }

}
