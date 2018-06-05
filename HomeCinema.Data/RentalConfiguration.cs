using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data
{
    public class RentalConfiguration
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.Property(r => r.CustomerId).IsRequired();
            builder.Property(r => r.StockId).IsRequired();
            builder.Property(r => r.Status).IsRequired().HasMaxLength(10);
            builder.Property(r => r.ReturnedDate).IsRequired(false);

        }
    }
}
