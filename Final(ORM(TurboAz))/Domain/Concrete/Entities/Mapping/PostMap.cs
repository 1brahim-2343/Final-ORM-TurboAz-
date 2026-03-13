using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Concrete.Entities.Mapping
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.Property(p => p.Car)
                .IsRequired();
            builder.HasOne(p => p.Car)
                .WithOne()
                .HasForeignKey<Post>(p => p.CarID);
            builder.Property(p => p.User)
                .IsRequired();
        }
    }
}
