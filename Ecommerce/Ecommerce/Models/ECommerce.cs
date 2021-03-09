using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class ECommerceContext: DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        public DbSet<Ecommerce.Models.Province> Provinces { get; set; }

        public System.Data.Entity.DbSet<Ecommerce.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<Ecommerce.Models.Company> Companies { get; set; }
    }
}