using System.Web.Mvc;

namespace Website.Controllers
{
	public class HistoryController : Controller
	{
		// GET: Home
		[OutputCache(Duration = 3600)]
		public ActionResult Index()
		{
			return View();
		}
	}
}