using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje2.Models.Siniflar
{
	public class BlogYorum
	{
		public IEnumerable<BLog> Deger1 { get; set; }
		public IEnumerable<Yorumlar> Deger2 { get; set; }
		public IEnumerable<BLog> Deger3 { get; set; }
	}
}