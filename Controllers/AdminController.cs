using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje2.Models.Siniflar;

namespace TravelTripProje2.Controllers
{
    public class AdminController : Controller
    {
		Context x = new Context();
		[Authorize]
        public ActionResult Index()
        {
			var deger = x.BLogs.ToList();
            return View(deger);
        }
		[HttpGet]
		public ActionResult YeniBlog()
		{
			return View();
		}
		[HttpPost]
		public ActionResult YeniBlog(BLog log)
		{
			x.BLogs.Add(log);
			x.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult BlogSil(int id)
		{
			var b = x.BLogs.Find(id);
			x.BLogs.Remove(b);
			x.SaveChanges();
			return RedirectToAction("Index");

		}
		public ActionResult BlogGetir(int id)
		{
			var bl = x.BLogs.Find(id);			
			return View("BlogGetir",bl);

		}
		public ActionResult BLogGuncelle(BLog b)
		{
			var blog = x.BLogs.Find(b.Id);
			blog.Aciklama = b.Aciklama;
			blog.Baslik=b.Baslik;
			blog.Blogimage = b.Blogimage;
			blog.Tarih = b.Tarih;
			x.SaveChanges();
			return RedirectToAction("Index");
		}
		public ActionResult YorumListesi()
		{
			var yorumlar = x.Yorumlars.ToList();
			return View(yorumlar);
		}
		public ActionResult Yorumsil(int id)
		{
			var b = x.Yorumlars.Find(id);
			x.Yorumlars.Remove(b);
			x.SaveChanges();
			return RedirectToAction("YorumListesi");

		}
		public ActionResult YorumGetir(int id)
		{
			var yr = x.Yorumlars.Find(id);
			return View("YorumGetir", yr);
		}
		public ActionResult YorumGuncelle( Yorumlar y)
		{
			var yrm = x.Yorumlars.Find(y.id);
			yrm.KullaniciAdi = y.KullaniciAdi;
			yrm.Mail= y.Mail;
			yrm.Yorum = y.Yorum;
			x.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}