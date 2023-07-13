using Mango.Services.CoponApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CoponApi.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "hs01",
                DiscountAmount = 0.1,
                MinAmount = 200

            });


            builder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "hs02",
                DiscountAmount = 0.15,
                MinAmount = 800

            });

        }
    }
}
