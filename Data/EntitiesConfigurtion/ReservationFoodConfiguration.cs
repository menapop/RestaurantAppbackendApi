using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntitiesConfigurtion
{
   public class ReservationFoodConfiguration  : IEntityTypeConfiguration<ReservationFood>
    {
        public void Configure(EntityTypeBuilder<ReservationFood> builder)
    {
        builder.ToTable("ReservationFood");
        #region Properties

        builder.HasKey(x => x.Id);

        #endregion

        #region Relations
        #endregion
    }
}
}