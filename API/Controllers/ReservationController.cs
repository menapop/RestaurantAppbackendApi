using API.Controllers.Filters;
using DTOS.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repo.Repository.FoodTypeRepository;
using Repo.Repository.TableRepository;
using Service.reservation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
      
        public ReservationController(IReservationService reservationService, IFoodyTypeRepository foodyTypeRepository, ITableRepository tableRepository)
        {
            _reservationService = reservationService;
        
        }
        [HttpGet]

        public async Task<ActionResult<List<OutputReservationDto>>> GetAllReservation()
        {
            try
            {
                return Ok(await _reservationService.GetAllReservation());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        public async Task<ActionResult<TableDto>> GetTables()
        {
            try
            {
                return Ok(await _reservationService.GetTables());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [HttpGet]
        public async Task<ActionResult<FoodTypeDto>> GetFoodTypes()
        {
            try
            {
                return Ok(await _reservationService.GetFoodTypes());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


       
        [HttpPost]
        
        public async Task<ActionResult<bool>> Reserve(CreateReservationDto createReservationDto)
        {
            try
            {
                return Ok(await _reservationService.CreateReservation(createReservationDto));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
        }
    }
}
