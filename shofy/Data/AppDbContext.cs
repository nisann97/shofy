using System;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using shofy.Models;
namespace shofy.Data

{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Slider> Sliders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(x => !x.SoftDeleted);
            modelBuilder.Entity<Slider>()
                        .HasData(
           new Slider
           {
               Id = 1,
               Title = "The best tablet Collection 2024",
               Description = "<p>Exclusive offer <span>-35%</span> off this week<img src=\"~/assets/icons/offer-line.svg\" alt=\"\"></p>\n",
               Image = "slider-img-1.png"
           },
          new Slider
          {
              Id = 2,
              Title = "The best note book Collection 2024",
              Description = "<p>Exclusive offer <span>-10%</span> off this week<img src=\"~/assets/icons/offer-line.svg\" alt=\"\"></p>",
              Image = "slider-img-2.png"
          },
          new Slider
          {
              Id = 3,
              Title = "The best tablet Collection 2024",
              Description = "<p>Exclusive offer <span>-10%</span> off this week<img src=\"~/assets/icons/offer-line-red.svg\" alt=\"\"></p>\n",
              Image = "slider-img-3.png"
          }
         );
        }
    }
}

