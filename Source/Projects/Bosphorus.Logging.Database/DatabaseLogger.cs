using Bosphorus.Dao.Core.Dao;
using Bosphorus.Library.Logging.Core;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database
{
    public class DatabaseLogger<TLog> : IDatabaseLogger<TLog>, ILogger<TLog> 
        where TLog : ILog
    {
        private readonly IDao logDao;

        public DatabaseLogger(IDao logDao)
        {
            this.logDao = logDao;
        }

        public void Log(TLog log)
        {
            logDao.Insert(log);
        }
    }
}
