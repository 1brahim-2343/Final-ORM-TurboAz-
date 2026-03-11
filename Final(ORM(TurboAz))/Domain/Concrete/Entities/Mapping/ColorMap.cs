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
    public class ColorMap : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Colors");
            builder.Property(c => c.Name)
                .IsRequired();
            builder.Property(c => c.IsMatte)
                .HasDefaultValue(0);

            builder.Property(c => c.Id)
            .ValueGeneratedNever();
        }
    }
}
