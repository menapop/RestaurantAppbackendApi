using Data.Entities;
using AutoMapper;
using DTOS.Dto;
using Repo;
using DTOS.UserDtos;
using DTOS;
using System.Linq;

namespace Service
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            
            CreateMap<CreateUserDto, User>()
                .ForMember(src => src.UserName, opt => opt.MapFrom(dst => dst.Email));
            CreateMap<OutputRefreshTokenDto, OutputSignInUserDto>().ReverseMap();
           
            CreateMap<User, OutputUserDto>()
                 .ForMember(src => src.Roles, opt => opt.MapFrom(dst => dst.UserRoles.Select(R=>R.RoleId)));

            CreateMap<ReservationFoodDto, ReservationFood>();

            CreateMap<CreateReservationDto, Reservation>()
                 .ForMember(src => src.userId, opt => opt.MapFrom(dst => dst.UserId));

            CreateMap<Table, TableDto>();


            CreateMap<FoodType, FoodTypeDto>();

                CreateMap<Reservation, OutputReservationDto>()
                 .ForMember(src => src.FirstName, opt => opt.MapFrom(dst => dst.user.FirstName))
                 .ForMember(src => src.tableNumber, opt => opt.MapFrom(dst => dst.table.tableNumber));




        }
    }
}
