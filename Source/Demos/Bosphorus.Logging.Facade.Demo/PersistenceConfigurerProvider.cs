using Bosphorus.Dao.NHibernate.Session.Provider.Factory;
using FluentNHibernate.Cfg.Db;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class PersistenceConfigurerProvider : IPersistenceConfigurerProvider
    {
        //TODO: http://webdotnet.googlecode.com/svn-history/r98/trunk/Src/Commons.Persistence.NHibernate/NHibernateConfigHelper.cs
        public IPersistenceConfigurer GetPersistenceProvider(string providerName)
        {
            return
                SQLiteConfiguration
                .Standard
                .ConnectionString(@"data source=.\Demo.db3")
                .ShowSql();
        }
    }
}
