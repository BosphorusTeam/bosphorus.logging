using Bosphorus.Library.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Console
{
    public class Logger : ILogger
    {
        private readonly string logFormat;
        private const string DEFAULT_FORMAT = "DateTime: {0}, Level:{1}, Message:{2}";

        public Logger()
            : this(DEFAULT_FORMAT)
        {
        }

        public Logger(string logFormat)
        {
            this.logFormat = logFormat;
        }

        public void Log<TLogModel>(TLogModel logModel) where TLogModel : ILogModel
        {
            System.Console.WriteLine(logFormat, logModel.DateTime, logModel.Level, logModel.Message);
        }
    }
}
