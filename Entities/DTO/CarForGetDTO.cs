using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.Entities.DTO
{
    public class CarForGetDTO
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Price { get; set; }
        public int CarTypeId { get; set; }

        public CarTypeForGetDTO CarType { get; set; }
    }
}
