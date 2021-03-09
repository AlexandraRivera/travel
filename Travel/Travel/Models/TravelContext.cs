using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Travel.Models
{
    public class TravelContext: DbContext
    {
        public TravelContext() : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public System.Data.Entity.DbSet<Travel.Models.Department> Departments { get; set; }

        public System.Data.Entity.DbSet<Travel.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<Travel.Models.Car> Cars { get; set; }

        public System.Data.Entity.DbSet<Travel.Models.Driver> Drivers { get; set; }
    }
}