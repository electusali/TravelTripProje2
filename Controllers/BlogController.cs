using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje2.Models.Siniflar;
using System.Data.SqlClient;
using System.Data;

namespace TravelTripProje2.Controllers
{
    public class BlogController : Controller
    {
		Context x = new Context();
		BlogYorum blogYorum = new BlogYorum();
		public ActionResult Index()
        {
			//	var blog = x.BLogs.ToList();
			blogYorum.Deger1 = x.BLogs.ToList();
			blogYorum.Deger3 = x.BLogs.OrderByDescending(x => x.Id).Take(3).ToList();
            return View(blogYorum);
        }
		
		public ActionResult BlogDetay(int id)
		{
			blogYorum.Deger1 = x.BLogs.Where(x => x.Id == id).ToList();
			blogYorum.Deger2 = x.Yorumlars.Where(x => x.Blogid == id).ToList();
			//var blogs = x.BLogs.Where(x => x.Id == id).ToList();
			return View(blogYorum);
		}

		[HttpGet]
		public PartialViewResult BlogYorum(int id)
		{
			ViewBag.deger= id;
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult BlogYorum(BLog blg)
		{
			x.BLogs.Add(blg);
			x.SaveChanges();
			return PartialView();
		}
    }
}