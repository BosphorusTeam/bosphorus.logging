using Bosphorus.Dao.Core.Dao;
using Bosphorus.Library.Logging.Core.Logger;
using Bosphorus.Logging.Model;

namespace Bosphorus.Logging.Database
{
    public class DatabaseLogger: ILogger
    {
        private readonly IDao<ILogModel> logDao;

        public DatabaseLogger(IDao<ILogModel> logDao)
        {
            this.logDao = logDao;
        }

        public void Log<TLogModel>(TLogModel logModel) where TLogModel : ILogModel
        {
            logDao.Save(logModel);
        }
    }
}
