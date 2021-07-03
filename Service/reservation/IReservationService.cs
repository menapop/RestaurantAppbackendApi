using DTOS.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.reservation
{
    public interface IReservationService
    {
        Task<List<OutputReservationDto>> GetAllReservation();
        Task<bool> CreateReservation(CreateReservationDto createReservationDto);

        Task<List<TableDto>> GetTables();

        Task<List<FoodTypeDto>> GetFoodTypes();
    }
}
