using System;
using System.Linq;
using System.Reflection;

namespace Bosphorus.Common
{
    public class AssemblyRepository
    {
        public Assembly[] GetAssemblies()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(
                a => !a.FullName.StartsWith("System.") &&
                     !a.FullName.StartsWith("Microsoft.") &&
                     !a.FullName.Contains("mscorlib")).ToArray();

            return assemblies;
        }
    }
}
