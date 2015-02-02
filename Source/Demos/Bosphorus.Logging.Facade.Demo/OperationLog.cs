using System;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Facade.Demo
{
    public class OperationLog: AbstractLog
    {
        public virtual Guid OperationId { get; set; }
    }
}
