using System.Web.Mvc;

namespace Reporter.Web.Controllers
{
    public class AboutController : ReporterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}