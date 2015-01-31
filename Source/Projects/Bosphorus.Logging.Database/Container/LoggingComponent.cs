using System;
using Bosphorus.Dao.Core.Dao;
using Castle.MicroKernel.Handlers;
using Castle.MicroKernel.Registration;

namespace Bosphorus.Logging.Database.Container
{
    public class LoggingComponent
    {
        public class IDao
        {
            private static readonly IGenericServiceStrategy genericServiceStrategy;

            static IDao()
            {
                genericServiceStrategy = new DaoGenericServiceStrategy();
            }

            public static IRegistration ImplementedBy(Type daoImlementationType)
            {
                return Component
                    .For(typeof (IDao<>))
                    .ImplementedBy(daoImlementationType, genericServiceStrategy);
            }
        }
    }
}