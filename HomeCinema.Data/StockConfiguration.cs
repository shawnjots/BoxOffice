using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data
{
    public class StockConfiguration
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.Property(s => s.MovieId).IsRequired();
            builder.Property(s => s.UniqueKey).IsRequired();
            builder.Property(s => s.IsAvailable).IsRequired();
            builder.HasMany(s => s.Rentals).WithOne(r => r.Stock).HasForeignKey(r => r.StockId);

        }
    }
}
