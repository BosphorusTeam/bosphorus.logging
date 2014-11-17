using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Log(args);
            Console.WriteLine("Completed");
            Thread.Sleep(10000);
        }

        private async static void Log(string[] args)
        {
            string serialize = await Serialize(args);
            await Task.Run(() => Console.WriteLine(serialize));
            Console.WriteLine("ddd");
        }

        private async static Task<string> Serialize(string[] args)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "{...}";
            }
            );
        }
    }
}
