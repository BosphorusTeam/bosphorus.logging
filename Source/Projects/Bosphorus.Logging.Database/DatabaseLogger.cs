using System.Collections;
using Bosphorus.Dao.Core.Dao;
using Bosphorus.Dao.Core.Session.Manager;
using Bosphorus.Dao.Core.Session.Manager.Factory;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Database.Configuration;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database
{
    public class DatabaseLogger<TLog> : IDatabaseLogger<TLog>, ILogger<TLog> 
        where TLog : ILog
    {
        private readonly IDao<TLog> logDao;
        private readonly ISessionManager sessionManager;

        public DatabaseLogger(IDatabaseLoggerConfiguration<TLog> configuration, ISessionManagerFactory sessionManagerFactory, IDao<TLog> logDao)
        {
            this.logDao = logDao;
            this.sessionManager = sessionManagerFactory.Build(configuration.SessionManagerCreationArguments);
        }

        public void Log(TLog log)
        {
            logDao.Insert(sessionManager.Current, log);
        }
    }
}
