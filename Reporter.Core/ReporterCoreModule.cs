using System.Reflection;
using Abp.Dependency;
using Abp.Modules;

namespace Reporter
{
    public class ReporterCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
