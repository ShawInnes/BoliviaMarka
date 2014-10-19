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
		[OutputCache(Duration = 3600)]
		public ActionResult Index()
        {
            return View();
        }
    }
}