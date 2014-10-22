using System.Web.Mvc;

namespace Website.Controllers
{
	public class AboutController : Controller
	{
		// GET: Home
		[OutputCache(CacheProfile = "AboutProfile")]
		public ActionResult Index()
		{
			return View();
		}
	}
}   