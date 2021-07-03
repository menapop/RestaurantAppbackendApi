using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class ReservationFood : BaseEntity
    {
        public int foodTypeId { get; set; }

        public int Quantity  { get; set; }

        public virtual FoodType foodType { get; set; }
        

    }
}
