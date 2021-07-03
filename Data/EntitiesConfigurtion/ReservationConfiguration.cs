using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.EntitiesConfigurtion
{
    public class ReservationConfiguration  : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.ToTable("Reservation");
        #region Properties

        builder.HasKey(x => x.Id);

        #endregion

        #region Relations
        #endregion
    }
}
}