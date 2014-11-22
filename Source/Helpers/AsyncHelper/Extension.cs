using System;
using System.Threading.Tasks;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Model;

namespace AsyncHelper
{
    public static class Extension
    {
        public static async Task LogAsync(this ILogger<ILog> extended, ILog log)
        {
            Console.WriteLine("Logging strated");
            await Task.Factory.StartNew(() => extended.Log(log));
            Console.WriteLine("Logging finished");
        }
    }
}
