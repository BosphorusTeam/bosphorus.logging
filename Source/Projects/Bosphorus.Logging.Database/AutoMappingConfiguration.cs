using Bosphorus.Logging.Model;
using FluentNHibernate.Automapping;

namespace Bosphorus.Logging.Database
{
    public class AutoMappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool IsComponent(System.Type type)
        {
            if (type == typeof(LogModel))
                return true;

            return false;
        }

        public override string GetComponentColumnPrefix(FluentNHibernate.Member member)
        {
            return member.Name;
        }

        public override bool ShouldMap(System.Type type)
        {
            if (!typeof (ILogModel).IsAssignableFrom(type))
                return false;

            if (typeof (ILogModel) == type)
                return false;

            return true;
        }
    }
}