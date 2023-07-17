using AutoMapper;
using Mango.Services.AuthApi.Models;
using Mango.Services.AuthApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.Services.AuthApi.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            //creater maping configuration of user model
            CreateMap<ApiUser, LoginUserDto>().ReverseMap();
            CreateMap<ApiUser, RegisterUserDto>().ReverseMap();
            CreateMap<ApiUser, AuthModel>().ReverseMap();
            CreateMap<ApiUser, AddToRoleDto>().ReverseMap();

        }
    }
}
