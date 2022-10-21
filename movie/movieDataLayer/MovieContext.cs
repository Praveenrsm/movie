using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using movieentity1;
namespace movieDataLayer
{
    public class MovieContext:DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<MovieEL> movies { get; set; }
         public DbSet<Theatre> theatre { get; set; }
         public DbSet<ShowTiming> showTiming { get; set; }
        public DbSet<Booking> booking { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<UserInfo> userInfo { get; set; }
        public DbSet<Admin> admin { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2235;Initial Catalog = bookmyshow1 ;Integrated Security = True;");
        }
    }
}
