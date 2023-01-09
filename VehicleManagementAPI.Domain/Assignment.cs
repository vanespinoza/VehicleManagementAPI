using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementAPI.Domain
{
    public class Assignment : DomainBase
    {
        public Vehicle Vehicle { get; set; } = default!;
        public string VehicleId { get; set; } = default!;
        public Driver Driver { get; set; } = default!;
        public string DriverId { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
