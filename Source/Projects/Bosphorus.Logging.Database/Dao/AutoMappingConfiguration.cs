using Bosphorus.Logging.Database.Common;
using Bosphorus.Logging.Model;
using FluentNHibernate.Automapping;

namespace Bosphorus.Logging.Database.Dao
{
    public class AutoMappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool IsComponent(System.Type type)
        {
            if (type == typeof(AbstractLog))
                return true;

            return false;
        }

        public override string GetComponentColumnPrefix(FluentNHibernate.Member member)
        {
            return member.Name;
        }

        public override bool ShouldMap(System.Type type)
        {
            if (typeof (ILog) == type)
                return false;

            if (LogModelConvention.IsLogModel(type))
                return true;

            return false;
        }
    }
}