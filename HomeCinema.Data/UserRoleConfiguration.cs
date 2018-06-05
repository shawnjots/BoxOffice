using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data
{
    public class UserRoleConfiguration
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.Property(ur => ur.UserId).IsRequired();
            builder.Property(ur => ur.RoleId).IsRequired();
        }
    }
}
