using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Core.Logger.Decoration.Buffered
{
    public class BufferedDecorator<TLog>: ILogger<TLog> 
        where TLog : ILog
    {
        private readonly ILogger<TLog> decorated;
        private readonly ThreadLocal<List<TLog>> buffer;
        private readonly ThreadLocal<Timer> flushTimer;

        public BufferedDecorator(ILogger<TLog> decorated)
        {
            this.decorated = decorated;
            this.buffer = new ThreadLocal<List<TLog>>(() => new List<TLog>());
            this.flushTimer = new ThreadLocal<Timer>(() => new Timer(OnFlushTimerCallback, buffer.Value, -1, -1));
            this.flushTimer.Value.Change(10000, 0);
        }

        private void OnFlushTimerCallback(object state)
        {
            List<TLog> currentBuffer = state as List<TLog>;
            Invalidate(currentBuffer);
        }

        public void Log(TLog log)
        {
            buffer.Value.Add(log);
            SafeInvalidate();
        }

        public void Log(IEnumerable<TLog> logs)
        {
            buffer.Value.AddRange(logs);
            SafeInvalidate();
        }

        private void SafeInvalidate()
        {
            if (buffer.Value.Count < 50)
            {
                return;
            }

            Invalidate(buffer.Value);
        }

        private void Invalidate(List<TLog> logs)
        {
            decorated.Log(logs);
            logs.Clear();
            flushTimer.Value.Change(10000, 0);
        }

    }
}
