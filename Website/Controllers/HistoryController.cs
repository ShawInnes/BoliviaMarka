using System.Web.Mvc;

namespace Website.Controllers
{
	public class HistoryController : Controller
	{
        [OutputCache(CacheProfile = "HistoryProfile")]
        public ActionResult Index()
		{
			return View();
		}
	}
}