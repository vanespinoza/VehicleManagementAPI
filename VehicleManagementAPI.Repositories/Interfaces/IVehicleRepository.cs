using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementAPI.Domain;

namespace VehicleManagementAPI.Repositories.Interfaces
{
    public interface IVehicleRepository
    {
        Task<ICollection<Vehicle>> ListAsync(string? filter);
        Task<Vehicle?> GetByIdAsync(string id);
        Task<string> CreateAsync(Vehicle entity);
        Task UpdateAsync();
        Task DeleteAsync(string id);
    }
}
