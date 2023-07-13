using AutoMapper;
using Mango.Services.CoponApi.Models;
using Mango.Services.CoponApi.Models.DTOS;

namespace Mango.Services.CoponApi.Configuration
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();

        }


    }
}
