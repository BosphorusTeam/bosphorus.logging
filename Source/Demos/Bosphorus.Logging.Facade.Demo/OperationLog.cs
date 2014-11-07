using System;
using Bosphorus.Logging.Model;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class OperationLog: Log
    {
        public virtual Guid OperationId { get; set; }
    }
}
