using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementAPI.Domain;

namespace VehicleManagementAPI.DataAccess.Configurations
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id)
               .HasMaxLength(36);

            builder.Property(s => s.VehicleId)
                .HasMaxLength(36);

            builder.Property(s => s.DriverId)
               .HasMaxLength(36);

        }
    }
}