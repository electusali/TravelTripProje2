using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje2.Models.Siniflar;


namespace TravelTripProje2.Controllers
{
	public class DefaultController : Controller
	{
		// GET: Default
		Context c = new Context();
		public ActionResult Index()
		{
			var degerler = c.BLogs.ToList();
			return View(degerler);
		}
		public ActionResult About()
		{
			return View();

		}
		public PartialViewResult Partial()
		{
			var degerler = c.BLogs.OrderByDescending(c => c.Id).Take(3).ToList();
			return PartialView(degerler);
		}
		public PartialViewResult Partial2()
		{
			var deger = c.BLogs.Where(c=>c.Id==1).ToList();
			return PartialView(deger);
		}
		public PartialViewResult Partial3()
		{
			var deger = c.BLogs.Take(10).ToList();
			return PartialView(deger);
		}
		public PartialViewResult Partial4()
		{
			var deger = c.BLogs.Take(3).ToList();
			return PartialView(deger);
		}
		public PartialViewResult Partial5()
		{
			var deger = c.BLogs.Take(3).OrderByDescending(c => c.Id).ToList();
			return PartialView(deger);
		}
	}
}