using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Reservation : BaseEntity
    {
        public Reservation()
        {
            reservationFoods = new HashSet<ReservationFood>();
        }

        public int TableId { get; set; }

        public int userId { get; set; }

        public int NumberOfpeoples { get; set; }

        public string Notes { get; set; }

        public virtual Table table { get; set; }

        public virtual User user { get; set; }

        public virtual ICollection<ReservationFood> reservationFoods { get; set; }

    }
}
