using System;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class OperationLog: LogModel
    {
        public virtual Guid OperationId { get; set; }
    }
}
