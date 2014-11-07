using System;

namespace Bosphorus.Logging.Model
{
    public class Log: ILog
    {
        public Log()
        {
            this.DateTime = DateTime.Now;
        }

        public virtual Guid Id { get; set; }

        public virtual string Message { get; set; }

        public virtual LogLevel Level { get; set; }

        public virtual DateTime DateTime { get; set; }
    }
}
