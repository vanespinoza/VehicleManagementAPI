using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementAPI.Domain
{
    public class Brand : DomainBase
    {
        public string Code { get; set; } = default!;
        public string Name { get; set; } = default!;
    }
}
