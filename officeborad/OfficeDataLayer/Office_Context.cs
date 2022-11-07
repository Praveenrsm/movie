using Microsoft.EntityFrameworkCore;
using OfficeEntity;
using System;
using System.Collections.Generic;

namespace OfficeDataLayer
{
    public class Office_Context : DbContext
    {
        public Office_Context(DbContextOptions<Office_Context> options) : base(options)
        {

        }
        public DbSet<user> user { get; set; }
        public DbSet<Profile> profiles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2235;Initial Catalog = officeboard123 ;Integrated Security = True;");
        }
    }
}
