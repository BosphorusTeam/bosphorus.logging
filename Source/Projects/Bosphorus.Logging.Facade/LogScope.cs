using System;
using System.Collections.Generic;
using System.Text;
using Bosphorus.Library.Logging.Core;
using System.Diagnostics;

namespace Bosphorus.Library.Logging.Facade
{
    internal delegate void WriteLogDelegate(ILogModel logModel);

    internal class LogScope : IDisposable
    {
        private readonly ILogModel logModel;
        private readonly WriteLogDelegate writeLogDelegate;
        private readonly Stopwatch stopwatch;

        public LogScope(ILogModel logModel, WriteLogDelegate writeLogDelegate)
        {
            this.logModel = logModel;
            this.writeLogDelegate = writeLogDelegate;
            this.stopwatch = new Stopwatch();
            stopwatch.Start();
        }

        public void Dispose()
        {
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            ILogModel elapsedTimeLogModel = new LogModelElapsedTimeDecorator(logModel, elapsedTime);
            writeLogDelegate.Invoke(elapsedTimeLogModel);
        }
    }
}
