using System;

namespace Bosphorus.Logging.Model
{
    public interface ILog
    {
        Guid Id { get; }

        string Message { get; set; }

        LogLevel Level { get; set; }

        DateTime DateTime { get; }

    }
}
