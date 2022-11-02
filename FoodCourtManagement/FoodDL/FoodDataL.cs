using System;
using System.Collections.Generic;
using FoodCourtEntity;
using Microsoft.EntityFrameworkCore;
using System.Text;
namespace FoodDL
{
    public class FoodDataL : DbContext
    {
        public DbSet<FoodEntityEL> Fooditems2 { get; set; }
        public DbSet<FoodCategoryEL> foodcategory { get; set; }
        public DbSet<salesEL> sales { get; set; }
        //public DbSet<reportEL> report { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2235;Initial Catalog = foodstables;Integrated Security = True;");
        }
    }
}
