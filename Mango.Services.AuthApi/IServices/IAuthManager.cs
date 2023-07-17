
using Mango.Services.AuthApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.Services.AuthApi.IServices
{
    public interface IAuthManager
    {
        Task<AuthModel> RegisterAsync(RegisterationRequestDto userDto);
        Task<AuthModel> GetTokenAsync(LoginUserDto model);
        Task<string> AddRoleAsync(AddToRoleDto model);
    }
}
