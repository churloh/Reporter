using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.EntityFramework;

namespace Reporter
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ReporterCoreModule))]
    public class ReporterDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
