using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using movieentity1;
namespace BookingDb
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        {

        }
        public DbSet<Booking> bookings { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Location> locations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2235;Initial Catalog = bookingstable;Integrated Security = True;");
        }
    }
}
