﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje2.Models.Siniflar;


namespace TravelTripProje2.Controllers
{
    public class AbotController : Controller
    {
		Context context = new Context();
        public ActionResult Index()
        {
			var degerler = context.Hakkimizda.ToList();
            return View(degerler);
        }
    }
}