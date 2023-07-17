using AutoMapper;
using Mango.Services.productApi.Models;
using Mango.Services.productApi.Models.Dtos;
using Mango.Services.ProductApi.Data;
using Mango.Services.ProductApi.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CoponApi.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly AppDbContext _db;
        private readonly ResponseDto _response;
        private readonly IMapper _mapper;


        public ProductApiController(AppDbContext db , IMapper mapper)
        {
            _db = db;
            _response = new ResponseDto();
            _mapper = mapper;
        }


        [HttpGet]
        public ResponseDto Get()
        {
            try
            {
                var objList = _db.Products.ToList();
                _response.Result = _mapper.Map<IEnumerable<ProductDto>>(objList);
            }
            catch(Exception ex) 
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpGet("{id}")]
        public ResponseDto Get(int id)
        {
            try
            {
                var coupon = _db.Products.Find(id);
                _response.Result = _mapper.Map<ProductDto>(coupon);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        //[HttpGet("{code}")]
        //public ResponseDto Get(string code)
        //{
        //    try
        //    {
        //        var coupon = _db.Products.FirstOrDefault(c => c.CouponCode.ToLower() == code.ToLower());
        //        _response.Result = _mapper.Map<CouponDto>(coupon);
        //    }
        //    catch (Exception ex)
        //    {
        //        _response.IsSuccess = false;
        //        _response.Message = ex.Message;
        //    }
        //    return _response;
        //}

        [HttpPost]
        public ResponseDto Post([FromBody] ProductDto objDto)
		{
			try
			{
                var obj = _mapper.Map<Product>(objDto);
                _db.Products.Add(obj);
                _db.SaveChanges();
                _response.Message = "Product Added successfuly";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }


        [HttpPut]
        public ResponseDto Put([FromBody] ProductDto objDto)
        {
            try
            {
                var obj = _mapper.Map<Product>(objDto);
                _db.Products.Update(obj);
                _db.SaveChanges();
                _response.Message = "Product Updated successfuly";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }

        [HttpDelete("{id}")]
        public ResponseDto Delete(int id)
        {
            try
            {
                var obj = _db.Products.Find(id);
                _db.Products.Remove(obj);
                _db.SaveChanges();
                _response.Message = "Product Deleted successfuly";
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
