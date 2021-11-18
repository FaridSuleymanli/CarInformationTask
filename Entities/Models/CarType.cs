using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.Entities.Models
{
    public class CarType
    {
        public int CarTypeId { get; set; }
        public string TypeName { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
