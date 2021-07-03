using DTOS;
using DTOS.Dto;
using DTOS.UserDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.UserService
{
    public interface IUserService
    {
        Task<OutputSignInUserDto> SignInAsync(InputSignInUserDto inputSignInUserDto);
        Task<OutputRefreshTokenDto> RefreshToken(InputRefreshTokenDto inputRefreshTokenDto);
        Task<OutputSignInUserDto> CreateUser(CreateUserDto createUserDto);
        
       
    }
}
