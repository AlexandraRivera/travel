using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel.Models;

namespace Travel.Clase
{
    public class CombosHelper : IDisposable
    {
        private static
            TravelContext db = new TravelContext();

        public static IEnumerable Get { get; internal set; }

        public static List<Department> GetDepartments()

        {
            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name = "[Seleccione la provincia...]",

            });
            return departments.OrderBy(d => d.Name).ToList();


        }

        public static List<City> GetCities()

        {
            var cities = db.Cities.ToList();
            cities.Add(new City
            {
                CityId = 0,
                Name = "[Seleccione la ciudad...]",

            });
            return cities.OrderBy(d => d.Name).ToList();


        }

        public static List<Car> GetCars()

        {
            var cars = db.Cars.ToList();
            cars.Add(new Car
            {
                CarId = 0,
                Plate = "[Seleccione la placa...]",

            });
            return cars.OrderBy(d => d.Plate).ToList();


        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}