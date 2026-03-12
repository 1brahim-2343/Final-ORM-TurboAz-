using Final_ORM_TurboAz__.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Concrete.Entities.Mapping
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Cars");

            builder.Property(c => c.Model)
                .HasMaxLength(130)
                .IsRequired();

            

            builder.Property(c => c.VendorId)
                .IsRequired();

            builder.Property(c => c.BodyTypeId)
                .IsRequired();

            builder.Property(c => c.ColorId)
                .IsRequired();

            builder.Property(c => c.FuelType)
                .HasConversion<string>();

            builder.Property(c => c.IsNew)
                .HasDefaultValue(0);

            builder.Property(c => c.Mileage)
                .IsRequired();

            builder.Property(c => c.ProductionDate)
                .IsRequired();

            builder.Property(c => c.Price)
                .IsRequired();

            builder.Property(c => c.Quantity)
                .IsRequired();

            builder.Property(c => c.Quantity)
                .HasDefaultValue(1);

            builder.HasOne(c => c.Vendor)
                .WithMany()
                .HasForeignKey(c => c.VendorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.BodyType)
                .WithMany()
                .HasForeignKey(c => c.BodyTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Color)
                .WithMany()
                .HasForeignKey(c => c.ColorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
