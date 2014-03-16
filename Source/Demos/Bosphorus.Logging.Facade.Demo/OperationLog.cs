using System;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class OperationLog: LogModel
    {
        public virtual Guid OperationId { get; set; }
    }
}
