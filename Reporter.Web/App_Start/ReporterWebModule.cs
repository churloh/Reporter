using System;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Abp.Dependency;
using Abp.Localization;
using Abp.Localization.Sources.Xml;
using Abp.Modules;
using Abp.Web;
using Reporter.Web.Localization;


namespace Reporter.Web
{
    [DependsOn(typeof(ReporterDataModule), typeof(ReporterApplicationModule), typeof(ReporterWebApiModule))]
    public class ReporterWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            //Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    ReporterConsts.LocalizationSourceName,
                    HttpContext.Current.Server.MapPath("~/Localization/Reporter")
                    )
                );

            //Configure navigation/menu
            //Configuration.Navigation.Providers.Add<ReporterNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //LocalizationHelper.RegisterSource<ReporterLocalizationSource>();
        }
    }
}
