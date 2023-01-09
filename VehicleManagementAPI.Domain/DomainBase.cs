using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementAPI.Domain
{
    public class DomainBase
    {
        public string Id { get; set; } = default!;
        public bool Status { get; set; }

        protected DomainBase()
        {
            Id = Guid.NewGuid().ToString();
            Status = true;
        }
    }
}
