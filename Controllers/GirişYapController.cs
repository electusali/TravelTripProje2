using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProje2.Models.Siniflar;


namespace TravelTripProje2.Controllers
{
    public class GirişYapController : Controller
    {
		// GET: GirişYap
		Context x = new Context();
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Login(Admin admin)
		{
			var bilgi = x.Admins.FirstOrDefault(x => x.Kullanici == admin.Kullanici && x.Sifre == admin.Sifre);
			if (bilgi!=null)
			{
				FormsAuthentication.SetAuthCookie(bilgi.Kullanici, false);
				Session["Kullanici"] = bilgi.Kullanici.ToString();
				return RedirectToAction("Index", "Admin");
			}
			else
			{
				return View();
			}
		}
		public ActionResult LogOut()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Login", "GirişYap");
		}
    }
}