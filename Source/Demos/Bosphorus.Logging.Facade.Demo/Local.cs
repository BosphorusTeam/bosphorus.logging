using Bosphorus.Dao.NHibernate.Configuration.Fluent.PersistenceConfigurerProvider;
using FluentNHibernate.Cfg.Db;

namespace Bosphorus.Logging.Facade.Demo
{
    public class Local : AbstractPersistenceConfigurerProvider
    {
        protected override IPersistenceConfigurer GetPersistenceProvider()
        {
            SQLiteConfiguration persistenceConfigurer = SQLiteConfiguration
                .Standard
                .UsingFile("Local.db3");

            return persistenceConfigurer;
        }
    }
}
