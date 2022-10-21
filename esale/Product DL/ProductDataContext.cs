using Microsoft.EntityFrameworkCore;
using ProductEntity;
using System;
using System.Collections.Generic;

namespace Product_DL
{
    public class ProductDataContext :DbContext
    {
        public ProductDataContext(DbContextOptions<ProductDataContext> options) : base(options)
        {

        }
        public DbSet<Article> article { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Colour> colour { get; set; }
        public DbSet<Size> size { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2235;Initial Catalog = product4 ;Integrated Security = True;");
        }
    }
}
