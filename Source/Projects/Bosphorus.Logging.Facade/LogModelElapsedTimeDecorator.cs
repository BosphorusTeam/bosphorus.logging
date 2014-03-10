using System;
using System.Collections.Generic;
using System.Text;
using Bosphorus.Library.Logging.Core;

namespace Bosphorus.Library.Logging.Facade
{
    internal class LogModelElapsedTimeDecorator: ILogModel
    {
        private readonly ILogModel decorated;
        private readonly TimeSpan elapsedTime;
        private const string LOG_MESSAGE_FORMAT = "{0} [Elapsed time: {1}]";

        public LogModelElapsedTimeDecorator(ILogModel decorated, TimeSpan elapsedTime)
        {
            this.decorated = decorated;
            this.elapsedTime = elapsedTime;
        }

        public string Message
        {
            get
            {
                string decoratedMessage = decorated.Message;
                string message = string.Format(LOG_MESSAGE_FORMAT, decoratedMessage, elapsedTime);
                return message;
            }
        }

        public LogType LogType
        {
            get { return decorated.LogType; }
        }
    }
}
