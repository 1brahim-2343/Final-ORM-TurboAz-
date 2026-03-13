using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Concrete.Entities.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users", t =>
            {
                t.HasCheckConstraint("CK_Username", "TRIM([Username]) <>''");
                t.HasCheckConstraint("CK_Password", "TRIM([Password]) <> ''");
            });
            builder.Property(u => u.Username)
                .IsRequired();
            builder.Property(u => u.Password)
                .IsRequired();
            builder.HasMany(u => u.Posts)
                .WithOne(p=>p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
