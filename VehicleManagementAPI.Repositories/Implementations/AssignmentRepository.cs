using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementAPI.DataAccess;
using VehicleManagementAPI.Domain;
using VehicleManagementAPI.Entities;
using VehicleManagementAPI.Repositories.Interfaces;

namespace VehicleManagementAPI.Repositories.Implementations
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly VehicleManagementDbContext _context;
        public AssignmentRepository(VehicleManagementDbContext context)
        {
            _context = context;
        }

        public async Task<(ICollection<AssignmentInfo> Collection, int Total)> ListAsync(string? driverName, int page, int rows)
        {
            Expression<Func<Assignment, bool>> predicate = x => x.Driver.FullName.Contains(driverName ?? string.Empty);

            var query = _context.Set<Assignment>()
                .Where(predicate)
                .OrderBy(p => p.StartDate)
                .Skip((page - 1) * rows)
                .Take(rows)
                .Select(x => new AssignmentInfo
                {
                    AssignmentId = x.Id,
                    DriverName = x.Driver.FullName,
                    BrandVehicle = x.Vehicle.Brand.Name,
                    LicensePlate = x.Vehicle.LicensePlate,
                    ModelVehicle = x.Vehicle.Model,
                    StartDate = x.StartDate.ToString("yyyy MMMM dd"),
                    EndDate = x.EndDate.ToString("yyyy MMMM dd"),
                    Amount = (x.EndDate - x.StartDate).Days.ToString()
                })
                .AsNoTracking()
            .AsQueryable();

            var count = await _context.Set<Assignment>()
                .Where(predicate)
                .CountAsync();


            return (await query.ToListAsync(), count);
        }

        public async Task<Assignment?> GetByIdAsync(string id)
        {
            return await _context.Set<Assignment>()
                .AsTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<string> CreateAsync(Assignment entity)
        {
            await _context.Set<Assignment>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
                entity.Status = false;

            await _context.SaveChangesAsync();
        }
    }
}