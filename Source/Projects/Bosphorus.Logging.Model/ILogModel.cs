using System;

namespace Bosphorus.Logging.Model
{
    public interface ILogModel
    {
        Guid Id { get; }

        string Message { get; }

        LogLevel Level { get; }

        DateTime DateTime { get; }

    }
}
