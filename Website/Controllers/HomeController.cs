using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
	public class HomeController : Controller
    {
        // GET: Home
		[OutputCache(CacheProfile = "HomeProfile")]
		public ActionResult Index()
        {
            return View();
        }
    }
}