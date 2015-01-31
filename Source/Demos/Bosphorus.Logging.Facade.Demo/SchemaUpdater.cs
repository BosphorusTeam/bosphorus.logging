using Bosphorus.BootStapper.Common;
using Bosphorus.Dao.NHibernate.Configuration.Fluent.ConfigurationProcessor;
using NHibernate.Tool.hbm2ddl;
using Environment = Bosphorus.BootStapper.Common.Environment;

namespace Bosphorus.Library.Logging.Facade.Demo
{
    public class SchemaUpdater : AbstractConfigurationProcessor
    {
        private readonly Environment environment;
        private readonly Perspective perspective;

        public SchemaUpdater(Environment environment, Perspective perspective)
        {
            this.environment = environment;
            this.perspective = perspective;
        }

        protected override void Process(NHibernate.Cfg.Configuration configuration)
        {
            if (environment != Environment.Local)
            {
                return;
            }

            bool showSql = perspective == Perspective.Debug;
            bool doUpdate = perspective == Perspective.Debug;

            SchemaUpdate schemaUpdate = new SchemaUpdate(configuration);
            schemaUpdate.Execute(showSql, doUpdate);
        }
    }
}