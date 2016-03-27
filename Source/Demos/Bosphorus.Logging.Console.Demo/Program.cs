using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Bosphorus.Assemble.BootStrapper.Runner.Console;
using Bosphorus.Common.Application;
using Bosphorus.Logging.Console.Logger;
using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Model;
using Environment = Bosphorus.Common.Application.Environment;

namespace Bosphorus.Logging.Facade.Demo
{
    public class Program: IProgram
    {
        private readonly GenericLogger logger;
        private readonly IConsoleLogger<OperationLog> consoleLogger;

        public Program(GenericLogger logger, IConsoleLogger<OperationLog> consoleLogger)
        {
            this.logger = logger;
            this.consoleLogger = consoleLogger;
        }

        static void Main(string[] args)
        {
            ConsoleRunner.Run<Program>(Environment.Local, Perspective.Debug, args, typeof(IDemoInstaller));
        }

        public void Run(string[] args)
        {
            consoleLogger.Debug("Console logger message");

            var myLog = BuildMyLog(0);
            logger.Log(myLog);

            var myLogs = Enumerable.Range(0, 100).Select(BuildMyLog);
            logger.Log(myLogs);

            OperationLog operationLog = new OperationLog();
            operationLog.Level = LogLevel.Info;
            operationLog.OperationId = Guid.NewGuid();
            logger.Log(operationLog);

            Thread.Sleep(30000);
        }

        private static MyLog BuildMyLog(int index)
        {
            MyLog log = new MyLog();
            log.Level = LogLevel.Warn;
            log.Message = "Deneme";
            log.Temp = "Temp " + index;
            return log;
        }
    }
}
