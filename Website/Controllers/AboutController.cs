using System.Web.Mvc;

namespace Website.Controllers
{
	public class AboutController : Controller
	{
		// GET: Home
		[OutputCache(Duration = 3600)]
		public ActionResult Index()
		{
			return View();
		}
	}
}