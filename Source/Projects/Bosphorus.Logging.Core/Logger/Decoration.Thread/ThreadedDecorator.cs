using System.Collections.Generic;
using System.Threading.Tasks;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger.Decoration.Thread
{
    public class ThreadedDecorator<TLog> : ILogger<TLog> 
        where TLog : ILog
    {
        private readonly ILogger<TLog> decorated;

        public ThreadedDecorator(ILogger<TLog> decorated)
        {
            this.decorated = decorated;
        }

        public void Log(TLog log)
        {
            Task.Factory.StartNew(() => decorated.Log(log));
        }

        public void Log(IEnumerable<TLog> logs)
        {
            Task.Factory.StartNew(() => decorated.Log(logs));
        }
    }
}
