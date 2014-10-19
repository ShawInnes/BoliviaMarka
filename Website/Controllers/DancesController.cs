using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
	[RoutePrefix("Dances")]
	public class DancesController : Controller
	{
		private static readonly List<DanceInfo> Dances;

		static DancesController()
		{
			Dances = new List<DanceInfo>
			{
				new DanceInfo
				{
					Name = "Caporales",
					ShortDescription =
						@"The Caporales is a Bolivian dance that stems from Afro-Andean dances in the Yungas region, such as the Tundiki and Saya. The dance represents the foremen who were in charge of the slaves in colonial times.",
					ImagePath = "/assets/img/dances/caporales.jpg",
					AudioDescription = "Jilguero Flores by Los Kjarkas",
					AudioPath = "/assets/audio/Caporales-Kjarkas-JilgueroFlores.mp3",
					YouTube = "1bL1UxTfgRg"
				},
				new DanceInfo
				{
					Name = "Morenada",
					ShortDescription =
						"The Morenada is a music and dance style from the Bolivian Andes characterized by a mixture of African and Indigenous elements.",
					ImagePath = "/assets/img/dances/morenada2.jpg",
					AudioDescription = "Idilio by Maria Juana",
					AudioPath = "/assets/audio/Morenada-MariaJuana-Idilio.mp3",
					YouTube = "exiQ6dY2zW0"
				},
				new DanceInfo
				{
					Name = "Diablada",
					ShortDescription =
						"The Diablada or Danza de los Diablos (English: Dance of the Devils), is a dance characterized by the mask and devil suit worn by the performers.",
					ImagePath = "/assets/img/dances/diablada.jpg",
					AudioDescription = "El Chiru Chiru by Llajtaymanta",
					AudioPath = "/assets/audio/Diablada-Llajtaymanta-ElChiruChiru.mp3",
					YouTube = "6is3LGLJ_68"
				},
				new DanceInfo
				{
					Name = "Tinku",
					ShortDescription =
						@"Tinku, a Bolivian Aymara tradition, began as a form of ritualistic combat. In the language of Aymara it means ""physical attack"".",
					ImagePath = "/assets/img/dances/tinku.jpg",
					AudioDescription = "Señora Chichera by Inti Illimani",
					AudioPath = "/assets/audio/Tinku-IntiIllimani-SenoraChichera.mp3",
					YouTube = "2kq0NjJy8XA"
				},
				new DanceInfo
				{
					Name = "Tobas",
					ShortDescription =
						"The Tobas is a folk dance from Bolivia. The folkloric dance of the Tobas speaks of the ancient past of Bolivia. It has roots in a time when the Incas were the predominant force in the Andean highlands region. Tobas is an athletic dance comprising agile steps accentuated with many jumps and bounds.",
					ImagePath = "/assets/img/dances/tobas1.jpg",
					AudioDescription = "Es Asi by Kala Mara",
					AudioPath = "/assets/audio/Tobas-KalaMarka-EsAsi.mp3",
					YouTube = "a93AaISw8h0"
				},
				new DanceInfo
				{
					Name = "Cueca",
					ShortDescription =
						@"In Bolivia there are lots of different Cueca styles according to the region: Cueca Paceña, Cueca Cochabambina, Cueca Chuquisaqueña, Cueca Tarijeña, Cueca Potosina y Cueca Chaqueña. What they have in common is their rhythm, but they differ quite a lot in velocity, costumes and style. The Cueca styles of La Paz, Potosí and Sucre are the elegant ones, whereas in Cochabamba and Tarija the style is much more lively.In Bolivia, it is usually called ""Cuequita Boliviana""",
					ImagePath = "/assets/img/dances/cueca.jpg",
					AudioDescription = "El Regresso by Bonanza",
					AudioPath = "/assets/audio/Cueca-Bonanza-ElRegresso.mp3",
					YouTube = "Y82WS4lwh4I"
				},
			};
		}

		[OutputCache(Duration = 3600)]
		[Route("")]
		public ActionResult Index()
		{
			return View(Dances);
		}

		[OutputCache(Duration = 3600)]
		[Route("{dance}")]
		public ActionResult Info(string dance)
		{
			var item = Dances.FirstOrDefault(p => p.Name.Equals(dance));
			
			if (item == null)
				return RedirectToAction("Index");

			return View(item);
		}
	}
}