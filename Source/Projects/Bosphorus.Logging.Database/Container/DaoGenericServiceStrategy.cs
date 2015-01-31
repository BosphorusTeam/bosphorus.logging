using System;
using Bosphorus.Logging.Database.Common;
using Castle.Core;
using Castle.MicroKernel.Handlers;

namespace Bosphorus.Logging.Database.Container
{
    internal class DaoGenericServiceStrategy : IGenericServiceStrategy
    {
        public bool Supports(Type service, ComponentModel component)
        {
            Type[] genericArguments = service.GetGenericArguments();
            Type modelType = genericArguments[0];
            bool isLogModel = LogModelConvention.IsLogModel(modelType);
            return isLogModel;
        }
    }
}