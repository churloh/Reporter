using Abp.Web.Mvc.Controllers;

namespace Reporter.Web.Controllers
{
    public abstract class ReporterControllerBase : AbpController
    {
        protected ReporterControllerBase()
        {
            LocalizationSourceName = ReporterConsts.LocalizationSourceName;
        }
    }
}