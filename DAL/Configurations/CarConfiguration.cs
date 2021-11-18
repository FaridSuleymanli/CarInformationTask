using CarInformationTask.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.DAL.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.HasKey(m => m.CarId);

            builder.Property(m => m.CarId).UseIdentityColumn();

            builder.HasOne(c => c.CarType).WithMany(m => m.Cars).HasForeignKey(c => c.CarTypeId).OnDelete(DeleteBehavior.Restrict);

            builder.Property(m => m.Brand).IsRequired().HasMaxLength(50);

            builder.Property(m => m.Model).IsRequired().HasMaxLength(50);

            builder.Property(m => m.Price).IsRequired();

            builder.Property(m => m.Year).IsRequired();
        }
    }
}
