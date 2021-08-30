using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelTripProje2.Models.Siniflar
{
	public class Context : DbContext
	{
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Adres> Adreses { get; set; }
		public DbSet<BLog> BLogs { get; set; }
		public DbSet<Hakkımızda> Hakkimizda { get; set; }
		public DbSet<iletisim> İletisims { get; set; }
		public DbSet<Yorumlar>	Yorumlars { get; set; }
	}
}