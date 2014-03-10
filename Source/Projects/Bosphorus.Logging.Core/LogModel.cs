using System;

namespace Bosphorus.Library.Logging.Core
{
    public class LogModel: ILogModel
    {
        public LogModel()
        {
            this.DateTime = DateTime.Now;
        }

        public virtual Guid Id { get; set; }

        public virtual string Message { get; set; }

        public virtual LogLevel Level { get; set; }

        public virtual DateTime DateTime { get; set; }
    }
}
