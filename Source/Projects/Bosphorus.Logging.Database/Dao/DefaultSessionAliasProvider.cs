using Bosphorus.Dao.Core.Session.Default.Alias;
using Bosphorus.Logging.Database.Common;

namespace Bosphorus.Logging.Database.Dao
{
    public class DefaultSessionAliasProvider: IDefaultSessionAliasProvider
    {
        private readonly string sessionAlias;

        public DefaultSessionAliasProvider(IDatabaseLoggerConfiguration configuration)
        {
            this.sessionAlias = configuration.SessionAlias;
        }

        public string GetDefaultAlias<TModel>()
        {
            if (!LogModelConvention.IsLogModel(typeof (TModel)))
            {
                return null;
            }

            return sessionAlias;
        }
    }
}
