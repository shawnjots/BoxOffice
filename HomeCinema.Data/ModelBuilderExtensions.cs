using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeCinema.Data
{
    public static class ModelBuilderExtensions
    {
        public static void RemovePluralizingTableNameConvention(this  ModelBuilder modelBuilder)
        {
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
               //entity. = entity.DisplayName(); //Find method TableName. 
            }
        }
    }
}
