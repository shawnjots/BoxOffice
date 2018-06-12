using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(100);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(200);
            builder.Property(u => u.HashedPassword).IsRequired().HasMaxLength(200);
            builder.Property(u => u.Salt).IsRequired().HasMaxLength(200);
            builder.Property(u => u.IsLocked).IsRequired();
            builder.Property(u => u.DateCreated);
        }
    }
}
