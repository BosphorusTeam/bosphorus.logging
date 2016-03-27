using System.Collections.Generic;
using Bosphorus.Dao.Core.Dao;
using Bosphorus.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database.Logger
{
    public class DatabaseLogger<TLog> : IDatabaseLogger<TLog>, ILogger<TLog> 
        where TLog : ILog
    {
        private readonly IDao<TLog> dao;

        public DatabaseLogger(IDao<TLog> dao)
        {
            this.dao = dao;
        }

        public void Log(TLog log)
        {
            dao.Insert(log);
        }

        public void Log(IEnumerable<TLog> logs)
        {
            dao.Insert(logs);
        }
    }
}
