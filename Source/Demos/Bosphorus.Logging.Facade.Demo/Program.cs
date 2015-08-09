using System;
using System.Threading;
using Bosphorus.BootStapper.Common;
using Bosphorus.BootStapper.Program;
using Bosphorus.BootStapper.Runner.Console;
using Bosphorus.Logging.Console;
using Bosphorus.Logging.Core;
using Bosphorus.Logging.Core.Facade;
using Bosphorus.Logging.Model;
using Environment = Bosphorus.BootStapper.Common.Environment;

namespace Bosphorus.Logging.Facade.Demo
{
    public class Program: IProgram
    {
        private readonly Logger logger;
        private readonly IConsoleLogger<OperationLog> consoleLogger;

        public Program(Logger logger, IConsoleLogger<OperationLog> consoleLogger)
        {
            this.logger = logger;
            this.consoleLogger = consoleLogger;
        }

        static void Main(string[] args)
        {
            ConsoleRunner.Run<Program>(Environment.Local, Perspective.Debug, args);
        }

        public void Run(string[] args)
        {
            consoleLogger.Debug("Console logger message");

            MyLog log = new MyLog();
            log.Level = LogLevel.Warn;
            log.Message = "Deneme";
            log.Temp = "Temp 2";
            logger.Log(log);

            OperationLog operationLog = new OperationLog();
            operationLog.Level = LogLevel.Info;
            operationLog.OperationId = Guid.NewGuid();
            logger.Log(operationLog);

            Thread.Sleep(3000);
        }
    }
}
