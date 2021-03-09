using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Clases
{
    public class CombosHelper: IDisposable

    {
        private static ECommerceContext db = new ECommerceContext();
        public static List<Province> GetProvinces()
        {
            var provinces = db.Provinces.ToList();
            provinces.Add(new Province
            {
                ProvinceId = 0,
                Name = "[Seleccione la provincia....]",
            });
           return provinces.OrderBy(d => d.Name).ToList();
        }

        public static List<City> GetCities()
        {
            var cities = db.Cities.ToList();
            cities.Add(new City
            {
                CityId = 0,
                Name = "[Seleccione la ciudad....]",
            });
            return cities.OrderBy(d => d.Name).ToList();
        }


        public void Dispose()
        {
            db.Dispose();
        }
    }
}