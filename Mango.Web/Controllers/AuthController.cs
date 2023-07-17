using Mango.Web.IServices;
using Mango.Web.Models;
using Mango.Web.Models.Dtos;
using Mango.Web.Utility;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Rest;
using Newtonsoft.Json;
using System.Security.Claims;

namespace Mango.Web.Controllers
{
	public class AuthController : Controller
	{
		private readonly IAuthService _authService;
		//private readonly ITokenProvider _tokenProvider;

		public AuthController(IAuthService authService)
		{
			_authService = authService;
			//_tokenProvider = tokenProvider;
		}
		[HttpGet]
		public IActionResult Login()
		{
			LoginUserDto loginRequestDto = new();
			return View(loginRequestDto);
		}

		//[HttpPost]
		//public async Task<IActionResult> Login(LoginUserDto obj)
		//{
		//	ResponseDto responseDto = await _authService.GetToken((obj));

		//	if (responseDto != null && responseDto.IsSuccess)
		//	{
		//		LoginResponseDto loginResponseDto =
		//			JsonConvert.DeserializeObject<LoginResponseDto>(Convert.ToString(responseDto.Result));

		//		await SignInUser(loginResponseDto);
		//		_tokenProvider.SetToken(loginResponseDto.Token);
		//		return RedirectToAction("Index", "Home");
		//	}
		//	else
		//	{
		//		TempData["error"] = responseDto.Message;
		//		return View(obj);
		//	}
		//}


		[HttpGet]
		public IActionResult Register()
		{
			var roleList = new List<SelectListItem>()
			{
				new SelectListItem{Text=SD.RoleAdmin,Value=SD.RoleAdmin},
				new SelectListItem{Text=SD.RoleUser,Value=SD.RoleUser},
			};

			ViewBag.RoleList = roleList;
			return View();
		}


        [HttpPost]
        public IActionResult Register(RegisterationRequestDto model)
        {
            
            return View();
        }





        //private async Task SignInUser(LoginUserDto model)
        //{
        //	var handler = new JwtSecurityTokenHandler();

        //	var jwt = handler.ReadJwtToken(model.Token);

        //	var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
        //	identity.AddClaim(new Claim(JwtRegisteredClaimNames.Email,
        //		jwt.Claims.FirstOrDefault(u => u.Type == JwtRegisteredClaimNames.Email).Value));
        //	identity.AddClaim(new Claim(JwtRegisteredClaimNames.Sub,
        //		jwt.Claims.FirstOrDefault(u => u.Type == JwtRegisteredClaimNames.Sub).Value));
        //	identity.AddClaim(new Claim(JwtRegisteredClaimNames.Name,
        //		jwt.Claims.FirstOrDefault(u => u.Type == JwtRegisteredClaimNames.Name).Value));


        //	identity.AddClaim(new Claim(ClaimTypes.Name,
        //		jwt.Claims.FirstOrDefault(u => u.Type == JwtRegisteredClaimNames.Email).Value));
        //	identity.AddClaim(new Claim(ClaimTypes.Role,
        //		jwt.Claims.FirstOrDefault(u => u.Type == "role").Value));



        //	var principal = new ClaimsPrincipal(identity);
        //	await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        //}

    }
}
