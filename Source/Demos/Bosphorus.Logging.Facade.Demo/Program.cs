using System;
using Bosphorus.BootStapper.Common;
using Bosphorus.BootStapper.Program;
using Bosphorus.BootStapper.Runner;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Model;
using Environment = Bosphorus.BootStapper.Common.Environment;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class Program: IProgram
    {
        private readonly Logger logger;

        public Program(Logger logger)
        {
            this.logger = logger;
        }

        public void Run(string[] args)
        {
            MyLog log = new MyLog();
            log.Level = LogLevel.Warn;
            log.Message = "Deneme";
            log.Temp = "Temp 2";
            logger.Log(log);

            OperationLog operationLog = new OperationLog();
            operationLog.Level = LogLevel.Info;
            operationLog.OperationId = Guid.NewGuid();
            logger.Log(operationLog);
        }

        static void Main(string[] args)
        {
            ConsoleRunner.Run<Program>(Environment.Development, Perspective.Debug, args);
        }
    }
}
