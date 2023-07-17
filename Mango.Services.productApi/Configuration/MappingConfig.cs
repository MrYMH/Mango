using AutoMapper;
using Mango.Services.productApi.Models;
using Mango.Services.productApi.Models.Dtos;

namespace Mango.Services.productApi.Configuration
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Product, ProductDto>().ReverseMap();

        }


    }
}
