using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementAPI.Domain;

namespace VehicleManagementAPI.Repositories.Interfaces
{
    public interface IDriverRepository
    {
        Task<ICollection<Driver>> ListAsync(string? filter);
        Task<Driver?> GetByIdAsync(string id);
        Task<string> CreateAsync(Driver entity);
        Task UpdateAsync();
        Task DeleteAsync(string id);
    }
}
