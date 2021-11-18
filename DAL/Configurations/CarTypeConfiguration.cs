using CarInformationTask.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.DAL.Configurations
{
    public class CarTypeConfiguration : IEntityTypeConfiguration<CarType>
    {
        public void Configure(EntityTypeBuilder<CarType> builder)
        {
            builder.ToTable("CarTypes");

            builder.HasKey(c => c.CarTypeId);

            builder.Property(c => c.CarTypeId).UseIdentityColumn();

            builder.Property(c => c.TypeName).IsRequired().HasMaxLength(50);
        }
    }
}
