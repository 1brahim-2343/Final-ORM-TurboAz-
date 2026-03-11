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
    public class BodyTypeMap : IEntityTypeConfiguration<BodyType>
    {
        public void Configure(EntityTypeBuilder<BodyType> builder)
        {
            builder.ToTable("BodyTypes");

            builder.Property(b => b.Name)
                .IsRequired();
            builder.Property(b => b.Id)
                .ValueGeneratedNever();
                
        }
    }
}
