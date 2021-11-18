using CarInformationTask.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.DAL
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.ApplyConfigurationsFromAssembly(typeof(CarType).Assembly);

            model.Entity<CarType>().HasData
                (
                    new CarType { CarTypeId = 1, TypeName = "Sedan"},
                    new CarType { CarTypeId = 2, TypeName = "SUV"},
                    new CarType { CarTypeId = 3, TypeName = "Pickup Truck"},
                    new CarType { CarTypeId = 4, TypeName = "Coupe" },
                    new CarType { CarTypeId = 5, TypeName = "Minivan" }
                );

            model.Entity<Car>().HasData
                (
                    new Car { CarId = 1, Brand = "Audi", Model = "Q7", Price = "38.000 AZN", Year = 2015, CarTypeId = 2 }
                );
        }
        public virtual DbSet<CarType> CarTypes { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
    }
}
