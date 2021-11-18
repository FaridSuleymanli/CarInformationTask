using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.Entities.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Price { get; set; }
        public int CarTypeId { get; set; }
        public CarType CarType { get; set; }
    }
}
