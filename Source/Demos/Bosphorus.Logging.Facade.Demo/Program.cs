using System;
using Bosphorus.Container.Castle.Facade;
using Bosphorus.Library.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class Program: IProgram
    {
        private readonly ILogger logger;

        public Program(ILogger logger)
        {
            this.logger = logger;
        }

        public void Run(string[] args)
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
            ConsoleRunner.Run<Program>(args);
        }
    }
}
