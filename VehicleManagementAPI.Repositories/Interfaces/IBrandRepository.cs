using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementAPI.DataAccess;
using VehicleManagementAPI.Domain;

namespace VehicleManagementAPI.Repositories.Interfaces
{
    public  interface IBrandRepository
    {
        Task<ICollection<Brand>> ListAsync(string? filter);
        Task<Brand?> GetByIdAsync(string id);
        Task<string> CreateAsync(Brand entity);
        Task UpdateAsync();
        Task DeleteAsync(string id);
    }
}
