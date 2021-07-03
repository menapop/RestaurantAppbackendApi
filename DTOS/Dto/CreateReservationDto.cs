using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.Dto
{
   public  class CreateReservationDto
    {
        public int TableId { get; set; }

        public int NumberOfpeoples { get; set; }

        public string Notes { get; set; }

        public int UserId { get; set; }

        public List<ReservationFoodDto> reservationFoods { get; set; }
    }
}
