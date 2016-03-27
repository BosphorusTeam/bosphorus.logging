using Bosphorus.Common.Api.Container;
using Bosphorus.Logging.Core.Logger;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Core
{
    public class Installer: IBosphorusInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<GenericLogger>()
            );
        }
    }

}
