using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data
{
     public class MovieConfiguration
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(m => m.Title).IsRequired().HasMaxLength(100);
            builder.Property(m => m.GenreId).IsRequired();
            builder.Property(m => m.Director).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Writer).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Producer).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Writer).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Rating).IsRequired();
            builder.Property(m => m.Description).IsRequired().HasMaxLength(2000);
            builder.Property(m => m.TrailerURI).HasMaxLength(200);
            builder.HasMany(m => m.Stocks).WithOne().HasForeignKey(s => s.MovieId);
        }
    }
}
