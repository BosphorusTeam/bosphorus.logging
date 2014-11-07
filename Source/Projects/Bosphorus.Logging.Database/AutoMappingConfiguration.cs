using Bosphorus.Logging.Model;
using FluentNHibernate.Automapping;

namespace Bosphorus.Logging.Database
{
    public class AutoMappingConfiguration : DefaultAutomappingConfiguration
    {
        public override bool IsComponent(System.Type type)
        {
            if (type == typeof(Log))
                return true;

            return false;
        }

        public override string GetComponentColumnPrefix(FluentNHibernate.Member member)
        {
            return member.Name;
        }

        public override bool ShouldMap(System.Type type)
        {
            if (!typeof (ILog).IsAssignableFrom(type))
                return false;

            if (typeof (ILog) == type)
                return false;

            return true;
        }
    }
}