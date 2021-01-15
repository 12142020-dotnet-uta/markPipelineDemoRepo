using System;
using Microsoft.EntityFrameworkCore;
using ModelLayer;

namespace RepositoryLayer
{
	public class DbContextClass : DbContext
	{
		public DbSet<Player> players { get; set; }
		public DbSet<Round> rounds { get; set; }
		public DbSet<Match> matches { get; set; }

		public DbContextClass() { }
		public DbContextClass(DbContextOptions options) : base(options) { }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseSqlServer("Server=tcp:myshopazuredbserver.database.windows.net,1433;Initial Catalog=MyShopAzure;Persist Security Info=False;User ID=markcmoore;Password=cU5tod33qUal;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
			}
		}
	}
}
