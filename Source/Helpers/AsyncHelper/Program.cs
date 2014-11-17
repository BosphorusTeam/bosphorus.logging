using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bosphorus.BootStapper.Common;
using Bosphorus.BootStapper.Program;
using Bosphorus.BootStapper.Runner;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Model;
using Environment = Bosphorus.BootStapper.Common.Environment;

namespace AsyncHelper
{
    class Program: IProgram
    {
        private readonly ILogger<Log> logger;

        public Program(ILogger<Log> logger)
        {
            this.logger = logger.Threaded();
        }

        private static void Main(string[] args)
        {
            ConsoleRunner.Run<Program>(Environment.Local, Perspective.Debug, args);
            Console.WriteLine("Finished");
            Thread.Sleep(5000);
        }

        public async void Run(string[] args)
        {
            Log log = new Log();
            log.Message = await SerializeAsync(args);
            await logger.LogAsync(log);
        }

        private async static Task<string> SerializeAsync(string[] args)
        {
            Console.WriteLine("Serialization started");
            Task<string> task = Task.Factory.StartNew(() => Serialize(args));
            return await task;
        }

        private static string Serialize(string[] args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Serialization finished");
            return "{...}";
        }
    }
}
