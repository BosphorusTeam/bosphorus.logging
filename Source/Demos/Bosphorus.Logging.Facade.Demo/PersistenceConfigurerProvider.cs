using Bosphorus.Dao.NHibernate.Fluent.PersistenceConfigurerProvider;
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
                .UsingFile(@".\Demo.db3")
                .ShowSql();
        }
    }
}
