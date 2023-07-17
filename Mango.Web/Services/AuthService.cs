using Mango.Web.IServices;
using Mango.Web.Models;
using Mango.Web.Models.Dtos;
using Mango.Web.Utility;

namespace Mango.Web.Services
{
	public class AuthService : IAuthService

	{
		private readonly IBaseService _baseService;

		public AuthService(IBaseService baseService)
		{
			this._baseService = baseService;
		}


		public async Task<ResponseDto?> AddRole(AddToRoleDto model , string token)
		{
			return await _baseService.SendAsync(new RequestDto()
			{
				ApiType = SD.ApiType.POST,
				Data = model,
				AccessToken = token,
				Url = SD.AuthAPIBase + "/api/Identity/addrole"
			});
		}

		public async Task<ResponseDto?> GetToken(LoginUserDto model)
		{
			return await _baseService.SendAsync(new RequestDto()
			{
				ApiType = SD.ApiType.POST,
				Data = model,
				Url = SD.AuthAPIBase + "/api/Identity/login"
			});
		}

		public async Task<ResponseDto?> Register(RegisterUserDto model)
		{
			return await _baseService.SendAsync(new RequestDto()
			{
				ApiType = SD.ApiType.POST,
				Data = model,
				Url = SD.AuthAPIBase + "/api/Identity/register"
			});
		}
	}
}
