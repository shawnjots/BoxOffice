using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data
{
    public class CustomerConfiguration
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(100);
            builder.Property(u => u.IdentityCard).IsRequired().HasMaxLength(50);
            builder.Property(u => u.UniqueKey).IsRequired();
            builder.Property(c => c.Mobile).HasMaxLength(15);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(200);
            builder.Property(c => c.DateOfBirth).IsRequired();
        }
    }
}
