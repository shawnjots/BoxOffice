using HomeCinema.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace HomeCinema.Data
{
    public class EntityBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(e => e.ID);
        }
    }
}
