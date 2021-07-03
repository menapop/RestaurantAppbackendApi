using AutoMapper;
using Data.Entities;
using DTOS.Dto;
using Repo.Repository.FoodTypeRepository;
using Repo.Repository.ReservationRepository;
using Repo.Repository.TableRepository;
using Repo.UnitOfWork;
using Service.Helpers.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.reservation
{
    public class ReservationService : IReservationService
    {
       
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IReservationRepository _reservationRepository;
        private readonly IAuthService _authService;
        private readonly ITableRepository _tableRepository;
        private readonly IFoodyTypeRepository _foodyTypeRepository;


        public ReservationService( IMapper mapper, ITableRepository tableRepository, IFoodyTypeRepository foodyTypeRepository, IAuthService authService, IReservationRepository reservationRepository, IUnitOfWork unitOfWork )
        {
            _mapper = mapper;
            _reservationRepository = reservationRepository;
            _unitOfWork = unitOfWork;
            _authService = authService;
            _foodyTypeRepository = foodyTypeRepository;
            _tableRepository = tableRepository;
        }
        public async Task<bool> CreateReservation(CreateReservationDto createReservationDto)
        {
            var reservation = _mapper.Map<Reservation>(createReservationDto);
            var res=  await _reservationRepository.InsertAsync(reservation);
            _unitOfWork.Commit();
            return true;
        }

        public async Task<List<OutputReservationDto>> GetAllReservation()
        {
            return _mapper.Map<List<OutputReservationDto>>(await _reservationRepository.GetAllAsync(include: "table,user")) ;

        }

        public async Task<List<FoodTypeDto>> GetFoodTypes()
        {
            return _mapper.Map<List<FoodTypeDto>>(await _foodyTypeRepository.GetAllAsync());
        }

        public async Task<List<TableDto>> GetTables()
        {
            return _mapper.Map<List<TableDto>>(await _tableRepository.GetAllAsync());
        }
    }
}
