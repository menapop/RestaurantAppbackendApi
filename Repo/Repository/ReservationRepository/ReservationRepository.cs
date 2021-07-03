using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repo.shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repository.ReservationRepository
{
    public class ReservationRepository : Repository<Reservation> , IReservationRepository
    {
        private DbSet<Reservation> ReservationEntity;
        public ReservationRepository(ApplicationContext context) : base(context)
        {
            ReservationEntity = context.Set<Reservation>();
        }
    }
}
