using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    [RoutePrefix("Dances")]
    public class DancesController : Controller
    {
        [OutputCache(CacheProfile = "DancesProfile")]
        [Route("")]
        public ActionResult Index()
        {
            return View(DanceInfoRepository.Dances);
        }

        [OutputCache(CacheProfile = "DancesProfile")]
        [Route("{dance}")]
        public ActionResult Info(string dance)
        {
            DanceInfo item = DanceInfoRepository.Dances.FirstOrDefault(p => p.Name.Equals(dance));

            if (item == null)
                return RedirectToAction("Index");

            if (!string.IsNullOrWhiteSpace(item.LongDescriptionPath))
            {
                string filename = Server.MapPath(item.LongDescriptionPath);
                
                if (System.IO.File.Exists(filename))
                {
                    item.LongDescription = System.IO.File.ReadAllText(filename);
                }
            }

            return View(item);
        }
    }
}