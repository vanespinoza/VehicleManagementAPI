using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementAPI.DataAccess;
using VehicleManagementAPI.Domain;
using VehicleManagementAPI.Repositories.Interfaces;

namespace VehicleManagementAPI.Repositories.Implementations
{
    public class DriverRepository : IDriverRepository
    {
        private readonly VehicleManagementDbContext _context;

        public DriverRepository(VehicleManagementDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Driver>> ListAsync(string? filter)
        {
            var list = await _context.Set<Driver>()
                    .Where(p => p.FullName.StartsWith(filter ?? string.Empty))
                    .ToListAsync();

            return list;
        }

        public async Task<Driver?> GetByIdAsync(string id)
        {
            var entity = await _context.Set<Driver>()
                    .AsTracking()
                    .FirstOrDefaultAsync(p => p.Id == id);

            return entity;
        }

        public async Task<string> CreateAsync(Driver entity)
        {
            await _context.Set<Driver>().AddAsync(entity);
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
            if (entity == null) return;
            entity.Status = false;
            await _context.SaveChangesAsync();
        }
    }
}
