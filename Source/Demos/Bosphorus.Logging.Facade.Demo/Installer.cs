﻿using Bosphorus.Configuration.Core;
using Bosphorus.Configuration.Core.Parameter;
using Bosphorus.Container.Castle.Registration;
using Bosphorus.Container.Castle.Registration.Installer;
using Bosphorus.Logging.Console;
using Bosphorus.Logging.Console.Logger;
using Bosphorus.Logging.Core.Logger;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Bosphorus.Logging.Facade.Demo
{
    public class Installer: AbstractWindsorInstaller, IInfrastructureInstaller
    {
        protected override void Install(IWindsorContainer container, IConfigurationStore store, FromTypesDescriptor allLoadedTypes)
        {
            container.Register(
                Component
                    .For<IParameterProvider>()
                    .ImplementedBy<ParameterProvider>(),

                Component
                    .For(typeof (ILogger<>))
                    .ImplementedBy(typeof(ConsoleLogger<>))
                /*
                Decorator
                    .Of(typeof(ILogger<>))
                    .Is(typeof(ThreadedDecorator<>))
                */
            );
        }
    }
}
