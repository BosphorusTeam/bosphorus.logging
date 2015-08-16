using Bosphorus.Configuration.Core;
using Bosphorus.Configuration.Core.Parameter;
using Bosphorus.Configuration.Default.Parameter.InMemory;

namespace Bosphorus.Logging.Facade.Demo
{
    public class ParameterProvider: InMemoryParameterProvider, IParameterProvider
    {
        public ParameterProvider()
        {
            //SetValue("Bosphorus.Dao.Core.Session.Provider.Extension.DefaultSessionType", typeof(NHibernateStatefulSession));
            SetValue("Bosphorus.Logging.Console.OperationLog.LogFormat", "DateTime: {0}, Message:{1}");
        }
    }
}
