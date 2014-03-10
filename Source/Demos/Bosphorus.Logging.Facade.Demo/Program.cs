using System;
using Bosphorus.Library.Logging.Core;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class Program
    {
        private readonly ILogger logger;

        public Program(ILogger logger)
        {
            this.logger = logger;
        }

        private void Run()
        {
            MyLogModel logModel = new MyLogModel();
            logModel.Level = LogLevel.Warn;
            logModel.Message = "Deneme";
            logModel.Temp = "Temp 2";
            logger.Log(logModel);

            OperationLog operationLog = new OperationLog();
            operationLog.Level = LogLevel.Info;
            operationLog.OperationId = Guid.NewGuid();
            logger.Log(operationLog);
        }

        static void Main(string[] args)
        {
            IWindsorContainer container = new WindsorContainer();
            container.Install(
                FromAssembly.InDirectory(new AssemblyFilter("."))
            );
            container.Register(Component.For<Program>());

            Program program = container.Resolve<Program>();
            program.Run();
        }
    }
}
