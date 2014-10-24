using System.Web;
using Abp.Localization.Sources.Xml;

namespace Reporter.Web.Localization
{
    public class ReporterLocalizationSource : XmlLocalizationSource
    {
        public ReporterLocalizationSource()
            : base("Reporter", HttpContext.Current.Server.MapPath("/Localization/Reporter"))
        {
        }
    }
}