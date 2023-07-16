using Mango.Web.Models.Dtos;

namespace Mango.Web.IServices
{
    public interface IBaseService
    {
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
