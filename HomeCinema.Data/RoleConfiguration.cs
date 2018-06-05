using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data
{
    public class RoleConfiguration
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(ur => ur.Name).IsRequired().HasMaxLength(50);
        }
    }
}
