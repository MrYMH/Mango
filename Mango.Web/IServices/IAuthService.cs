using Mango.Web.Models;
using Mango.Web.Models.Dtos;

namespace Mango.Web.IServices
{
	public interface IAuthService
	{
		Task<ResponseDto?> Register(RegisterUserDto userDto);
		Task<ResponseDto?> GetToken(LoginUserDto model);
		Task<ResponseDto?> AddRole(AddToRoleDto model , string token);
	}
}
