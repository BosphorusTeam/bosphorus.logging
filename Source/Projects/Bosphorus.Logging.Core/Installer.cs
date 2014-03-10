using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Library.Logging.Core
{
    public class Installer: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes
                    .FromAssemblyInDirectory(new AssemblyFilter("."))
                    .BasedOn(typeof(ILogger))
                    .WithServiceAllInterfaces()
            );
        }
    }
}
