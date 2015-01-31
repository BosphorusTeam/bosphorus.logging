using System;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database.Common
{
    internal class LogModelConvention
    {
        private static readonly Type logInterfaceType;

        static LogModelConvention()
        {
            logInterfaceType = typeof (ILog);
        }

        public static bool IsLogModel(Type modelType)
        {
            bool isAssignableFrom = logInterfaceType.IsAssignableFrom(modelType);
            return isAssignableFrom;
        }
    }
}
