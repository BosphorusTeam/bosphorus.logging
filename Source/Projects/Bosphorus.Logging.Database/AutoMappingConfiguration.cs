using Bosphorus.Library.Logging.Core;
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
            return typeof (ILogModel).IsAssignableFrom(type);
        }
    }
}