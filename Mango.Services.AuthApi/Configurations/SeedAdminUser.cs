using Mango.Services.AuthApi.Data;
using Mango.Services.AuthApi.Models;
using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthApi.Configurations
{
	public class SeedAdminUser
	{
		private readonly AppDbContext _context;

		public SeedAdminUser(AppDbContext context) 
		{
			this._context = context;
		}

		//public async Task initialize(UserManager<ApiUser> _userManager)
		//{
		//	context.Database.EnsureCreated();
		//	try
		//	{
		//		var x = await _userManager.FindByEmailAsync("Ali@admin.com");
		//	}
		//	catch (Exception ex)
		//	{

		//	}

		//	if (await _userManager.FindByEmailAsync("Ali@admin.com") == null)
		//	{
		//		var user = new ApiUser
		//		{
		//			Email = "Ali@admin.com",
		//			FirstName = "Ali",
		//			LastName = "Ali",
		//			UserName = "user11",

		//		};
		//		await _userManager.CreateAsync(user, "Youssef@123456");
		//		await _userManager.AddToRoleAsync(user, "Admin");





		//	}
		}
}
