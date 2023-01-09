using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementAPI.Domain;
using VehicleManagementAPI.Entities;

namespace VehicleManagementAPI.Repositories.Interfaces
{
    public interface IAssignmentRepository
    {
        Task<(ICollection<AssignmentInfo> Collection, int Total)> ListAsync(string? driverName, int page, int rows);
        Task<Assignment?> GetByIdAsync(string id);
        Task<string> CreateAsync(Assignment entity);
        Task UpdateAsync();
        Task DeleteAsync(string id);
       
    }
}
