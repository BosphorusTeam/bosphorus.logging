using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bosphorus.BootStapper.Runner.Console;
using Bosphorus.Common.Core.Application;
using Bosphorus.Logging.Core.Logger;
using Environment = Bosphorus.Common.Core.Application.Environment;

namespace Bosphorus.Logging.Database.Demo
{
    public class Program: IProgram
    {
        private readonly ILogger<MyLog> logger;

        public Program(ILogger<MyLog> logger)
        {
            this.logger = logger;
        }

        public void Run(string[] args)
        {
            IList<MyLog> logList = new List<MyLog>();
            for (int i = 0; i < 10000; i++)
            {
                MyLog log = new MyLog();
                logList.Add(log);
            }

            logger.Log(logList);
        }

        static void Main(string[] args)
        {
            ConsoleRunner.Run<Program>(Environment.Local, Perspective.Debug, args);
        }

    }
}
