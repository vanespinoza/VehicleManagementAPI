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
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasKey(e => e.Id);
            
            builder.Property(e => e.Id)
                .HasMaxLength(36);

            builder.Property(e => e.Dni)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Phone)
              .IsRequired()
              .HasMaxLength(50);

        }

    }
}
