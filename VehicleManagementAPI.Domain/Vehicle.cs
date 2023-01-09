using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementAPI.Domain
{
    public class Vehicle : DomainBase
    {
        public Brand Brand { get; set; } = default!;
        public string BrandId { get; set; } = default!;
        public string LicensePlate { get; set; } = default!;
        public string Model { get; set; } = default!;

    }
}
