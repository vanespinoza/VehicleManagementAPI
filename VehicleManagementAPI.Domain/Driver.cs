using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementAPI.Domain
{
    public class Driver : DomainBase
    {
        public string Dni { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateTime Birthday { get; set; } = default!;

    }
}
