using System.Collections.Generic;
using System.Web.Mvc;

namespace Website.Controllers
{
	public class GalleryController : Controller
	{
		[OutputCache(CacheProfile = "GalleryProfile")]
		public ActionResult Index()
		{
			var images = new List<string>();

			string galleryPath = Server.MapPath("~/assets/img/gallery");

			if (System.IO.Directory.Exists(galleryPath))
			{
				var files = System.IO.Directory.GetFiles(galleryPath, "*.jpg");
				foreach (var file in files)
				{
					images.Add(System.IO.Path.GetFileName(file));
				}
			}

			return View(images);
		}
	}
}