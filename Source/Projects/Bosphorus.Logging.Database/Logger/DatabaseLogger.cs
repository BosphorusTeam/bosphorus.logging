using System.Collections.Generic;
using Bosphorus.Dao.Core.Dao;
using Bosphorus.Dao.Core.Session;
using Bosphorus.Dao.Core.Session.Provider;
using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database.Logger
{
    public class DatabaseLogger<TLog> : IDatabaseLogger<TLog>, ILogger<TLog> 
        where TLog : ILog
    {
        private readonly IDao<TLog> logDao;

        public DatabaseLogger(IDao<TLog> logDao)
        {
            this.logDao = logDao;
        }

        public void Log(TLog log)
        {
            logDao.Insert(log);
        }

        public void Log(IEnumerable<TLog> logs)
        {
            logDao.Insert(logs);
        }
    }
}
