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
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasMaxLength(36);

            builder.Property(e => e.LicensePlate)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Model)
                .IsRequired()
                .HasMaxLength(100);
        }

    }
}
