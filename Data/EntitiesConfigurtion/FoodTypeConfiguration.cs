using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntitiesConfigurtion
{
    class FoodTypeConfiguration : IEntityTypeConfiguration<FoodType>
    {
        public void Configure(EntityTypeBuilder<FoodType> builder)
        {
            builder.ToTable("FoodType");
            #region Properties

            builder.HasKey(x => x.Id);

            #endregion

            #region Relations
            #endregion
        }
    }
}