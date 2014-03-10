using System;

namespace Bosphorus.Library.Logging.Core
{
    public interface ILogModel
    {
        Guid Id { get; }

        string Message { get; }

        LogLevel Level { get; }

        DateTime DateTime { get; }

    }
}
